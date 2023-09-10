using SidorejoWorkshop.Helper.Snippet;
using SidorejoWorkshop.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidorejoWorkshop.UC.Payment
{
    public partial class ChooseProductForm : Form
    {
        private List<ProductViewModel> list = new List<ProductViewModel>();
        private string _choosenId;

        public ChooseProductForm()
        {
            InitializeComponent();
        }

        private void LoadProductQty()
        {
            var context = new db();
            foreach (var product in list)
            {
                var dtStored = context.IncomingProducts
                    .Where(x => x.ProductId == product.ID)
                    .ToList();
                var qtyStored = 0;
                if (dtStored.Count != 0) qtyStored = dtStored.Sum(x => x.Qty);

                var dtTaked = context.DetailTrxes
                    .Where(x => x.ProductId == product.ID)
                    .ToList();
                var qtyTaked = 0;
                if (dtTaked.Count != 0) qtyTaked = (int)dtTaked.Sum(x => x.Qty);

                product.Qty = qtyStored - qtyTaked;
            }
        }

        private void LoadData(string search)
        {
            list.Clear();
            var context = new db();
            var products = context.Products
                .Where(x =>
                    x.ProductId.Contains(search) ||
                    x.Name.Contains(search)).ToList();
            products = products.Where(x => x.DeletedAt == null).ToList();
            foreach (var product in products)
            {

                var item = new ProductViewModel()
                {
                    ID = product.ProductId,
                    Name = product.Name,
                    Description = product.Description
                };

                if (product.SellPrice is null) item.Price = "0";
                else item.Price = SnippetCurrency.Currency((int)product.SellPrice);

                list.Add(item);
            }

            LoadProductQty();

            dgv.DataSource = list.Select(x => new
            {
                colPId = x.ID,
                colName = x.Name,
                colDesc = x.Description,
                colQty = x.Qty,
                colSPrice = x.Price
            }).ToList();
        }

        private void ChooseProductForm_Load(object sender, EventArgs e)
        {
            LoadData("");
        }

        private void iBtnSelect_Click(object sender, EventArgs e)
        {
            var selectedRow = dgv.CurrentRow;
            if (selectedRow is null)
            {
                SnippetMbox.MboxError("Choose Product", "No row selected");
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

        private void iBtnSearch_Click(object sender, EventArgs e)
        {
            LoadData(tBoxSearch.Text);
        }

        public string GetProductID()
        {
            return _choosenId;
        }
    }
}
