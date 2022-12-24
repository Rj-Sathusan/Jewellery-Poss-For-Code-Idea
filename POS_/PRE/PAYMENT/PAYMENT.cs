using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS_.PRE.PAYMENT
{
    public partial class PAYMENT : Form
    {
        private int id;
        private string payment_method;
        private DateTime date;


        BUSS.payment payment;
        DAT.NewDataAccessLayer Ndal = new DAT.NewDataAccessLayer();
        POS_.function_ fun = new POS_.function_();

        public PAYMENT()
        {

            InitializeComponent();


        }


        private void PAYMENT_Load(object sender, EventArgs e)
        {
            try
            {
                payment = new BUSS.payment();
                payment.BindPaymentDetails(dataGridView1);
            }
            catch { }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            try
            {
                payment.BindPaymentDetails(dataGridView1);
            }
            catch { }

            btn_save.Text = "Save";
            payment_methodtxt.Text = "";
            idtxt.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Validation())
            { this.Start_Process(false); }
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Start_Process(true);
        }

        /*-------------------------Validation process--------------------------*/

        public bool Validation()
        {

            try
            {
                if (string.IsNullOrEmpty(this.payment_methodtxt.Text.Trim()))
                { fun.validationMessge("Please Enter payment_method"); this.payment_methodtxt.Focus(); return false; }

                else
                {
                    if (string.IsNullOrEmpty(idtxt.Text.Trim())) { this.id = 0; }
                    else { this.id = Convert.ToInt32(this.idtxt.Text); }

                    this.payment_method = this.payment_methodtxt.Text.Trim();
                    date = DateTime.Now;
                }
            }
            catch { }
            return true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.idtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.payment_methodtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                btn_save.Text = "Edit";
                payment_methodtxt.Focus();

                if (dataGridView1.SelectedRows.Count >= 1)
                {
                    dataGridView1.SelectedRows[0].Selected = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
            if (string.IsNullOrEmpty(idtxt.Text.Trim()))
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
                id = Convert.ToInt32(idtxt.Text);
                payment = new BUSS.payment(id);
                flag2 = payment.Deletepayment();
            }
            return flag2;
        }

        private bool Send_Data()
        {
            if ((fun.ShowMessage("Are You Sure You Want To "+btn_save.Text+"  ?", "Confirm")))
            {
                 this.payment = new BUSS.payment(id, payment_method, date);

                        if (id == 0)
                        {
                            return payment.Savepayment();
                        }
                   
                    else 
                    {

                        return payment.Editpayment();
                    }
                }              
            return false;

        }

        private void pb_loading_Click(object sender, EventArgs e)
        {

        }

    }
}
