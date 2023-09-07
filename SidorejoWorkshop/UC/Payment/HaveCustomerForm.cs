using SidorejoWorkshop.Helper.Snippet;
using SidorejoWorkshop.UC.Manage;
using SidorejoWorkshop.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidorejoWorkshop.UC.Payment
{
    public partial class HaveCustomerForm : Form
    {
        private string _title = "Have Customer";

        public HaveCustomerForm()
        {
            InitializeComponent();
        }

        private bool CheckValidation()
        {
            if (rBtnYes.Checked) 
            { 
                var strgs = new List<string>()
                {
                    tBoxId.Text
                };
                if (!SnippetValidation.StringValidation(strgs))
                {
                    SnippetMbox.MboxError(_title, "Please select customer");
                    return false;
                }
            }

            return true;
        }

        private void iBtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tBoxId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                var sd = new ChooseCustomerForm();
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    var id = sd.GetCustomerId();
                    var context = new db();
                    var customer = context.Customers.FirstOrDefault(x => x.CustomerId == id);

                    tBoxId.Text = customer.CustomerId;
                    tBoxName.Text = customer.Name;
                    tBoxAds.Text = customer.Address;
                    tBoxPho.Text = customer.Phone;
                }
            }

        }

        private void rBtnYes_CheckedChanged(object sender, EventArgs e)
        {
            gBoxCustomer.Enabled = true;
        }

        private void rBtnNo_CheckedChanged(object sender, EventArgs e)
        {
            gBoxCustomer.Enabled = false;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            var valid = CheckValidation();
            if (!valid) return;

            try
            {
                var context = new db();
                var header = new HeaderTrx()
                {
                    CreatedAt = DateTime.Now,
                    Date = DateTime.Now,
                    TrxId = TrxProductConfirmViewModel.TrxID,
                };
                if (rBtnYes.Checked)
                {
                    header.CustomerId = tBoxId.Text;
                }
                context.HeaderTrxes.Add(header);
                context.SaveChanges();

                foreach (var item in TrxProductConfirmViewModel.Cart)
                {
                    var detail = new DetailTrx()
                    {
                        CreatedAt = DateTime.Now,
                        TrxId = header.TrxId,
                        ProductId = item.ProductID,
                        Qty = item.Qty,
                        Price = item.SellPrice
                    };
                    context.DetailTrxes.Add(detail);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                SnippetMbox.MboxError(_title, ex.ToString());
                return;
            }

            SnippetMbox.MboxInformation(_title, "Transaction Success");
            Close();
        }
    }
}
