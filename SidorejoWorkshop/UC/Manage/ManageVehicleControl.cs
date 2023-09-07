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
    public partial class ManageVehicleControl : UserControl
    {
        private Operation _operation = Operation.None;
        private string _title = "Manage Vehicle";
        private string _choosenId;

        public ManageVehicleControl()
        {
            InitializeComponent();
        }

        private void LoadData(string search)
        {
            var context = new db();
            var vehicle = context.Vehicles
                .Where(x => x.VehicleId.Contains(search) || x.Name.Contains(search))
                .ToList();
            vehicle = vehicle.Where(x => x.DeletedAt == null).ToList();
            dgv.DataSource = vehicle.Select(x => new
            {
                colVId = x.VehicleId,
                colName = x.Name
            }).ToList();
        }

        private bool CheckValidation()
        {
            var strgs = new List<string>()
            {
                tBoxName.Text
            };
            if (!SnippetValidation.StringValidation(strgs))
            {
                SnippetMbox.MboxError(_title, "Name must be filled");
                return false;
            }

            return true;
        }

        private void ClearUI()
        {
            tBoxId.Clear();
            tBoxName.Clear();
        }

        private void ActivateUI(bool active)
        {
            tBoxName.Enabled = active;
            iBtnSave.Enabled = active;
            iBtnCancel.Enabled = active;

            iBtnAdd.Enabled = !active;
            iBtnUpdate.Enabled = !active;
            iBtnDelete.Enabled = !active;
        }

        private void ManageVehicleControl_Load(object sender, EventArgs e)
        {
            LoadData("");
        }

        private void iBtnAdd_Click(object sender, EventArgs e)
        {
            _operation = Operation.Add;
            ActivateUI(true);
            tBoxId.Text = SnippetGenerator.GenerateVehicleId();
        }

        private void iBtnUpdate_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv.CurrentRow;
            if (selectedRow is null)
            {
                SnippetMbox.MboxError(_title, "No row Selected");
                return;
            }

            _choosenId = selectedRow.Cells[0].Value.ToString();
            var context = new db();
            var vehicle = context.Vehicles.FirstOrDefault(x => x.VehicleId == _choosenId);
            tBoxId.Text = vehicle.VehicleId;
            tBoxName.Text = vehicle.Name;
            _operation = Operation.Update;
            ActivateUI(true);
        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv.CurrentRow;
            if (selectedRow is null)
            {
                SnippetMbox.MboxError(_title, "No row Selected");
                return;
            }
            _choosenId = selectedRow.Cells[0].Value.ToString();
            
            if (SnippetMbox.MboxQuestion(_title, "Do you want to delete the data") == DialogResult.Yes)
            {
                var context = new db();
                var vehicles = context.Vehicles
                    .Include(x => x.CustomerVehicles)
                    .FirstOrDefault(x => x.VehicleId == _choosenId);

                foreach (var data in vehicles.CustomerVehicles) data.DeletedAt = DateTime.Now;

                vehicles.DeletedAt = DateTime.Now;
                context.SaveChanges();
                LoadData("");
            }
        }

        private void iBtnSearch_Click(object sender, EventArgs e)
        {
            LoadData(tBoxSearch.Text);
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
                    var item = new Vehicle()
                    {
                        VehicleId = tBoxId.Text,
                        Name = tBoxName.Text,
                        CreatedAt = DateTime.Now
                    };
                    context.Vehicles.Add(item);
                    break;
                case Operation.Update:
                    var vehicle = context.Vehicles.FirstOrDefault(x => x.VehicleId == _choosenId);
                    vehicle.Name = tBoxName.Text;
                    vehicle.UpdatedAt = DateTime.Now;
                    break;
                case Operation.Delete:
                    break;
                default:
                    break;
            }
            context.SaveChanges();
            ClearUI();
            ActivateUI(false);
            _operation = Operation.None;
            LoadData("");
        }

        private void iBtnCancel_Click(object sender, EventArgs e)
        {
            ClearUI();
            ActivateUI(false);
            _operation = Operation.None;
        }

    }
}
