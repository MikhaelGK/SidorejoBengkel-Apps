using SidorejoWorkshop.Helper.Snippet;
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
    public partial class LoginForm : Form
    {
        string title = "Login Form";

        public LoginForm()
        {
            InitializeComponent();
        }

        private bool CheckValidatoin()
        {
            var strgs = new List<string>()
            {
                tbName.Text,
                tbPwd.Text
            };
            var validString = SnippetValidation.StringValidation(strgs);
            if (!validString)
            {
                SnippetMbox.MboxError(title, "All field must be fill");
                return true;
            }

            return false;
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var valid = CheckValidatoin();
            if (valid) return;

            var context = new db();
            //var admin = context.Admins.FirstOrDefault(x => x.Username == tbName.Text && x.Password == tbPwd.Text);
            var admin = context.Admins.Select(x => new { x.Username, x.Password }).FirstOrDefault();
            if (admin.Username != tbName.Text || admin.Password != tbPwd.Text)
            {
                SnippetMbox.MboxError(title, "User Not Found");
                tbName.Clear();
                tbPwd.Clear();
                return;
            }

            var mainForm = new MainForm();
            mainForm.FormClosed += delegate
            {
                Show();
            };

            Hide();
            mainForm.Show();
        }
    }
}
