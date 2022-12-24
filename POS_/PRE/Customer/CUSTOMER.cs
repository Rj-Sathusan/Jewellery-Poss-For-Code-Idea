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

namespace POS_.PRE.Customer
{
    public partial class CUSTOMER : Form
    {
        private int id;
        private string name;
        private string adress;
        private string phone_no;
        private string phone_no2;
        private int route_id;
        private long shift_id;

        BUSS.customer customer;
        DAT.NewDataAccessLayer Ndal = new DAT.NewDataAccessLayer();
        POS_.function_ fun = new POS_.function_();

        public CUSTOMER()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Validation())
            { this.Start_Process(false); }
        }

        private void CUSTOMER_Load(object sender, EventArgs e)
        {
            try
            {
                //Customer = BUSS.customer();
                //c
            }
            catch { }
        }

        public void Clear()
        {
            try
            {
                customer.BindcustomerDetails(dataGridView1);
            }
            catch { }

            btn_save.Text = "Save";
            idtxt.Text = "";
            nametxt.Text="";
            adresstxt.Text="";
            phone_no2txt.Text="";
            phone_notxt.Text="";
            route_idtxt.Text="";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Start_Process(true);
        }

        /*-------------------------Validation process--------------------------*/

        public bool Validation()
        {


            if (string.IsNullOrEmpty(this.nametxt.Text.Trim()))
            { fun.validationMessge("Please Enter name"); this.nametxt.Focus(); return false; }

            if (string.IsNullOrEmpty(this.route_idtxt.Text.Trim()))
            { fun.validationMessge("Please Enter name"); this.route_idtxt.Focus(); return false; }

            else
            {
                if (string.IsNullOrEmpty(idtxt.Text.Trim())) { this.id = 0; }
                else { this.id = Convert.ToInt32(this.idtxt.Text); }

                this.name = this.nametxt.Text.Trim();
                this.adress = this.adresstxt.Text.Trim();
                this.phone_no = this.phone_notxt.Text.Trim();
                this.phone_no2 = this.phone_no2txt.Text.Trim();
                this.route_id = Convert.ToInt32(this.route_idtxt.Text);
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
                catch { }
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
                customer = new BUSS.customer(id);
                flag2 = customer.Deletecustomer();
            }
            return flag2;
        }

         private bool Send_Data()
        {
            if ((fun.ShowMessage("Are You Sure You Want To "+btn_save.Text+"  ?", "Confirm")))
            {
                
                    this.customer = new BUSS.customer(id,name,adress,phone_no,phone_no2,route_id,shift_id);

                        if (id == 0)
                        {
                            return customer.Savecustomer();
                        }
                   
                    else 
                    {

                        return customer.Editcustomer();
                    }
                }              
            return false;

        }

         private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
         {

         }

         private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
         {
             try
             {
                 this.idtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                 this.nametxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                 this.adresstxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                 this.phone_notxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                 this.phone_no2txt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                 this.route_idtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                 btn_save.Text = "Edit";
                 nametxt.Focus();

                 if (dataGridView1.SelectedRows.Count >= 1)
                 {
                     dataGridView1.SelectedRows[0].Selected = false;
                 }
             }
             catch (Exception ex) { MessageBox.Show(ex.Message); }
         }

         private void textBox1_TextChanged(object sender, EventArgs e)
         {
             try
             {
                 customer = new BUSS.customer(this.textBox1.Text.Trim());
                 customer.BindcustomerDetaisSearch(dataGridView1);
 
                 if (dataGridView1.SelectedRows.Count >= 1)
                 { dataGridView1.SelectedRows[0].Selected = false; }
             }
             catch (Exception ex) { }
         }
        


    }
}
