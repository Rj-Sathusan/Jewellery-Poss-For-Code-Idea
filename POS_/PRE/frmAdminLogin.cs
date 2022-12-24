using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace POS_
{
    public partial class frmAdminLogin : Form
    {
       // BUS.User user = new BUS.User();
        string username = "";
        function_ fun = new function_(); string currentdate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Functions operation = new Functions();
        Thread th; DataTable dt; int functionsuccess = 0;
        string usid = "",shiftid="",sql="";
        //function fun = new function();
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void shift_button_Click(object sender, EventArgs e)
        {
           
        }

        private void frmAdminLogin_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
        }


        public static string GetMACAddress2()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    //IPInterfaceProperties properties = adapter.GetIPProperties(); Line is not required
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            } return sMacAddress;
        }
        void login()
        {/*
            try
            {
                
                if (textuser.Text == "") { fun.validationMessge("Please Enter Username"); }
                else if (textpass.Text == "") { fun.validationMessge("Please Enter Password"); }
                else
                {
                    user._username = this.textuser.Text.Trim();
                    user._password = this.textpass.Text.Trim();
                    user.cond = 0;
                    dt = user.GetUserNameAndPassword();
                    // sql = @"select * from users where username='" + textuser.Text.Trim() + "' And password='" + textpass.Text.Trim() + "'";
                    if (dt.Rows.Count == 1)
                    {

                        if (Convert.ToInt32(dt.Rows[0].ItemArray[2].ToString()) == 0) { } else { fun.validationMessge("You can't login because of user type is different !!!!!!!!!"); return; }
                        user._userid = Convert.ToInt32(dt.Rows[0].ItemArray[4].ToString());
                        user._branchid = Convert.ToInt32(labranchid.Text);
                        user._cashierid = Convert.ToInt32(lacashirid.Text);
                        user._invoiceid = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
                        username = dt.Rows[0].ItemArray[0].ToString();
                        user._predate = DateTime.Now.AddDays(-1);
                        user._predate11 = DateTime.Now;
                      
                        user.cond = 0; user.opbalance = 0;
                        user.LoginSave();

                        
                            
                        shiftid =  user._loginid.ToString(); dt = null;

                        string sql = "select * from shop";
                        dt = fun.dataTable(sql);
                        BUS.Global.shopname = dt.Rows[0].ItemArray[1].ToString();
                        BUS.Global.address = dt.Rows[0].ItemArray[2].ToString();
                        BUS.Global.mobile = dt.Rows[0].ItemArray[3].ToString();
                        BUS.Global.land = dt.Rows[0].ItemArray[4].ToString();
                        BUS.Global.email = dt.Rows[0].ItemArray[5].ToString();
                        BUS.Global.web = dt.Rows[0].ItemArray[6].ToString();
                        BUS.Global.greting = dt.Rows[0].ItemArray[7].ToString();
                        dt = null;


                        //Thread.Sleep(10);
                        functionsuccess = 1;

                    }
                    else { fun.validationMessge("Please Enter Currect Username AND Password"); }

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        */
        }

        private void admin_login_button_Click(object sender, EventArgs e)
        {
            //using (REP.frmWaitForm frm = new REP.frmWaitForm(login))
            //{
            //    frm.ShowDialog(this);
            
            //}
            login();
            /*
            if (functionsuccess == 1)
            {
                this.Hide();
                new PRE.frmNewDashBord(user._branchid, username, shiftid).ShowDialog();

            }
            else { //fun.validationMessge("Please Enter Currect Username AND Password"); 
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Text);
            MessageBox.Show(operation.dateId(dateTimePicker1.Text));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textpass.Focus();
            }
        }

        private void textpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                admin_login_button.Focus();
            }
        }
        

        }
    
}
