using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_.PRE
{
    public partial class DRESS : Form
    {

        private int id;
        private string name;
        private int age;
        private string adress;
        private double amount;
        private long shift_id;

        BUSS.dress dress;

        POS_.function_ fun = new POS_.function_();
        DAT.NewDataAccessLayer Ndal = new DAT.NewDataAccessLayer();
        public DRESS()
        {
            InitializeComponent();
        }

        private async void Start_Process(bool is_send)
        {

            Task<bool> task = is_send ? new Task<bool>(new Func<bool>(Remove_Data)) : new Task<bool>(new Func<bool>(Send_Data));
            progressBar1.Visible = true;
            task.Start();
            if (await task)
            {
                Clear();
                progressBar1.Visible = false;

            }
            else
            {
                try
                { progressBar1.Visible = false; }
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
                dress = new BUSS.dress(id);
                flag2 = dress.Deletedress();
            }
            return flag2;
        }

        private bool Send_Data()
        {
            if ((fun.ShowMessage("Are You Sure You Want To " + btn_save.Text + "  ?", "Confirm")))
            {

                this.dress = new BUSS.dress(id, name, age, adress, amount, shift_id);

                if (id == 0)
                {
                    return dress.Savedress();
                }

                else
                {

                    return dress.Editdress();
                }
            }
            return false;

        }


        public void Clear()
        {
            try
            {
                dress.BinddressDetails(dataGridView1);
            }
            catch { }

            btn_save.Text = "Save";
            idtxt.Text = "";
            nametxt.Text = "";
            agetxt.Text = "";
            adresstxt.Text = "";
            amounttxt.Text = "";

        }

        

        private void dataGridView1_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.idtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.nametxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.agetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.adresstxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.amounttxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                btn_save.Text = "Edit";
                idtxt.Focus();

                if (dataGridView1.SelectedRows.Count >= 1)
                {
                    dataGridView1.SelectedRows[0].Selected = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*-------------------------Validation process--------------------------*/

        public bool Validation()
        {

            if (string.IsNullOrEmpty(this.nametxt.Text.Trim()))
            { fun.validationMessge("Please Enter name"); this.nametxt.Focus(); return false; }
            if (string.IsNullOrEmpty(this.agetxt.Text.Trim()))
            { fun.validationMessge("Please Enter age"); this.agetxt.Focus(); return false; }
            if (string.IsNullOrEmpty(this.adresstxt.Text.Trim()))
            { fun.validationMessge("Please Enter adress"); this.adresstxt.Focus(); return false; }
            if (string.IsNullOrEmpty(this.amounttxt.Text.Trim()))
            { fun.validationMessge("Please Enter amount"); this.amounttxt.Focus(); return false; }
            else
            {
                if (string.IsNullOrEmpty(idtxt.Text.Trim())) { this.id = 0; }
                else { this.id = Convert.ToInt32(this.idtxt.Text); }
                this.name = this.nametxt.Text.Trim();
                this.age = Convert.ToInt32(this.agetxt.Text);
                this.adress = this.adresstxt.Text.Trim();
                amount = Convert.ToDouble(amounttxt.Text);
                this.shift_id = 0;
            }
            return true;
        }

        private void DRESS_Load_1(object sender, EventArgs e)
        {
            try
            {
                dress = new BUSS.dress();
                dress.BinddressDetails(dataGridView1);
            }
            catch { }
        }
    }
}
