using SidorejoWorkshop.Helper.Snippet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidorejoWorkshop.UC.Manage
{
    public partial class ChooseVehicleForm : Form
    {
        private string _choosenId;
        private string _title = "Choose Vehicle";

        public ChooseVehicleForm()
        {
            InitializeComponent();
        }

        public string GetVehicleId()
        {
            return _choosenId;
        }

        private void LoadVehicles(string search)
        {
            var context = new db();
            var vehicles = context.Vehicles
                .Where(x =>
                    x.VehicleId.Contains(search) || x.Name.Contains(search)
                ).ToList();
            vehicles = vehicles.Where(x => x.DeletedAt == null).ToList();
            dgv.DataSource = vehicles.Select(x => new
            {
                colId = x.VehicleId,
                colName = x.Name
            }).ToList();
        }

        private void ChooseVehicleForm_Load(object sender, EventArgs e)
        {
            LoadVehicles("");
        }

        private void iBtnSearch_Click(object sender, EventArgs e)
        {
            LoadVehicles(tBoxSearch.Text);
        }

        private void iBtnSelect_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv.CurrentRow;
            if (selectedRow is null)
            {
                SnippetMbox.MboxError(_title, "No row selected");
                return;
            }
            _choosenId = selectedRow.Cells[0].Value.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void iBtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
