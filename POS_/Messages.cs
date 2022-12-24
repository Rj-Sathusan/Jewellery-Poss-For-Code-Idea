using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace POS_
{
    public class Messages
    {
        public static void showInformMessages(string message)
        {
            MessageBox.Show(message, "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void showWarnMessage(string message)
        {
            MessageBox.Show(message, "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void showErrorMessage(string message)
        {
            MessageBox.Show(message, "Point of Sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool conformMessage(string message)
        {
            DialogResult results = MessageBox.Show(message, "Point of Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (results == DialogResult.Yes) { return true; }
            else { return false; }
        }
    }
}
