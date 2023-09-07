using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidorejoWorkshop.UC.Manage
{
    enum Operation { None, Add, Update, Delete }

    public partial class ManageHomeControl : UserControl
    {
        private IconButton currentButton;
        public ManageHomeControl()
        {
            InitializeComponent();
        }

        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                currentButton = sender as IconButton;
                sidePanel.Location = new Point(currentButton.Location.X, 0);
                sidePanel.Visible = true;
                sidePanel.BringToFront();
            }
        }

        private void DisactivateButton()
        {
            if (currentButton != null)
            {
                sidePanel.Visible = false;
            }
        }

        private void iBtnProduct_Click(object sender, EventArgs e)
        {
            DisactivateButton();
            ActivateButton(sender);

            contentPanel.Controls.Clear();
            var panel = new ManageProductControl();
            contentPanel.Controls.Add(panel);
        }

        private void iBtnCustomer_Click(object sender, EventArgs e)
        {
            DisactivateButton();
            ActivateButton(sender);

            contentPanel.Controls.Clear();
            var panel = new ManageCustomerControl();
            contentPanel.Controls.Add(panel);
        }

        private void iBtnVehicle_Click(object sender, EventArgs e)
        {
            DisactivateButton();
            ActivateButton(sender);

            contentPanel.Controls.Clear();
            var panel = new ManageVehicleControl();
            contentPanel.Controls.Add(panel);
        }

        private void iBtnCustomerVehicle_Click(object sender, EventArgs e)
        {
            DisactivateButton();
            ActivateButton(sender);

            contentPanel.Controls.Clear();
            var panel = new ManageCustomerVehicleControl();
            contentPanel.Controls.Add(panel);
        }

        private void ManageHomeControl_Load(object sender, EventArgs e)
        {
            var panel = new ManageProductControl();
            contentPanel.Controls.Add(panel);
        }
    }
}
