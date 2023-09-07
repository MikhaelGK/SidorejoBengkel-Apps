using SidorejoWorkshop.Helper.Snippet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidorejoWorkshop.UC.Manage
{
    public partial class ChooseCustomerForm : Form
    {
        private string _choosenId;
        private string _title = "Choosen Customer";

        public ChooseCustomerForm()
        {
            InitializeComponent();
        }

        private void LoadCustomer(string search)
        {
            var context = new db();
            var customers = context.Customers
                .Where(x =>
                    x.CustomerId.Contains(search) ||
                    x.Name.Contains(search) ||
                    x.Address.Contains(search) ||
                    x.Phone.Contains(search)).ToList();
            customers = customers.Where(x => x.DeletedAt == null).ToList();
            dgv.DataSource = customers.Select(x => new
            {
                colId = x.CustomerId,
                colName = x.Name,
                colAds = x.Address,
                colPho = x.Phone
            }).ToList();
        }

        private void iBtnSearch_Click(object sender, EventArgs e)
        {
            LoadCustomer(tBoxSearch.Text);
        }

        private void ChooseCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomer("");
        }

        private void iBtnCancel_Click(object sender, EventArgs e)
        {
            Close();
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

        public string GetCustomerId()
        {
            return _choosenId;
        }
    }
}
