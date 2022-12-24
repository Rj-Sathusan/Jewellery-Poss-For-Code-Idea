using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_.PRE.SALES
{
    public partial class SalesPayments : Form
    {
        //new
       private int id;
        private int customer_id;
        private double paid_amount;
        private string payment_method;
        private string discription;

        BUSS.sales_payment sales_payment;

        POS_.function_ fun = new POS_.function_();

        public SalesPayments()
        {
            InitializeComponent();
        }

        public void Clear()
        {
         
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Validation())
            //    {
            //        if (fun.ShowMessage("Are You Sure You Want To " + btn_save.Text + "  ?", "Confirm"))
            //        {

            //            this.sales_payment = new BUSS.sales_payment(id, customer_id, paid_amount, payment_method, discription);



            //            if (btn_save.Text == "Save")
            //            {
            //                this.sales_payment.Savesales_payment();
            //                Clear();
            //            }

            //            else if (btn_save.Text == "Edit")
            //            {
            //                this.sales_payment.Editsales_payment();
            //                Clear();
            //            }
            //            else { fun.validationMessge("Something Wrong!"); }
            //        }

            //    }
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (fun.ShowMessage("Are You Sure You Want To Delete  ?", DAT.MessageType.Confirm))
            //    {

            //        if (Validation())
            //        {
            //            this.sales_payment = new BUS.sales_payment(id, customer_id, paid_amount, payment_method, discription);
            //            if (this.sales_payment.Deletesales_payment())
            //            {

            //                Clear();


            //            }
            //            else
            //            {
            //                fun.validationMessge("Check your inputs !");

            //            }
            //        }
            //        else
            //        { }
            //    }
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        /*-------------------------Validation process--------------------------*/

        public bool Validation(int a)
        {

                if (string.IsNullOrEmpty(this.customer_idtxt.Text.Trim()))
                { fun.validationMessge("Please Enter customer_id"); this.customer_idtxt.Focus(); return false; }
                if (string.IsNullOrEmpty(this.paid_amounttxt.Text.Trim()))
                { fun.validationMessge("Please Enter paid_amount"); this.paid_amounttxt.Focus(); return false; }
                if (string.IsNullOrEmpty(this.payment_methodtxt.Text.Trim()))
                { fun.validationMessge("Please Enter payment_method"); this.payment_methodtxt.Focus(); return false; }
                if (string.IsNullOrEmpty(this.discriptiontxt.Text.Trim()))
                { fun.validationMessge("Please Enter discription"); this.discriptiontxt.Focus(); return false; }

                else
                {
                    if (string.IsNullOrEmpty(idtxt.Text.Trim())) { this.id = 0; }
                    else { this.id = Convert.ToInt32(this.idtxt.Text); }
                    this.customer_id = Convert.ToInt32(this.customer_idtxt.Text);
                    paid_amount = Convert.ToDouble(paid_amounttxt.Text);
                    this.payment_method = this.payment_methodtxt.Text.Trim();
                    this.discription = this.discriptiontxt.Text.Trim();
                }
            return true;
        }
    }
}
