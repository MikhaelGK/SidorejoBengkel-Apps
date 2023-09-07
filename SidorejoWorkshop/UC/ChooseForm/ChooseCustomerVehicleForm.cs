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

namespace SidorejoWorkshop.UC.ChooseForm
{
    public partial class ChooseCustomerVehicleForm : Form
    {
        private int _choosenId;

        public ChooseCustomerVehicleForm()
        {
            InitializeComponent();
        }

        private void LoadData(string query)
        {
            var context = new db();
            var dt = context.CustomerVehicles
                .Include(x => x.Customer)
                .Include(x => x.Vehicle)
                .Where(x => 
                    x.CustomerId.Contains(query) || 
                    x.Customer.Name.Contains(query) || 
                    x.Vehicle.Name.Contains(query) || 
                    x.PoliceNumber.Contains(query))
                .ToList();

            dt = dt.Where(x => x.DeletedAt == null).ToList();

            dgv.DataSource = dt.Select(x => new
            {
                colId = x.CustomerVehicleId,
                colCId = x.CustomerId,
                colCName = x.Customer.Name,
                colVId = x.VehicleId,
                colVName = x.Vehicle.Name,
                colVNumber = x.PoliceNumber
            }).ToList();
        }

        private void ChooseCustomerVehicleForm_Load(object sender, EventArgs e)
        {
            LoadData("");
        }

        private void iBtnSearch_Click(object sender, EventArgs e)
        {
            LoadData(tBoxSearch.Text);
        }

        private void iBtnSelect_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv.CurrentRow;
            if (selectedRow is null)
            {
                SnippetMbox.MboxError("Choose Customer Vehicle", "No row selected");
                return;
            }
            _choosenId = Convert.ToInt32(selectedRow.Cells[0].Value);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void iBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int GetCustomerVehicleId()
        {
            return _choosenId;
        }
    }
}
