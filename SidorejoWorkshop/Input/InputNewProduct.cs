using SidorejoWorkshop.Helper.Snippet;
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

namespace SidorejoWorkshop.Input
{
    public partial class InputNewProduct : Form
    {
        private string _title = "Input New Product";
        private readonly int _operationId;
        private readonly string _productId;

        public InputNewProduct(int operationId, string productId)
        {
            InitializeComponent();
            _operationId = operationId;
            _productId = productId;
        }

        private void AddNewData()
        {
            var context = new db();
            var item = new Product()
            {
                CreatedAt = DateTime.Now,
                ProductId = tBoxID.Text,
                Name = tBoxName.Text,
                Description = tBoxDesc.Text,
            };

            if (!String.IsNullOrEmpty(tBoxPrice.Text))
            {
                item.SellPrice = Convert.ToInt32(tBoxPrice.Text);
            }

            context.Products.Add(item);
            context.SaveChanges();
            Close();
        }
        
        private void UpdateData()
        {
            var context = new db();
            var product = context.Products.FirstOrDefault(x => x.ProductId == _productId);
            product.Name = tBoxName.Text;
            product.Description = tBoxDesc.Text;
            if (!String.IsNullOrEmpty(tBoxPrice.Text))
            {
                product.SellPrice = Convert.ToInt32(tBoxPrice.Text);
            }
            product.UpdatedAt = DateTime.Now;
            context.SaveChanges();
        }

        private bool CheckValidation()
        {
            var strgs = new List<string>()
            {
                tBoxName.Text,
                tBoxDesc.Text
            };
            if (SnippetValidation.StringValidation(strgs) == false )
            {
                SnippetMbox.MboxError(_title, "Name product must be filled");
                return false;
            }

            if (!String.IsNullOrEmpty(tBoxPrice.Text))
            {
                try
                {
                    var price = Convert.ToInt32(tBoxPrice.Text);
                }
                catch
                {
                    SnippetMbox.MboxError(_title, "Price value must be digit");
                    return false;
                }
            }

            return true;
        }

        private void iBtnSave_Click(object sender, EventArgs e)
        {
            var valid = CheckValidation();
            if (!valid) return;

            if (_operationId == 0) AddNewData();
            else UpdateData();

            Close();
        }

        private void iBtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InputNewProduct_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_productId))
            {
                tBoxID.Text = SnippetGenerator.GenerateProductId();
            } 
            else
            {
                var context = new db();
                var product = context.Products.FirstOrDefault(x => x.ProductId == _productId);
                tBoxID.Text = product.ProductId;
                tBoxName.Text = product.Name;
                tBoxDesc.Text = product.Description;
                tBoxPrice.Text = product.SellPrice.ToString();
            }
        }
    }
}
