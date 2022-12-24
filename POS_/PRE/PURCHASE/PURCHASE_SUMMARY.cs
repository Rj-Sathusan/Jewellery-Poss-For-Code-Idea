using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_.PRE.PURCHASE
{
    public partial class PURCHASE_SUMMARY : Form
    {

        public int id;
        public int invoice_no;
        private double amount;
        private DateTime collection_date;
        private int pay_method;
        private string cheque_no;
        private DateTime cheque_date;
        private string bankname;
        private string note;
        private int is_cancel;
        private DateTime add_date;
        public int user_id;
        private long shift_id;
        
        BUSS.purchase_summary purchase_summary;
        DAT.NewDataAccessLayer Ndal = new DAT.NewDataAccessLayer();
        POS_.function_ fun = new POS_.function_();
        DataTable dt;


        public PURCHASE_SUMMARY()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation())
                {
                    this.Start_Process(false);
                    System.Threading.Thread.Sleep(250);
                    PRE.PURCHASE.View_purchase frm = new PRE.PURCHASE.View_purchase();
                    frm.Show();

                }
            }
            catch { }
        }

        public void Clear()
        {
            try
            {
                purchase_summary.Bindpurchase_summaryDetails(dataGridView1);
            }
            catch { }

                btn_save.Text = "Save";
                payment_methodtxt.Text = "";
                invoice_idtxt.Text = "";
       }

        public bool Validation()
        {
            
                if (string.IsNullOrEmpty(this.amounttxt.Text.Trim()))
                { fun.validationMessge("Please Enter amount"); this.amounttxt.Focus(); return false; }
                if (string.IsNullOrEmpty(this.collection_datetxt.Text.Trim()))
                { fun.validationMessge("Please Enter collection_date"); this.collection_datetxt.Focus(); return false; }
                if (string.IsNullOrEmpty(this.cheque_notxt.Text.Trim()))
                //{ fun.validationMessge("Please Enter cheque_no"); this.cheque_notxt.Focus(); return false; }
                //if (string.IsNullOrEmpty(this.cheque_datetxt.Text.Trim()))
                //{ fun.validationMessge("Please Enter cheque_date"); this.cheque_datetxt.Focus(); return false; }
                //if (string.IsNullOrEmpty(this.banktxt.Text.Trim()))
                //{ fun.validationMessge("Please Enter bank"); this.banktxt.Focus(); return false; }
                //if (string.IsNullOrEmpty(this.notetxt.Text.Trim()))
                //{ fun.validationMessge("Please Enter note"); this.notetxt.Focus(); return false; }
               

                if (string.IsNullOrEmpty(this.payment_methodtxt.Text.Trim()))
                { fun.validationMessge("Please Enter payment_method"); this.payment_methodtxt.Focus(); return false; }
                
                else
                {
                    if (string.IsNullOrEmpty(invoice_idtxt.Text.Trim())) { this.id = 0; }
                    else { this.id = Convert.ToInt32(this.invoice_idtxt.Text); }
                
                amount = Convert.ToDouble(amounttxt.Text);
                collection_date = DateTime.Parse(collection_datetxt.Text);
                this.pay_method = Convert.ToInt32(this.payment_methodtxt.SelectedValue.ToString());
                this.cheque_no = this.cheque_notxt.Text.Trim();
                cheque_date = DateTime.Parse(cheque_datetxt.Text);
                this.bankname = this.banktxt.Text.Trim();
                this.note = this.notetxt.Text.Trim();
                this.is_cancel = 0;
                add_date = DateTime.Now;
                this.shift_id = 0;

                }
            return true;
        }

        private async void Start_Process(bool is_send)
        {

            Task<bool> task = is_send ? new Task<bool>(new Func<bool>(Remove_Data)) : new Task<bool>(new Func<bool>(Send_Data));
            pb_loading.Visible = true;
            task.Start();
            if (await task)
            {
                Clear();
                pb_loading.Visible = false;
               
            }
            else
            {
                try
                { pb_loading.Visible = false; }
                catch{}
            }
        }

          private bool Remove_Data()
        {
            bool flag2;
            if (string.IsNullOrEmpty(invoice_idtxt.Text.Trim()))
            {
                Ndal.ShowMessage("Please select the data !", "Error");
                flag2 = false;
            }

            else if (!this.Ndal.ShowMessage("Are sure delete this data ?", "Confirm"))
            {
                flag2 = true;
            }
            else
            {
                id = Convert.ToInt32(invoice_idtxt.Text);
                purchase_summary = new BUSS.purchase_summary(id);
                flag2 = purchase_summary.Deletepurchase_summary();
            }
            return flag2;
        }

          private bool Send_Data()
        {
            if ((fun.ShowMessage("Are You Sure You Want To "+btn_save.Text+"  ?", "Confirm")))
            {
                
                this.purchase_summary = new BUSS.purchase_summary(id,invoice_no,amount,collection_date,pay_method,cheque_no,cheque_date,bankname,note,is_cancel,add_date,user_id,shift_id);
                        if (id == 0)
                        {
                            return purchase_summary.Savepurchase_summary();
                        }
                   
                    else 
                    {

                        return purchase_summary.Editpurchase_summary();
                    }
                }              
            return false;

        }

          private void btn_delete_Click(object sender, EventArgs e)
          {
              try
              {
                  if (Validation())
                  {
                      this.Start_Process(true);
                  }
              }
              catch { }
          }

          private void PURCHASE_SUMMARY_Load(object sender, EventArgs e)
          {
              try
              {
                  Bind_Data();
                  id = Convert.ToInt32(invoice_idtxt.Text.Trim());
                  BUSS.purchase_summary purchase = new BUSS.purchase_summary(id);
                  //purchase_summary = new BUSS.purchase_summary(id);
                  purchase.Bindpurchase_summaryDetails(dataGridView1);

                  double total = 0.0;
                  for (int i = 0; i < dataGridView1.Rows.Count; i++)
                  {
                      total = (total + double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
                     
                  }
                  label3.Text = "Due Payment : Rs. " + total;
              }
              catch { }
          }

          private void payment_methodtxt_SelectedIndexChanged(object sender, EventArgs e)
          {
              if (payment_methodtxt.Text == "Cheque")
              {
                  cheque_datetxt.Enabled = true;
                  cheque_notxt.Enabled = true;
                  banktxt.Enabled = true;
              }
              else
              {
                  cheque_datetxt.Enabled = false;
                  cheque_notxt.Enabled = false;
                  banktxt.Enabled = false; notetxt.Focus();
              }
          }

          private void notetxt_TextChanged(object sender, EventArgs e)
          {
            
          }

          private void Bind_Data()
          {
              try
              {
                  this.payment_methodtxt.DataSource = new BUSS.purchase_summary().purchasebinfcombo();
                  this.payment_methodtxt.ValueMember = "id";
                  this.payment_methodtxt.DisplayMember = "name";

              }
              catch
              {

              }
          }

          private void idtxt_TextChanged(object sender, EventArgs e)
          {

          }
        

    }
}
