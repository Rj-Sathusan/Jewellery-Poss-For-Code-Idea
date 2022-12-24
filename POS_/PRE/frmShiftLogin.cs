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
    public partial class frmShiftLogin : Form
    {
        string username = ""; int functionsuccess = 0;
        function_ fun = new function_(); string currentdate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Functions operation = new Functions(); //BUS.User user = new BUS.User();
        Thread th;
        string usid = "", shiftid = "", sql = ""; DataTable dt,dt1;
        public frmShiftLogin()
        {
            InitializeComponent();

        }

        private void frmShiftLogin_Load(object sender, EventArgs e)
        {
            string current_date_text = dateTimePicker1.Text;
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
        {
            /*
            try
            {
             
                if (textuser.Text == "") { fun.validationMessge("Please Enter Username"); }
                else if (textpass.Text == "") { fun.validationMessge("Please Enter Password"); }
                else
                {
                    user._username = this.textuser.Text.Trim();
                    user._password = this.textpass.Text.Trim();
                    user.cond = 1;
                    dt = user.GetUserNameAndPassword();
                    // sql = @"select * from users where username='" + textuser.Text.Trim() + "' And password='" + textpass.Text.Trim() + "'";
                    if (dt.Rows.Count == 1)
                    {

                        //    if (Convert.ToInt32(dt.Rows[0].ItemArray[2].ToString()) == 1) { } else { fun.validationMessge("You can't login because of user type is different !!!!!!!!!"); return; }
                        user._userid = Convert.ToInt32(dt.Rows[0].ItemArray[4].ToString());
                        user._branchid = Convert.ToInt32(labranchid.Text);
                        user._cashierid = Convert.ToInt32(lacashirid.Text);
                        user._invoiceid = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
                        username = dt.Rows[0].ItemArray[0].ToString();
                        user._predate = DateTime.Now.AddDays(-1);
                        user._predate11 = DateTime.Now;
                        user.cond = 1;

                        string sql1 = "SELECT count(shiftid) FROM login_details WHERE userid=" + user._userid + " AND logintype=" + user.cond + " AND cashierid=" + user._cashierid + " AND DATE_FORMAT(date,'%Y-%m-%d') ='" + user._predate11.ToString("yyyy-MM-dd") + "'";
                        dt1 = fun.dataTable(sql1);

                        if (Convert.ToInt32(dt1.Rows[0].ItemArray[0].ToString()) >0)
                        { }
                        else {
                            if (string.IsNullOrEmpty(txtopeningbalance.Text.Trim()))
                            { fun.validationMessge("Please Enter Opening Balance !!!!!!!"); txtopeningbalance.Focus(); return; }
                            
                        
                        }

                        if (string.IsNullOrEmpty(txtopeningbalance.Text.Trim())) { user.opbalance = 0; } else { user.opbalance = Convert.ToDouble(txtopeningbalance.Text); }

                        user.LoginSave();
                        shiftid = user._loginid.ToString(); dt = null; dt1 = null; sql1 = null;
                      
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

                        sql = @"SELECT 
                               (SELECT des FROM t_ca ORDER BY id ASC LIMIT 1),
                               (SELECT des FROM t_la  ORDER BY id ASC LIMIT 1),
                               (SELECT des FROM t_pm  ORDER BY id ASC LIMIT 1),
                               (SELECT des FROM t_sm  ORDER BY id ASC LIMIT 1),
                               (SELECT des FROM t_id  ORDER BY id ASC LIMIT 1),
                              ifnull( (SELECT com  FROM pole where cheirid=" + lacashirid.Text + "),0), (SELECT des FROM poledes ) ";

                        dt = fun.dataTable(sql);
                       
                        BUS.Global.commisionactive = dt.Rows[0].ItemArray[0].ToString();
                        BUS.Global.loyaltiactive = dt.Rows[0].ItemArray[1].ToString();
                        BUS.Global.printmasage = dt.Rows[0].ItemArray[2].ToString();
                        BUS.Global.savemasage = dt.Rows[0].ItemArray[3].ToString();
                        BUS.Global.invoicediscount = dt.Rows[0].ItemArray[4].ToString();
                        BUS.Global.polecom = dt.Rows[0].ItemArray[5].ToString();
                        BUS.Global.poledescription = dt.Rows[0].ItemArray[6].ToString();

                        dt = null;

                        

                        functionsuccess = 1;
                    }
                    else { fun.validationMessge("Please Enter Currect Username AND Password"); }

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }*/
        }
        private void shift_login_button_Click(object sender, EventArgs e)
        {
           

            login();

            //using (REP.frmWaitForm frm = new REP.frmWaitForm(load))
            //{
            //    frm.ShowDialog(this);

            //}
            /*
            if (functionsuccess == 1)
            {


                this.Hide();
                new Form1(user._branchid, user._cashierid, shiftid, username,user._userid).ShowDialog();

            }
            else
            { //fun.validationMessge("Please Enter Currect Username AND Password"); 
            }
          */
        }
        public void load()
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
                txtopeningbalance.Focus();

            }
        }

        private void txtopeningbalance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                shift_login_button.Focus();

            }
        }

        private void txtopeningbalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.checkString(e, txtopeningbalance);
        }

       

        }
}
