using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_.PRE.USER
{
    public partial class USER : Form
    {
        private int id;
        private string name;
        private string nic;
        private string designation;
        private string mobile;
        private string email;

        DAT.NewDataAccessLayer nda1 = new DAT.NewDataAccessLayer();
        BUSS.user user;
        public USER()
        {
            InitializeComponent();
        }

        /*-------------------------Validation process--------------------------*/

        public bool Validation()
        {
            if (string.IsNullOrEmpty(this.nametxt.Text.Trim()))
            { nda1.validationMessge("Please Enter name"); this.nametxt.Focus(); return false; }

            else
            {
                if (string.IsNullOrEmpty(idtxt.Text.Trim())) { this.id = 0; }
                else
                {this.id = Convert.ToInt32(idtxt.Text);}

                this.name = this.nametxt.Text.Trim();
                this.nic = this.nictxt.Text.Trim();
                this.designation = this.designationtxt.Text.Trim();
                this.mobile = this.mobiletxt.Text.Trim();
                this.email = this.emailtxt.Text.Trim();
            }
            return true;
        }

        private void Clear()
        {
            try
            {
                idtxt.Clear();
                nametxt.Clear();
                nictxt.Clear();
                designationtxt.Clear();
                mobiletxt.Clear();
                emailtxt.Clear();
                nametxt.Focus();
                btn_save.Text = "Save";
                BUSS.user user = new BUSS.user();
                user.BindIuserDetailsFull(dataGridView1);
            }
            catch { }

        }

        private async void Start_Process(bool is_send)
        {

            Task<bool> task = ((is_send) ? new Task<bool>(new Func<bool>(Send_Data)) : new Task<bool>(new Func<bool>(Remove_Data)));
            pb_loading.Visible = true;
            task.Start();
            if (await task)
            {
                Clear();
                pb_loading.Visible = false;
                //nda1.ShowMessage(user.Message, "Information");
                //if (frm_list_of_root != null)
                //{
                //    frm_list_of_root.Bind_Data();
                //    ((Form)this).Close();
                //}
            }
            else
            {
                try
                {
                    pb_loading.Visible = false;
                    nda1.ShowMessage(user.Message, "Error");
                }
                catch
                {
                }
            }
        }


        private bool Send_Data()
        {
            //this.user = new BUSS.user(id, name, nic, designation, mobile, email);



            if (Validation())
            {
                this.user = new BUSS.user(id, name, nic, designation, mobile, email);


                if (id == 0)
                {
                    return user.Saveuser();
                }


                else
                {

                    return user.Edituser();
                }
            }
            return false;


        }

        private bool Remove_Data()
        {
            bool flag2;
            //this.id = this.txt_id.Text;
            if (string.IsNullOrEmpty(idtxt.Text.Trim()))
            {
                this.nda1.ShowMessage("Please select the data !", "Error");
                flag2 = false;
            }
            else if (!this.nda1.ShowMessage("Are sure delete this data ?", "Confirm"))
            {
                flag2 = true;
            }
            else
            {
                this.user = new BUSS.user(id);
                flag2 = this.user.Deleteuser();
            }
            return flag2;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation()) { this.Start_Process(true); }

            }
            catch { }
        }

        private void USER_Load(object sender, EventArgs e)
        {
            BUSS.user user = new BUSS.user();
            user.BindIuserDetailsFull(dataGridView1);
            //item.BindItemDetailsFull(dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_save.Text = "Edit";
            this.idtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.nametxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.nictxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.designationtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.mobiletxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.emailtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            //this.txt_dis.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            //this.txt_propercent.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            //this.txt_category.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Validation()) { this.Start_Process(true); }

            }
            catch
            {

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        { /*---------------------------Delete process------------------------------------*/
            try
            {
                this.Start_Process(false);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }



        
    }

