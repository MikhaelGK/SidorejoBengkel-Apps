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

namespace SidorejoWorkshop.UC.Payment
{
    public partial class TransactionHomeControl : UserControl
    {
        private IconButton currentButton;

        public TransactionHomeControl()
        {
            InitializeComponent();
        }

        private void ActiveButton(object sender)
        {
            if (sender != null)
            {
                currentButton = (IconButton)sender;
                sidePanel.Location = new Point(currentButton.Location.X, 0);
                sidePanel.Visible = true;
                sidePanel.BringToFront();
            }
        }

        private void DisactiveButton()
        {
            if (currentButton != null)
            {
                sidePanel.Visible = false;
            }
        }

        private void iBtnProduct_Click(object sender, EventArgs e)
        {
            DisactiveButton();
            ActiveButton(sender);

            contentPanel.Controls.Clear();
            var panel = new TransactionProductControl();
            contentPanel.Controls.Add(panel);
        }

        private void TransactionHomeControl_Load(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            var panel = new TransactionProductControl();
            contentPanel.Controls.Add(panel);
        }

        private void iBtnService_Click(object sender, EventArgs e)
        {
            DisactiveButton();
            ActiveButton(sender);

            contentPanel.Controls.Clear();
            var panel = new TransactionServiceControl();
            contentPanel.Controls.Add(panel);
        }
    }
}
