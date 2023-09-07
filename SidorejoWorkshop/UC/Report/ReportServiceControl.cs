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
    public partial class ReportServiceControl : UserControl
    {
        private DateTime _str;
        private DateTime _end;

        public ReportServiceControl()
        {
            InitializeComponent();
        }

        private void LoadHeader(string query)
        {
            var headerData = new List<ReportHeaderServiceViewModel>();

            var context = new db();
            var detailTrx = context.DetailTrxes
                .Where(x =>
                    x.CustomerVehicleId != null &&
                    x.DeletedAt == null &&
                    x.HeaderTrx.Date >= _str &&
                    x.HeaderTrx.Date <= _end).ToList();
            detailTrx = detailTrx
                .Where(x =>
                    x.HeaderTrx.Customer.Name.Contains(query) ||
                    x.HeaderTrx.CustomerId.Contains(query)).ToList();
            var trxIdList = detailTrx.Select(x => x.TrxId).Distinct();
            foreach (var item in trxIdList)
            {
                var headerTrx = context.HeaderTrxes
                    .Where(x => x.TrxId == item).FirstOrDefault();
                var detailItem = detailTrx.Where(x => x.TrxId == item);
                var sellprice = detailItem.Sum(x => x.Price);

                var headerItem = new ReportHeaderServiceViewModel()
                {
                    TrxID = headerTrx.TrxId,
                    Date = headerTrx.Date.ToString("dd MMMM yyyy"),
                    CustomerName = headerTrx.Customer.Name,
                    Price = SnippetCurrency.Currency(sellprice)
                };
                headerData.Add(headerItem);
            }
            dgvH.DataSource = headerData.Select(x => new
            {
                colTrxId = x.TrxID,
                colDate = x.Date,
                colCustomer = x.CustomerName,
                colTotal = x.Price
            }).ToList();
        }

        private void ReportServiceControl_Load(object sender, EventArgs e)
        {
            _str = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0);
            _end = _str.AddMonths(1).AddSeconds(-1);
            dtpStr.Value = _str;
            dtpEnd.Value = _end;
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

            var selectedTrxId = selectedRow.Cells[0].Value.ToString();
            var context = new db();
            var details = new List<ReportDetailServiceViewModel>();
            var data = context.DetailTrxes
                .Where(x => x.TrxId == selectedTrxId).ToList();
            foreach (var item in data)
            {
                var detail = new ReportDetailServiceViewModel()
                {
                    CustomerVehicleId = (int)item.CustomerVehicleId,
                    CustomerName = item.CustomerVehicle.Customer.Name,
                    VehicleName = item.CustomerVehicle.Vehicle.Name,
                    Description = item.Description,
                    Price = SnippetCurrency.Currency(item.Price)
                };
                details.Add(detail);
            }

            dgvD.DataSource = details.Select(x => new
            {
                colCVId = x.CustomerVehicleId,
                colCName = x.CustomerName,
                colVName = x.VehicleName,
                colDesc = x.Description,
                colPrice = x.Price
            }).ToList();
        }
    }
}
