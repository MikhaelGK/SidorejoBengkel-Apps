using FontAwesome.Sharp;
using SidorejoWorkshop.UC.Incoming;
using SidorejoWorkshop.UC.Manage;
using SidorejoWorkshop.UC.Payment;
using SidorejoWorkshop.UC.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidorejoWorkshop
{
    public partial class MainForm : Form
    {
        private IconButton currentButton;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                currentButton = (IconButton)sender;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;

                sidePanel.Location = new Point(0, currentButton.Location.Y);
                sidePanel.Visible = true;
                sidePanel.BringToFront();
            }
        }

        private void DisactivateButton()
        {
            if (currentButton != null)
            {
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;

                sidePanel.Visible = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm");
        }

        private void iBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iBtnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            sidePanel.Visible = false;
        }

        private void iBtnManage_Click(object sender, EventArgs e)
        {
            DisactivateButton();
            ActivateButton(sender);

            contentPanel.Controls.Clear();
            var panel = new ManageHomeControl();
            contentPanel.Controls.Add(panel);
        }


        private void iBtnTransaction_Click(object sender, EventArgs e)
        {
            DisactivateButton();
            ActivateButton(sender);

            contentPanel.Controls.Clear();
            var panel = new TransactionHomeControl();
            contentPanel.Controls.Add(panel);
        }

        private void iBtnReport_Click(object sender, EventArgs e)
        {
            DisactivateButton();
            ActivateButton(sender);

            contentPanel.Controls.Clear();
            var panel = new ReportHomeControl();
            contentPanel.Controls.Add(panel);
        }

        private void iBtnStock_Click(object sender, EventArgs e)
        {
            DisactivateButton();
            ActivateButton(sender);

            contentPanel.Controls.Clear();
            var panel = new IncomingStockControls();
            contentPanel.Controls.Add(panel);
        }
    }
}
