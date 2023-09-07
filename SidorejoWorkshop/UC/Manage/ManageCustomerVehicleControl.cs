using SidorejoWorkshop.Helper.Snippet;
using SidorejoWorkshop.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidorejoWorkshop.UC.Manage
{
    public partial class ManageCustomerVehicleControl : UserControl
    {
        private Operation _operation = Operation.None;
        private string _title = "Manage Customer Vehicle";
        private int _choosenId;

        public ManageCustomerVehicleControl()
        {
            InitializeComponent();
        }

        private bool CheckValidation()
        {
            var strgs = new List<string>()
            {
                tBoxCId.Text,
                tBoxVId.Text,
                tBoxVNumber.Text,
            };
            if (!SnippetValidation.StringValidation(strgs))
            {
                return false;
            }

            return true;
        }

        private void ActivateUI(bool active)
        {
            gBoxCustomer.Enabled = active;
            gBoxVehicle.Enabled = active;
            iBtnSave.Enabled = active;
            iBtnCancel.Enabled = active;

            iBtnAdd.Enabled = !active;
            iBtnUpdate.Enabled = !active;
            iBtnDelete.Enabled = !active;
        }

        private void LoadData(string search)
        {
            var context = new db();
            var customerVehicles = context.CustomerVehicles
                .Where(x => x.DeletedAt == null)
                .ToList();
            var list = new List<CustomerVehicleViewModel>();
            foreach (var customerVehicle in customerVehicles)
            {
                var item = new CustomerVehicleViewModel()
                {
                    CustomerVehicleID = customerVehicle.CustomerVehicleId,
                    CustomerID = customerVehicle.CustomerId,
                    CustomerName = customerVehicle.Customer.Name,
                    VehicleName = customerVehicle.Vehicle.Name,
                    VehicleNumber = customerVehicle.PoliceNumber
                };
                list.Add(item);
            }
            dgv.DataSource = list
                .Where(x =>
                    x.CustomerID.Contains(search) ||
                    x.CustomerName.Contains(search) ||
                    x.VehicleName.Contains(search) ||
                    x.VehicleNumber.Contains(search))
                .Select(x => new
                {
                    colId = x.CustomerVehicleID,
                    colCId = x.CustomerID,
                    colCName = x.CustomerName,
                    colVName = x.VehicleName,
                    colVNumber = x.VehicleNumber
                }).ToList();
        }

        private void ClearUI()
        {
            tBoxCId.Clear();
            tBoxCName.Clear();
            tBoxPho.Clear();
            tBoxVId.Clear();
            tBoxVName.Clear();
            tBoxVNumber.Clear();
        }

        private void ManageCustomerVehicleControl_Load(object sender, EventArgs e)
        {
            LoadData("");
        }

        private void iBtnAdd_Click(object sender, EventArgs e)
        {
            _operation = Operation.Add;
            ActivateUI(true);
        }

        private void iBtnUpdate_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv.CurrentRow;
            if (selectedRow is null)
            {
                SnippetMbox.MboxError(_title, "No row selected");
                return;
            }
            _choosenId = (int)selectedRow.Cells[0].Value;

            var context = new db();
            var dt = context.CustomerVehicles.FirstOrDefault(x => x.CustomerVehicleId == _choosenId);
            tBoxCId.Text = dt.CustomerId;
            tBoxCName.Text = dt.Customer.Name;
            tBoxPho.Text = dt.Customer.Phone;
            tBoxVId.Text = dt.VehicleId;
            tBoxVName.Text = dt.Vehicle.Name;
            tBoxVNumber.Text = dt.PoliceNumber;

            _operation = Operation.Update;
            ActivateUI(true);
        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv.CurrentRow;
            if (selectedRow is null)
            {
                SnippetMbox.MboxError(_title, "No row selected");
                return;
            }
            _choosenId = (int)selectedRow.Cells[0].Value;

            if (SnippetMbox.MboxQuestion(_title, "Do you want to delete the data?") == DialogResult.Yes)
            {
                var context = new db();
                var customerVehicle = context.CustomerVehicles
                    .Include(x => x.DetailTrxes)
                    .FirstOrDefault(x => x.CustomerVehicleId == _choosenId);

                foreach (var item in customerVehicle.DetailTrxes) item.DeletedAt = DateTime.Now;

                customerVehicle.DeletedAt = DateTime.Now;
                context.SaveChanges();
                LoadData("");
            }
        }

        private void iBtnSave_Click(object sender, EventArgs e)
        {
            var valid = CheckValidation();
            if (!valid) return;

            var context = new db();
            switch (_operation)
            {
                case Operation.None:
                    break;
                case Operation.Add:
                    var item = new CustomerVehicle()
                    {
                        CustomerId = tBoxCId.Text,
                        VehicleId = tBoxVId.Text,
                        PoliceNumber = tBoxVNumber.Text,
                        CreatedAt = DateTime.Now
                    };
                    context.CustomerVehicles.Add(item);
                    break;
                case Operation.Update:
                    var customerVehicle = context.CustomerVehicles.FirstOrDefault(x => x.CustomerVehicleId == _choosenId);
                    customerVehicle.CustomerId = tBoxCId.Text;
                    customerVehicle.VehicleId = tBoxVId.Text;
                    customerVehicle.PoliceNumber = tBoxVNumber.Text;
                    break;
                case Operation.Delete:
                    break;
                default:
                    break;
            }
            context.SaveChanges();
            _operation = Operation.None;
            ClearUI();
            ActivateUI(false);
            LoadData("");
        }

        private void iBtnCancel_Click(object sender, EventArgs e)
        {
            ClearUI();
            ActivateUI(false);
        }

        private void iBtnSearch_Click(object sender, EventArgs e)
        {
            LoadData(tBoxSearch.Text);
        }

        private void tBoxCId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                var form = new ChooseCustomerForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var id = form.GetCustomerId();
                    var context = new db();
                    var choosenCustomer = context.Customers.FirstOrDefault(x => x.CustomerId == id);
                    if (choosenCustomer != null)
                    {
                        tBoxCId.Text = choosenCustomer.CustomerId;
                        tBoxCName.Text = choosenCustomer.Name;
                        tBoxPho.Text = choosenCustomer.Phone;
                    }
                }
            }
        }

        private void tBoxVId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                var form = new ChooseVehicleForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var id = form.GetVehicleId();
                    var context = new db();
                    var choosenVehicle = context.Vehicles.FirstOrDefault(x => x.VehicleId == id);
                    if (choosenVehicle != null)
                    {
                        tBoxVId.Text = choosenVehicle.VehicleId;
                        tBoxVName.Text = choosenVehicle.Name;
                    }
                }
            }
        }
    }
}
