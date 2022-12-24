using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS_.PRE
{
    public partial class frmNewDashBordold : Form
    {
        Int32 first = 0, count = 0, tim = 0; string sql = ""; function_ fun = new function_();
        DataTable dt; 
        public frmNewDashBordold(int branchid, string username, string shiftid)
        {
            InitializeComponent();
          //  menuStrip1.Visible = false;
            toolStripLabel4.Text = branchid.ToString();
            toolStripLabel3.Text = username;
            toolStripLabel2.Text = shiftid;

            //try
            //{
            //    sql = "SELECT mm.des FROM sub_menu sm INNER JOIN main_menu mm ON sm.mainmenu_id=mm.id INNER JOIN form_id fi ON sm.form_id=fi.id INNER JOIN user_rool ur ON ur.submenu_id=sm.id WHERE fi.iscanceld=" + 0 + " and mm.manutype="+1+" AND ur.userid=(SELECT userid FROM login_details WHERE shiftid= " + shiftid + " ) ";

            //    foreach (ToolStripMenuItem item in menuStrip1.Items)
            //        item.Visible = false;


            //    reportToolStripMenuItem.Visible = true; routToolStripMenuItem.Visible = true;
            //    sg1(menuStrip1, sql);

            //    foreach (ToolStripMenuItem subitem in reportToolStripMenuItem.DropDownItems)
            //    {
                  
            //            subitem.Visible = false;
                    
            //    }
               

            //}
            //catch { }
        }
       
        public frmNewDashBordold()
        {
            InitializeComponent();
            toolStripLabel2.Text = "1"; toolStripLabel4.Text = "1";
        }



        public void formshow(Form frm)
        {
            try
            {
                frm.MdiParent = this;
                frm.Show();
                splitContainer1.Panel1.Controls.Add(frm);
                frm.BringToFront();

            }
            catch { }
        }
        private void frmNewDashBord_Load(object sender, EventArgs e)
        {
            try
            {
              
                timer1.Start(); button1.Visible = false;
                timer2.Stop();
                //staffToolStripMenuItem1.Enabled = false;
                //shareholdersToolStripMenuItem.Enabled = false;
                //profitCalToolStripMenuItem.Enabled = false; dayBalanceSheetToolStripMenuItem.Enabled = false;
                // itemRegisterForOtherBranchToolStripMenuItem.Enabled = false;
            }
            catch { }
        }
      
  

 

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //sql = "SELECT (SELECT FORMAT(IFNULL(SUM(amount),0),2) FROM cashdeposit  WHERE  iscancel=" + 0 + " )," +

                //"+(SELECT FORMAT(IFNULL(SUM(amount),0),2) FROM cashwithdraw  WHERE  iscancel=" + 0 + " )," +
                //"+(SELECT FORMAT(IFNULL(SUM(cheque_payments.amount),0),2) FROM oldbill_paymet INNER JOIN cheque_payments ON oldbill_paymet.oldid=cheque_payments.oldbillpaidid   WHERE cheque_payments.destatus =" + 0 + "  AND cheque_payments.statusid =" + 3 + " AND cheque_payments.duedate <= '" + DateTime.Now.AddDays(-2).ToString("yyyy-MM-dd 23:59:59") + "' AND cheque_payments.statusdate <= '" + DateTime.Now.AddDays(-2).ToString("yyyy-MM-dd 23:59:59") + "')";
                //"+(SELECT FORMAT(IFNULL(SUM(amount),0),2) FROM orderpay   WHERE destatus =" + 0 + "  AND paymenttype =" + 2 + " AND restatus="+0+" AND chequedate <= '" + DateTime.Now.AddDays(-2).ToString("yyyy-MM-dd ") + "' AND cheque_payments.statusdate <= '" + DateTime.Now.AddDays(-2).ToString("yyyy-MM-dd 23:59:59") + "')";


                sql = "ALTER TABLE invoice MODIFY COLUMN invoiceno BIGINT AUTO_INCREMENT";
                fun.DataHandel(sql);
                sql = "ALTER TABLE invoice AUTO_INCREMENT = " + 100 + "";
                fun.DataHandel(sql);
               // dt = fun.dataTable(sql);
            }
            catch { }
        }

    

      

        public void sg(ToolStripMenuItem des)
        {
            try
            {

                sql = "SELECT sm.description FROM sub_menu sm INNER JOIN main_menu mm ON sm.mainmenu_id=mm.id INNER JOIN form_id fi ON sm.form_id=fi.id INNER JOIN user_rool ur ON ur.submenu_id=sm.id WHERE mm.des='"+des.Name.ToString()+"' and fi.iscanceld=0 AND ur.userid=(SELECT userid FROM login_details WHERE shiftid= " + toolStripLabel2.Text + " ) ";
                dt = fun.dataTable(sql);
                for (int b = 0; dt.Rows.Count > b; b++)
                {
                    //dt.Rows[b].ItemArray[0].ToString().Trim().
                    foreach (ToolStripMenuItem subitem in des.DropDownItems)
                    {
                        if (subitem.Name.Trim() == dt.Rows[b].ItemArray[0].ToString().Trim())
                        {
                            subitem.Visible = true;
                        }
                    }

                }
                des.ShowDropDown();
                des.Visible = true; des.ShowDropDown();
               // menuStrip1.Refresh();
                sql = null; dt = null;
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listOfRoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!BUSS.FormOpenClass.LisfOfRootOpened)
            {
                PRE.Customer.frmRoutAdd frm = new PRE.Customer.frmRoutAdd(toolStripLabel2.Text, toolStripLabel3.Text);
                formshow(frm);
                
                //frm.MdiParent = this;
                //frm.WindowState = FormWindowState.Maximized;
                //frm.Show();
                //frm.BringToFront();
                


            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PRE.Customer.frmListofRoute frm = new PRE.Customer.frmListofRoute();
            //formshow(frm);
        }


       
      
    }
}
