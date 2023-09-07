using SidorejoWorkshop.Helper.Snippet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidorejoWorkshop.UC.Report
{
    public partial class PickerDate : Form
    {
        private DateTime _str;
        private DateTime _end;

        public PickerDate()
        {
            InitializeComponent();
        }

        private void nudYear_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            var choosenYear = Convert.ToInt32(nudYear.Value);

            if (rBtnYes.Checked)
            {
                var choosenMonth = cBoxMonth.SelectedIndex + 1;
                _str = new DateTime(choosenYear, choosenMonth, 1, 0, 0, 0);
                _end = _str.AddMonths(1).AddSeconds(-1);
            }
            else
            {
                _str = new DateTime(choosenYear, 1, 1, 0, 0, 0);
                _end = _str.AddYears(1).AddSeconds(-1);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void rBtnYes_CheckedChanged(object sender, EventArgs e)
        {
            gBoxMonth.Enabled = true;
        }

        private void rBtnNo_CheckedChanged(object sender, EventArgs e)
        {
            gBoxMonth.Enabled = false;
        }

        public DateTime GetStartDate()
        {
            return _str;
        }

        public DateTime GetEndDate()
        {
            return _end;
        }

        private void iBtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PickerDate_Load(object sender, EventArgs e)
        {
            cBoxMonth.SelectedIndex = 0;
        }
    }
}
