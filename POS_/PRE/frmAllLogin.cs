using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;

namespace POS_
{
    public partial class frmAllLogin : Form
    {
        Thread th;
        Functions operation = new Functions();
        public frmAllLogin()
        {
            InitializeComponent();
        }
        public void sh() { Application.Run(new frmShiftLogin()); }
        private void shift_button_Click(object sender, EventArgs e)
        {

            try
            {
                this.Close();
                th = new Thread(sh);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
               
            }
            catch { }

          
        }
        public void lo() { Application.Run(new frmAdminLogin()); }

        private void admin_button_Click(object sender, EventArgs e)
        {

            try
            {
                this.Close();
                th = new Thread(lo);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
               
            }
            catch { }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void frmAllLogin_Load(object sender, EventArgs e)
        {
            //new frmSystemRegister().Hide();
            //new frmStart().Hide();

            
            
            
            
            dateTimePicker1.Visible = false;
        }
    }
}
