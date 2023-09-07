using FontAwesome.Sharp;
using SidorejoWorkshop.Helper.Snippet;
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
    public partial class ManageCustomerControl : UserControl
    {
        private Operation _operation = Operation.None;
        private string _title = "Manage Customer";
        private string _choosenId = "";

        public ManageCustomerControl()
        {
            InitializeComponent();
        }

        private bool CheckValidation()
        {
            var strgs = new List<string>()
            {
                tBoxName.Text,
                tBoxAds.Text,
                tBoxPho.Text
            };
            if (!SnippetValidation.StringValidation(strgs))
            {
                SnippetMbox.MboxError(_title, "All field must be filled");
                return false;
            }

            if (tBoxPho.TextLength < 10 || tBoxPho.TextLength > 12)
            {
                SnippetMbox.MboxError(_title, "Phone number must be between 10-12");
                return false; 
            }

            if (!SnippetValidation.IntValidation(tBoxPho.Text))
            {
                SnippetMbox.MboxError(_title, "Phone number must be numeric"); 
                return false;
            }

            return true;
        }

        private void ClearUI()
        {
            tBoxId.Clear();
            tBoxName.Clear();
            tBoxAds.Clear();
            tBoxPho.Clear();
        }

        private void ActivatedUI(bool active)
        {
            tBoxName.Enabled = active;
            tBoxAds.Enabled = active;
            tBoxPho.Enabled = active;
            iBtnSave.Enabled = active;
            iBtnCancel.Enabled = active;

            iBtnAdd.Enabled = !active;
            iBtnDelete.Enabled = !active;
            iBtnUpdate.Enabled = !active;
        }

        private void LoadData(string search)
        {
            var context = new db();
            var customers = context.Customers
                .Where(x =>
                    x.CustomerId.Contains(search) ||
                    x.Name.Contains(search) ||
                    x.Address.Contains(search) ||
                    x.Phone.Contains(search)
                ).ToList();
            customers = customers.Where(x => x.DeletedAt == null).ToList();
            dgv.DataSource = customers.Select(x => new
            {
                colCId = x.CustomerId,
                colName = x.Name,
                colAds = x.Address,
                colPho = x.Phone
            }).ToList();
        }

        private void ManageCustomerControl_Load(object sender, EventArgs e)
        {
            LoadData("");
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iBtnUpdate_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv.CurrentRow;
            if (selectedRow == null)
            {
                SnippetMbox.MboxError(_title, "No row selected");
                return;
            }
            _choosenId = selectedRow.Cells[0].Value.ToString();

            var context = new db();
            var customer = context.Customers.FirstOrDefault(x => x.DeletedAt == null && x.CustomerId == _choosenId);
            tBoxId.Text = _choosenId;
            tBoxName.Text = customer.Name;
            tBoxAds.Text = customer.Address;
            tBoxPho.Text = customer.Phone.ToString();

            ActivatedUI(true);
            _operation = Operation.Update;
        }

        private void iBtnAdd_Click(object sender, EventArgs e)
        {
            ActivatedUI(true);
            tBoxId.Text = SnippetGenerator.GenerateCustomerId();
            _operation = Operation.Add;
        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv.CurrentRow;
            if (selectedRow == null)
            {
                SnippetMbox.MboxError(_title, "No row selected");
                return;
            }
            _choosenId = selectedRow.Cells[0].Value.ToString();

            if (SnippetMbox.MboxQuestion(_title, "Do you want to delete the data") == DialogResult.Yes)
            {
                var context = new db();
                var customer = context.Customers
                    .Include(x => x.HeaderTrxes)
                    .Include(x => x.CustomerVehicles)
                    .FirstOrDefault(x => x.CustomerId == _choosenId);

                foreach (var data in customer.CustomerVehicles) data.DeletedAt = DateTime.Now;

                foreach (var data in customer.HeaderTrxes) data.DeletedAt = DateTime.Now;

                customer.DeletedAt = DateTime.Now;
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
                    var item = new Customer()
                    {
                        CustomerId = tBoxId.Text,
                        Name = tBoxName.Text,
                        Address = tBoxAds.Text,
                        Phone = tBoxPho.Text,
                        CreatedAt = DateTime.Now
                    };
                    context.Customers.Add(item);
                    context.SaveChanges();
                    break;
                case Operation.Update:
                    var customer = context.Customers
                        .FirstOrDefault(x => x.CustomerId == _choosenId);
                    customer.Name = tBoxName.Text;
                    customer.Address = tBoxAds.Text;
                    customer.Phone = tBoxPho.Text;
                    customer.UpdatedAt = DateTime.Now;
                    context.SaveChanges();
                    break;
                case Operation.Delete:
                    break;
                default:
                    break;
            }

            ClearUI();
            ActivatedUI(false);
            LoadData("");
        }

        private void iBtnCancel_Click(object sender, EventArgs e)
        {
            ClearUI();
            ActivatedUI(false);
        }

        private void iBtnSearch_Click(object sender, EventArgs e)
        {
            LoadData(tbSearch.Text);
        }
    }
}
