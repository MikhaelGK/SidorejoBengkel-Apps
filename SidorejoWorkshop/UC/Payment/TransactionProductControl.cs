using FontAwesome.Sharp;
using SidorejoWorkshop.Helper.Snippet;
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
    public partial class TransactionProductControl : UserControl
    {
        private string _title = "Transaction Product";
        private List<TrxProductViewModel> _cart = new List<TrxProductViewModel>();

        public TransactionProductControl()
        {
            InitializeComponent();
        }

        private void ClearUI()
        {
            tBoxPId.Clear();
            tBoxPName.Clear();
            tBoxSPrice.Clear();
            tBoxQty.Clear();
            tBoxDesc.Clear();
        }

        private bool CheckValidation()
        {
            var strgs = new List<string>()
            {
                tBoxPId.Text,
                tBoxQty.Text,
            };
            if (!SnippetValidation.StringValidation(strgs))
            {
                SnippetMbox.MboxError(_title, "All field must be filled");
                return false;
            }

            if (!SnippetValidation.IntValidation(tBoxQty.Text))
            {
                SnippetMbox.MboxError(_title, "Qty must be digit");
                return false;
            }

            return true;
        }

        private void LoadData()
        {
            dgv.DataSource = _cart.Select(x => new
            {
                colPId = x.ProductID,
                colPName = x.ProductName,
                colQty = x.Qty,
                colSPrice = x.SellPrice,
                colSubs = x.Subtotal
            }).ToList();

            var total = _cart.Sum(x => x.Subtotal);
            lTotal.Text = "Total: " + total;
        }

        private bool UpdateDataInCart(TrxProductViewModel dt)
        {
            var cart = _cart.FirstOrDefault(x => x.ProductID == dt.ProductID);

            if (cart == null) return false;

            cart.Qty += dt.Qty;
            cart.Subtotal = cart.Qty * cart.SellPrice;

            return true;
        }

        private void tBoxPId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                var sd = new ChooseProductForm();
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    var id = sd.GetProductID();
                    var context = new db();
                    var product = context.Products.FirstOrDefault(x => x.ProductId == id);
                    if (product.SellPrice == null)
                    {
                        SnippetMbox.MboxInformation(_title, "The selling price of this product hasn't been provided. Please set the selling price in the Manage Menu");
                        return;
                    }

                    tBoxPId.Text = product.ProductId;
                    tBoxPName.Text = product.Name;
                    tBoxSPrice.Text = product.SellPrice.ToString();
                }
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            var valid = CheckValidation();
            if (!valid) return;

            var qty = Convert.ToInt32(tBoxQty.Text);
            var price = Convert.ToInt32(tBoxSPrice.Text);

            var item = new TrxProductViewModel()
            {
                ProductID = tBoxPId.Text,
                ProductName = tBoxPName.Text,
                Description = tBoxDesc.Text,
                Qty = qty,
                SellPrice = price,
                Subtotal = qty * price
            };

            var updated = UpdateDataInCart(item);
            if (!updated) _cart.Add(item);

            LoadData();
            ClearUI();
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv.CurrentRow;
            if (selectedRow is null)
            {
                SnippetMbox.MboxError(_title, "No row selected");
                return;
            }

            var productId = selectedRow.Cells[0].Value.ToString();
            var item = _cart.FirstOrDefault(x => x.ProductID == productId);
            _cart.Remove(item);

            LoadData();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            TrxProductConfirmViewModel.Cart = _cart;
            var sd = new HaveCustomerForm();
            sd.ShowDialog();
            sd.FormClosed += delegate
            {
                _cart.Clear();
                LoadData();
            };
        }

        private void TransactionProductControl_Load(object sender, EventArgs e)
        {
            TrxProductConfirmViewModel.TrxID = SnippetGenerator.GenerateTransactionId();

            lTrxId.Text = "Transaction ID: " + TrxProductConfirmViewModel.TrxID;
        }
    }
}
