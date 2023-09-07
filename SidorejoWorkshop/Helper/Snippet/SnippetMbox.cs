using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SidorejoWorkshop.Helper.Snippet
{
    public static class SnippetMbox
    {
        public static void MboxInformation(string title, string msg)
        {
            System.Windows.Forms.MessageBox.Show(
                msg, title,
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information
                );
        }

        public static void MboxError(string title, string msg)
        {
            System.Windows.Forms.MessageBox.Show(
                msg, title,
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error
                );
        }

        public static void MboxWarning(string title, string msg)
        {
            System.Windows.Forms.MessageBox.Show(
                msg, title,
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Warning
                );
        }

        public static System.Windows.Forms.DialogResult MboxQuestion(string title, string msg)
        {
            return System.Windows.Forms.MessageBox.Show(
                msg, title,
                System.Windows.Forms.MessageBoxButtons.YesNo,
                System.Windows.Forms.MessageBoxIcon.Question
                );
        }
    }
}
