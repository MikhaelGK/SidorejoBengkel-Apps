using SidorejoWorkshop.Helper.Snippet;
using SidorejoWorkshop.UC.Manage;
using SidorejoWorkshop.UC.Payment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidorejoWorkshop.UC.Incoming
{
    public partial class IncomingStockControls : UserControl
    {
        private Operation _operation = Operation.None;
        private string _title = "Incoming Stock";
        private int _choosenId;

        public IncomingStockControls()
        {
            InitializeComponent();
        }

        private bool CheckValidation()
        {
            var strgs = new List<string>()
            {
                tBoxId.Text,
                tBoxQty.Text,
                tBoxPrice.Text
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

            if (!SnippetValidation.IntValidation(tBoxPrice.Text))
            {
                SnippetMbox.MboxError(_title, "Price must be digit");
                return false;
            }

            return true;
        }

        private void ClearUI()
        {
            tBoxId.Clear();
            tBoxName.Clear();
            tBoxQty.Clear();
            tBoxPrice.Clear();
        }

        private void ActiveUI(bool active)
        {
            splitContainer2.Panel1.Enabled = active;
            splitContainer2.Panel2.Enabled = !active;
        }

        private void LoadData()
        {
            var context = new db();
            var dt = context.IncomingProducts
                .Where(x => x.DeletedAt == null).ToList();
            dgv.DataSource = dt.Select(x => new
            {
                colId = x.IncomingProductId,
                colDate = x.Date.ToString("dddd, dd MMMM yyyy"),
                colPId = x.ProductId,
                colPName = x.Product.Name,
                colQty = x.Qty,
                colBPrice = SnippetCurrency.Currency(x.BuyPrice),
                colSubtotal = SnippetCurrency.Currency(x.Qty * x.BuyPrice)
            }).ToList();
        }

        private void IncomingStockControls_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _operation = Operation.Add;
            ActiveUI(true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv.CurrentRow;
            if (selectedRow is null)
            {
                SnippetMbox.MboxError(_title, "No row selected");
                return;
            }

            _choosenId = Convert.ToInt32(selectedRow.Cells[0].Value);
            var context = new db();
            var dt = context.IncomingProducts.FirstOrDefault(x => x.IncomingProductId == _choosenId);
            tBoxId.Text = dt.ProductId;
            tBoxName.Text = dt.Product.Name;
            tBoxQty.Text = dt.Qty.ToString();
            tBoxPrice.Text = dt.BuyPrice.ToString();
            _operation = Operation.Update;
            ActiveUI(true);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv.CurrentRow;
            if (selectedRow is null)
            {
                SnippetMbox.MboxError(_title, "No row selected");
                return;
            }

            var id = Convert.ToInt32(selectedRow.Cells[0].Value);
            if (SnippetMbox.MboxQuestion(_title, "Do you want to delete the data?") == DialogResult.Yes)
            {
                var context = new db();
                var dt = context.IncomingProducts
                    .FirstOrDefault(x => x.IncomingProductId == id);
                context.IncomingProducts.Remove(dt);
                context.SaveChanges();
                LoadData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var valid = CheckValidation();
            if (!valid) return;

            var context = new db();
            switch (_operation)
            {
                case Operation.None:
                    break;
                case Operation.Add:
                    var item = new IncomingProduct()
                    {
                        CreatedAt = DateTime.Now,
                        ProductId = tBoxId.Text,
                        Qty = Convert.ToInt32(tBoxQty.Text),
                        BuyPrice = Convert.ToInt32(tBoxPrice.Text),
                        Date = DateTime.Now
                    };
                    context.IncomingProducts.Add(item);
                    break;
                case Operation.Update:
                    var dt = context.IncomingProducts.FirstOrDefault(x => x.IncomingProductId == _choosenId);
                    dt.ProductId = tBoxId.Text;
                    dt.Qty = Convert.ToInt32(tBoxQty.Text);
                    dt.BuyPrice = Convert.ToInt32(tBoxPrice.Text);
                    break;
                case Operation.Delete:
                    break;
                default:
                    break;
            }

            context.SaveChanges();
            ActiveUI(false);
            ClearUI();
            _operation = Operation.None;
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ActiveUI(false);
            ClearUI();
            _operation = Operation.None;
        }

        private void tBoxId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                var sd = new ChooseProductForm();
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    var id = sd.GetProductID();
                    var context = new db();
                    var product = context.Products.FirstOrDefault(x => x.ProductId == id);
                    tBoxId.Text = product.ProductId;
                    tBoxName.Text = product.Name;
                }
            }
        }
    }
}
