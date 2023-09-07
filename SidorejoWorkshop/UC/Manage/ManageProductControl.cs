using SidorejoWorkshop.Helper.Snippet;
using SidorejoWorkshop.Input;
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
    public partial class ManageProductControl : UserControl
    {
        private string _title = "Manage Product Form";

        public ManageProductControl()
        {
            InitializeComponent();
        }

        private void LoadData(string search)
        {
            var list = new List<ProductViewModel>();
            var context = new db();
            var products = context.Products
                .Where(x => 
                    x.ProductId.Contains(search) && x.DeletedAt == null || 
                    x.Name.Contains(search) && x.DeletedAt == null
                )    
                .ToList();

            foreach (var product in products)
            {
                var qty = 0;
                var price = "";
                var choosenProduct = context.IncomingProducts
                    .Where(x =>
                        x.ProductId == product.ProductId &&
                        x.Qty != 0 &&
                        x.DeletedAt == null
                    )
                    .Select(x => new
                    {
                        x.Qty,
                        x.BuyPrice
                    }).ToList();
                if (choosenProduct.Count != 0)
                {
                    qty = choosenProduct.Select(x => x.Qty).Sum();
                    var listPrice = choosenProduct.Select(x => x.BuyPrice).Distinct().ToList();
                    if (listPrice.Count == 1) price = SnippetCurrency.Currency(listPrice[0]);
                    else
                    {
                        var costPrice = 0;
                        var totalQty = 0;
                        for (int i = 0; i < listPrice.Count - 1; i++)
                        {
                            var prevPrice = 0;
                            var prevQty = 0;

                            if (costPrice != 0)
                            {
                                prevPrice = costPrice;
                                prevQty = totalQty;
                            }
                            else
                            {
                                prevPrice = listPrice[i];
                                prevQty = choosenProduct
                                    .Where(x => x.BuyPrice == prevPrice)
                                    .Select(x => x.Qty).Sum();
                            }

                            var newPrice = listPrice[i + 1];
                            var newQty = choosenProduct
                                .Where(x => x.BuyPrice == newPrice)
                                .Select(x => x.Qty).Sum();

                            totalQty = prevQty + newQty;
                            costPrice = (prevPrice * prevQty + newPrice * newQty) / totalQty;
                        }
                        price = SnippetCurrency.Currency(costPrice);
                    }
                }

                var sellQty = Convert.ToInt32(
                        context.DetailTrxes
                        .Where(x =>
                            x.DeletedAt == null &&
                            x.ProductId == product.ProductId)
                        .Sum(x => x.Qty)
                    );

                var item = new ProductViewModel()
                {
                    ID = product.ProductId,
                    Name = product.Name,
                    Description = product.Description,
                    Qty = qty - sellQty,
                    CostPrice = price,
                };

                if (product.SellPrice is null) item.Price = "Not Value";
                else item.Price = SnippetCurrency.Currency((int)product.SellPrice);

                list.Add(item);
            }

            totalProductLabel.Text = "Total Product: " + products.Count;

            dgv.DataSource = list.Select(x => new
            {
                colId = x.ID,
                colName = x.Name,
                colDesc = x.Description,
                colQty = x.Qty,
                colCostPrice = x.CostPrice,
                colPrice = x.Price
            }).ToList();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void ManageProductForm_Load(object sender, EventArgs e)
        {
            LoadData("");
        }

        private void iBtnAdd_Click(object sender, EventArgs e)
        {
            var sd = new InputNewProduct(0, "");
            sd.FormClosed += delegate
            {
                LoadData("");
            };

            sd.ShowDialog();
        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv.CurrentRow;
            if (selectedRow is null)
            {
                SnippetMbox.MboxError(_title, "No Row Selected");
                return;
            }
            var selectedId = selectedRow.Cells[0].Value.ToString();

            var answer = MessageBox.Show("Do you want to delete this product?", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                var context = new db();
                var product = context.Products
                    .Include(x => x.IncomingProducts)
                    .Include(x => x.DetailTrxes)
                    .FirstOrDefault(x => x.ProductId == selectedId);

                foreach (var data in product.IncomingProducts)
                {
                    data.DeletedAt = DateTime.Now;
                }

                foreach (var data in product.DetailTrxes)
                {
                    data.DeletedAt = DateTime.Now;
                }

                product.DeletedAt = DateTime.Now;
                context.Products.Remove(product);
                context.SaveChanges();
            }
            LoadData("");
        }

        private void iBtnUpdate_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv.CurrentRow;
            if (selectedRow is null)
            {
                SnippetMbox.MboxError(_title, "No Row Selected");
                return;
            }
            var selectedId = selectedRow.Cells[0].Value.ToString();

            var sd = new InputNewProduct(1, selectedId);
            sd.FormClosed += delegate
            {
                LoadData("");
            };

            sd.ShowDialog();
        }

        private void iBtnSearch_Click(object sender, EventArgs e)
        {
            LoadData(tbSearch.Text);
        }
    }
}
