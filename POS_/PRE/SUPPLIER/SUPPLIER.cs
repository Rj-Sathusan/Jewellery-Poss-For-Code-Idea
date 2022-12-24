using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_.PRE.SUPPLIER
{
    public partial class SUPPLIER : Form
    {

        private int id;
        private string name;
        private string phone_number;
        private string email;
        private string adress;
        private string fax;

        BUSS.supplier supplier;
        DAT.NewDataAccessLayer Ndal = new DAT.NewDataAccessLayer();
        POS_.function_ fun = new POS_.function_();

        public SUPPLIER()
        {
            InitializeComponent();
        }

        public void Clear()
        {
             try
            {
                supplier = new BUSS.supplier();
                supplier.BindsupplierDetails(dataGridView1);
            }
            catch { }
                btn_save.Text = "Save";
                idtxt.Text = "";
                phone_numbertxt.Text="";
                nametxt.Text="";
                emailtxt.Text="";
                adresstxt.Text="";
                faxtxt.Text="";
            
        }

        /*---------------------------Save EDIT process------------------------------------*/
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation())
                { this.Start_Process(false); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            /*---------------------------Delete process------------------------------------*/
            try
            {
                this.Start_Process(true);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        

        /*-------------------------Validation process--------------------------*/
            public bool Validation()
        {


                if (string.IsNullOrEmpty(this.nametxt.Text.Trim()))
                { fun.validationMessge("Please Enter Name"); this.nametxt.Focus(); return false; }
                

                else
                {
                    if (string.IsNullOrEmpty(idtxt.Text.Trim())) { this.id = 0; }
                    else { this.id = Convert.ToInt32(this.idtxt.Text); }

                this.phone_number = this.phone_numbertxt.Text.Trim();
                this.name = this.nametxt.Text.Trim();
                this.email = this.emailtxt.Text.Trim();
                this.adress = this.adresstxt.Text.Trim();
                this.fax = this.faxtxt.Text.Trim();
                }
            return true;
        

        }

            private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
            {
                try
                {
                    this.idtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.nametxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    this.phone_numbertxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    this.emailtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    this.faxtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    this.adresstxt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    btn_save.Text = "Edit";
                    nametxt.Focus(); 

                    if (dataGridView1.SelectedRows.Count >= 1)
                    {
                        dataGridView1.SelectedRows[0].Selected = false;
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

            private void SUPPLIER_Load(object sender, EventArgs e)
            {
                
                try{
                BUSS.supplier supplie = new BUSS.supplier();
                supplie.BindsupplierDetails(dataGridView1); 
                }  
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

        private bool Send_Data()
        {
            if ((fun.ShowMessage("Are You Sure You Want To "+btn_save.Text+"  ?", "Confirm")))
            {
                
                    this.supplier = new BUSS.supplier(id,name, phone_number, email, adress, fax);

                        if (id == 0)
                        {
                            return supplier.Savesupplier();
                        }
                   
                    else 
                    {

                        return supplier.Savesupplier();
                    }
                }              
            return false;        
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
                supplier = new BUSS.supplier(id);
                flag2 = supplier.Deletesupplier();
            }
            return flag2;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
