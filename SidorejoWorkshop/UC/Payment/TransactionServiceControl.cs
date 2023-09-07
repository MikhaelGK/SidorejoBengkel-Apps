using SidorejoWorkshop.Helper.Snippet;
using SidorejoWorkshop.UC.ChooseForm;
using SidorejoWorkshop.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidorejoWorkshop.UC.Payment
{
    public partial class TransactionServiceControl : UserControl
    {
        private List<TrxServiceViewModel> _carts = new List<TrxServiceViewModel>();
        private CustomerVehicle _data;
        private string _trxId;
        private string _title = "Transaction Service";

        public TransactionServiceControl()
        {
            InitializeComponent();
        }

        private void LoadCart()
        {
            dgv.DataSource = _carts.Select(x => new
            {
                colId = x.CustomerVehicleId,
                colDesc = x.Description,
                colPrice = SnippetCurrency.Currency(x.Price)
            }).ToList();

            var total = 0;
            foreach (var item in _carts)
            {
                total += item.Price;
            }

            lTotal.Text = "Total: " + SnippetCurrency.Currency(total);
        }

        private bool CheckValidation()
        {
            var strgs = new List<string>()
            {
                tBoxId.Text,
                tBoxPrice.Text,
                tBoxDesc.Text
            };
            if (!SnippetValidation.StringValidation(strgs))
            {
                SnippetMbox.MboxError(_title, "All Field must be filled");
                return false;
            }

            if (!SnippetValidation.IntValidation(tBoxPrice.Text))
            {
                SnippetMbox.MboxError(_title, "Price must be digit");
                return false;
            }

            return true;
        }

        private void ClearUI()
        {
            tBoxPrice.Clear();
            tBoxDesc.Clear();
        }

        private void TransactionServiceControl_Load(object sender, EventArgs e)
        {
            _trxId = SnippetGenerator.GenerateTransactionId();
            lTrxId.Text = "Transaction ID: " + _trxId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var valid = CheckValidation();
            if (!valid) return;

            var item = new TrxServiceViewModel()
            {
                CustomerVehicleId = tBoxId.Text,
                Description = tBoxDesc.Text,
                Price = Convert.ToInt32(tBoxPrice.Text)
            };
            _carts.Add(item);

            LoadCart();
            ClearUI();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _carts.Clear();
            LoadCart();
            ClearUI();
        }

        private void tBoxId_KeyDown(object sender, KeyEventArgs e)
        {
            if (_carts.Count != 0)
            {
                SnippetMbox.MboxWarning(_title, "You need to complete the transaction with this customer first.");
                return;
            }

            if (e.KeyCode == Keys.F3)
            {
                var sd = new ChooseCustomerVehicleForm();
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    var choosenId = sd.GetCustomerVehicleId();
                    var context = new db();
                    var dt = context.CustomerVehicles
                        .FirstOrDefault(x => x.CustomerVehicleId == choosenId);
                    _data = dt;
                    tBoxId.Text = dt.CustomerVehicleId.ToString();
                    tBoxCName.Text = dt.Customer.Name;
                    tBoxCPhone.Text = dt.Customer.Phone;
                    tBoxVName.Text = dt.Vehicle.Name;
                    tBoxVNumber.Text = dt.PoliceNumber;
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (_carts.Count == 0)
            {
                SnippetMbox.MboxError(_title, "No services have been taken by this vehicle, please provide the service first.");
                return;
            }

            try
            {
                var context = new db();
                var header = new HeaderTrx()
                {
                    CreatedAt = DateTime.Now,
                    CustomerId = _data.CustomerId,
                    Date = DateTime.Now,
                    TrxId = _trxId
                };
                context.HeaderTrxes.Add(header);
                context.SaveChanges();

                foreach (var item in _carts)
                {
                    var detail = new DetailTrx()
                    {
                        CreatedAt = DateTime.Now,
                        CustomerVehicleId = _data.CustomerVehicleId,
                        Description = item.Description,
                        Price = item.Price,
                        TrxId = _trxId,
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
            _carts.Clear();
            LoadCart();

            tBoxId.Clear();
            tBoxCName.Clear();
            tBoxCPhone.Clear();
            tBoxVName.Clear();
            tBoxVNumber.Clear();
        }
    }
}
