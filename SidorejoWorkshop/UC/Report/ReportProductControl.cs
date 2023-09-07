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

namespace SidorejoWorkshop.UC.Report
{
    public partial class ReportProductControl : UserControl
    {
        private DateTime _str;
        private DateTime _end;

        public ReportProductControl()
        {
            InitializeComponent();
        }
        private void LoadMonth(int monthId)
        {
            var date = DateTime.Now;
            _str = new DateTime(date.Year, monthId, 1);
            _end = _str.AddMonths(1).AddSeconds(-1);

        }

        private void LoadHeader(string query)
        {
            var headerData = new List<ReportHeaderProductViewModel>();

            var context = new db();
            var detailTrx = context.DetailTrxes
                .Where(x =>
                    x.ProductId != null &&
                    x.DeletedAt == null &&
                    x.HeaderTrx.Date >= _str &&
                    x.HeaderTrx.Date <= _end && 
                    x.ProductId.Contains(query)).ToList();
            var trxIdList = detailTrx.Select(x => x.TrxId).Distinct();
            foreach (var item in trxIdList)
            {
                var headerTrx = context.HeaderTrxes
                    .Where(x => x.TrxId == item).FirstOrDefault();                
                var total = 0;
                foreach (var detailItem in 
                    detailTrx.Where(x => x.TrxId == item))
                {
                    total += (int)detailItem.Qty * detailItem.Price;
                }

                var headerItem = new ReportHeaderProductViewModel()
                {
                    TrxID = headerTrx.TrxId,
                    Date = headerTrx.Date.ToString("dd MMMM yyyy"),
                    SellPrice = SnippetCurrency.Currency(total)
                };
                headerData.Add(headerItem);
            }
            dgvH.DataSource = headerData.Select(x => new
            {
                colTrxId = x.TrxID,
                colDate = x.Date,
                colTotal = x.SellPrice
            }).ToList();
        }
        
        private void ReportProductControl_Load(object sender, EventArgs e)
        {
            _str = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0);
            _end = _str.AddMonths(1).AddSeconds(-1);
            LoadHeader("");
        }

        private void iBtnDtp_Click(object sender, EventArgs e)
        {
            var sd = new PickerDate();
            if (sd.ShowDialog() == DialogResult.OK)
            {
                _str = sd.GetStartDate();
                _end = sd.GetEndDate();
                dtpStr.Value = _str;
                dtpEnd.Value = _end;
                LoadHeader("");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadHeader(tBoxSearch.Text);
        }

        private void dgvH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgvH.CurrentRow;
            if (selectedRow == null) return;

            var selectedTrxId = selectedRow.Cells[0].Value;
            var details = new List<ReportDetailProductViewModel>();
            var context = new db();
            var data = context.DetailTrxes
                .Where(x => x.TrxId == selectedTrxId).ToList();
            foreach (var item in data)
            {
                var qty = (int)item.Qty;
                var price = item.Price;
                var detail = new ReportDetailProductViewModel()
                {
                    ProductID = item.ProductId,
                    ProductName = item.Product.Name,
                    Qty = qty,
                    Price = SnippetCurrency.Currency(price),
                    Total = SnippetCurrency.Currency(qty * price)
                };
                details.Add(detail);
            }

            dgvD.DataSource = details.Select(x => new
            {
                colPId = x.ProductID,
                colPName = x.ProductName,
                colQty = x.Qty,
                colPrice = x.Price,
                colSubtotal = x.Total
            }).ToList();
        }
    }
}
