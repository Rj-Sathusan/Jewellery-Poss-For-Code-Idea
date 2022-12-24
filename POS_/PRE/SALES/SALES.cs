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


namespace POS_.PRE.SALES
{
    public partial class SALES : Form
    {
      
        private int id;
        private DateTime invoice_date;
        private int customer;
        private string invoice_no;
        private string invoice_type;

        BUSS.sales sales;

        POS_.function_ fun = new POS_.function_();

        public SALES()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            try
            {
                sales = new BUSS.sales();
                sales.BindsalesDetails(dataGridView1);

                idtxt.Text = "";
                invoice_datetxt.Text = "";
                invoice_notxt.Text = "";
                invoice_typetxt.Text = "";
                customertxt.Text = "";
                btn_save.Text = "Save";
            }
            catch { }   
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            try
            {
                this.Start_Process(false);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        /*-------------------------Validation process--------------------------*/

        public bool Validation()
        {

                if (string.IsNullOrEmpty(this.invoice_datetxt.Text.Trim()))
                { fun.validationMessge("Please Enter invoice_date"); this.invoice_datetxt.Focus(); return false; }
                if (string.IsNullOrEmpty(this.customertxt.Text.Trim()))
                { fun.validationMessge("Please Enter customer"); this.customertxt.Focus(); return false; }
                if (string.IsNullOrEmpty(this.invoice_notxt.Text.Trim()))
                { fun.validationMessge("Please Enter invoice_no"); this.invoice_notxt.Focus(); return false; }
                if (string.IsNullOrEmpty(this.invoice_typetxt.Text.Trim()))
                { fun.validationMessge("Please Enter invoice_type"); this.invoice_typetxt.Focus(); return false; }

                else
                {
                    if (string.IsNullOrEmpty(idtxt.Text.Trim())) { this.id = 0; }
                    else { this.id = Convert.ToInt32(this.idtxt.Text); }

                    invoice_date = DateTime.Parse(invoice_datetxt.Text);
                    this.customer = Convert.ToInt32(this.customertxt.Text);
                    this.invoice_no = this.invoice_notxt.Text.Trim();
                    this.invoice_type = this.invoice_typetxt.Text.Trim();
                }
            return true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                this.Start_Process(true);
     
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SALES_Load(object sender, EventArgs e)
        {
            try
            {
                sales = new BUSS.sales();
                sales.BindsalesDetails(dataGridView1);
            }
            catch { }
  
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
                catch { }
            }
        }

        private bool Remove_Data()
        {
            bool flag2;
            if (string.IsNullOrEmpty(idtxt.Text.Trim()))
            {
                fun.ShowMessage("Please select the data !", "Error");
                flag2 = false;
            }

            else if (!this.fun.ShowMessage("Are sure delete this data ?", "Confirm"))
            {
                flag2 = true;
            }
            else
            {
                id = Convert.ToInt32(idtxt.Text);
                sales = new BUSS.sales(id);
                flag2 = sales.Deletesales();
            }
            return flag2;
        }

        private bool Send_Data()
        {
            if ((fun.ShowMessage("Are You Sure You Want To " + btn_save.Text + "  ?", "Confirm")))
            {
                if (Validation())
                {
                    this.sales = new BUSS.sales(id, invoice_date, customer, invoice_no, invoice_type);

                    if (id == 0)
                    {
                        return sales.Savesales();
                    }

                    else
                    {

                        return sales.Editsales();
                    }
                }
            }
            return false;

        }
    }
}
