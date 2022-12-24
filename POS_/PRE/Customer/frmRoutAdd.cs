using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_.PRE.Customer
{
    public partial class frmRoutAdd : Form
    {
       // function_ fun = new function_();
       // BUSCLASS.Root route = new BUSCLASS.Root();

        private BUSCLASS.Root route;
        DAT.NewDataAccessLayer Ndal=new DAT.NewDataAccessLayer();
        private int routid;
        private string fromroute;
        private string toroute;
        private string districk;
        private long shiftid;
        private DateTime credateDate;


        public frmRoutAdd(string userid,string username)
        {
            InitializeComponent();

            

            lauser.Text = userid; lausername.Text = username;
        }

        public frmRoutAdd(string shiftid,string username, string routid, string froute,string toroute,string disr)
        {
            InitializeComponent();
            lauser.Text = shiftid; lausername.Text = username;
            this.txtrotid.Text= routid;
            this.txtfrom.Text = froute;
            this.txtto.Text = toroute;
            this.comboBox1.Text = disr;

        }
        private void frmRoutAdd_Load(object sender, EventArgs e)
        {
            try
            {
                BUSS.FormOpenClass.AddRootOpened = true;
                pb_loading.Visible = false;
              //  Ndal.datagridviewcolor(dataGridView1);
            }
            catch { }
        }

        private bool Valid()
        {

            //this.id = this.txt_id.Text;
            //this.description = this.txt_description.Text.Trim();

            this.shiftid = Convert.ToInt64(lauser.Text);
            this.credateDate = DateTime.Now;

            if (string.IsNullOrEmpty(this.txtrotid.Text.Trim())) { this.routid = 0; } else { this.routid = Convert.ToInt32(this.txtrotid.Text); }

            if (string.IsNullOrEmpty(this.txtfrom.Text.Trim()))
            {
                this.Ndal.ShowMessage("Please Enter From Rouet Name !!!!", "Error");
                txtfrom.Focus();
                return false;
            }
            else
            {
                this.fromroute = this.txtfrom.Text.Trim();
            }

            if (string.IsNullOrEmpty(this.txtto.Text.Trim()))
            {

                this.Ndal.ShowMessage("Please Enter From Rouet Name !!!!", "Error");
                txtto.Focus();
                return false;
            }
            else
            {
                this.toroute = this.txtto.Text.Trim();
            }

            if (string.IsNullOrEmpty(comboBox1.Text.Trim()))
            {

                this.Ndal.ShowMessage("Invalid District !", "Error");
                comboBox1.Focus();
                return false;
            }
            else
            {
                this.districk = this.comboBox1.Text.Trim();
            }
            return true;

        }
        private void Reset_Data()
        {
            this.txtrotid.Clear();
            this.txtfrom.Clear();
            this.txtto.Clear();
            this.comboBox1.Text = "";
            this.txtfrom.Focus();

        }
        private bool Send_Data()
        {
            bool flag3;

            this.route = new BUSCLASS.Root(this.routid, this.fromroute, this.toroute,this.districk,this.credateDate,this.shiftid);
            flag3 = (this.routid == 0) ? this.route.Create() : this.route.Modify();

            return flag3;
        }

        private bool Remove_Data()
        {
            bool flag2;
            //this.id = this.txt_id.Text;
            if (string.IsNullOrEmpty(txtrotid.Text.Trim()))
            {
                this.Ndal.ShowMessage("Please select the data !", "Error");
                flag2 = false;
            }
            else if (!this.Ndal.ShowMessage("Are sure delete this data ?", "Confirm"))
            {
                flag2 = true;
            }
            else
            {
                this.routid = Convert.ToInt32(this.txtrotid.Text);
                this.shiftid = Convert.ToInt64(lauser.Text);
                this.credateDate = DateTime.Now;
                this.route = new BUSCLASS.Root(this.routid,this.shiftid,this.credateDate);
                flag2 = this.route.Remove();
            }
            return flag2;
        }

        private async void Start_Process(bool is_send)
        {

            Task<bool> task = ((is_send) ? new Task<bool>(new Func<bool>(Send_Data)) : new Task<bool>(new Func<bool>(Remove_Data)));
            pb_loading.Visible = true;
            task.Start();
            if (await task)
            {
                Reset_Data();
                pb_loading.Visible = false;
                Ndal.ShowMessage(route.Message, "Information");
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
                    Ndal.ShowMessage(route.Message, "Error");
                }
                catch
                {
                }
            }
        }
        private void btnewaccountno_Click(object sender, EventArgs e)
        {


            try
            {
                if (Valid()) { this.Start_Process(true); }

            }
            catch { }







         
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //if (fun.checkauthentication("8", "2", this.lauser.Text.ToString()) == "1")
            //    //{
            //    if (string.IsNullOrEmpty(txtfrom.Text.Trim())) { fun.validationMessge("Please Enter From Rouet Name !!!!"); }
            //    else if (string.IsNullOrEmpty(txtto.Text.Trim())) { fun.validationMessge("Please Enter Ot Rouet Name !!!!"); }
            //    else if (string.IsNullOrEmpty(comboBox1.Text.Trim())) { fun.validationMessge("Please Select District !!!!"); comboBox1.Focus(); return; }
            
            //        else
            //        {
            //            DialogResult dialog = MessageBox.Show("Do You Want To Update Rute Details ?", "Conform Message", MessageBoxButtons.YesNo);
            //            if (dialog == DialogResult.Yes)
            //            {
            //                route.routid = Convert.ToInt32(txtrotid.Text.Trim());

            //                route.fromrouat = txtfrom.Text.Trim();
            //                route.torouat = txtto.Text.Trim();
            //                route.distr = comboBox1.Text.Trim();
            //                route.createuser = Convert.ToInt32(this.lauser.Text);
            //                route.accessuser = Convert.ToInt32(this.lauser.Text);
                          
            //                route.RouatUpdate();



            //                fun.EditMessge();

            //                route.RouatSearch(dataGridView1, 3);
            //                TextBox[] txt = { txtrotid, txtto, txtfrom }; fun.TextClear(txt); comboBox1.Text = "";
            //                btnewaccountno.Enabled = true; button2.Enabled = true;
            //                txtfrom.Focus();
            //            }
            //        }
            //    //}//permision end
            //    //else { fun.validationMessge("You do not have permission to access this form !!!!!"); }//permision else end

            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtrotid.Text.Trim())) { } else { this.Start_Process(false); }


            }
            catch { }

            try
            {
                //if (fun.checkauthentication("8", "2", this.lauser.Text.ToString()) == "1")
                //{

                    //DialogResult dialog = MessageBox.Show("Do You Want To Delete  ?", "Conform Message", MessageBoxButtons.YesNo);
                    //if (dialog == DialogResult.Yes)
                    //{
                    //    route.routid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    //    route.accessuser = Convert.ToInt32(this.lauser.Text);
                    //    route.accessdate = DateTime.Now;
                    //    route.RouatDelete();

                     

                    //    fun.DeleteMessge();
                    //    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                    //}
                //}//permision end
                //else { fun.validationMessge("You do not have permission to access this form !!!!!"); }//permision else end

            }
            catch {// fun.validationMessge("Please Select Delete Data From Datagridview !!!!"); 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (fun.checkauthentication("8", "3", this.lauser.Text.ToString()) == "1")
                //{
                  //route.fromrouat = this.textBox1.Text.Trim();
                  //route.torouat=this.textBox1.Text.Trim();
                  //route.distr = this.textBox1.Text.Trim();
                  //route.RouatSearch(dataGridView1,1);
                }
            //permision end
                //else { fun.validationMessge("You do not have permission to access this form !!!!!"); }//permision else end

            //}
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtfrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtto.Focus();
                Ndal.FistLeterCapita(txtfrom);
            }
        }

        private void txtto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
             // comboBox1 .Focus();
              Ndal.FistLeterCapita(txtfrom);
              comboBox1.DroppedDown = true;
              comboBox1.Focus();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btnewaccountno.Enabled == true)
                {
                    btnewaccountno.Focus();
                }
                else
                {
                    button1.Focus();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    //if (fun.checkauthentication("8", "2", this.lauser.Text.ToString()) == "1")
            //    //{
            //    DialogResult dialog = MessageBox.Show("Do You Want To Get Edit Data ?", "Confirm Message", MessageBoxButtons.YesNo);
            //    if (dialog == DialogResult.Yes)
            //    {
            //        labank.Visible = true; txtrotid.Visible = true;
            //        txtrotid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //        txtfrom.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //        txtto.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //        comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //        btnewaccountno.Enabled = false; button2.Enabled = false;
            //        txtfrom.Focus();
            //    }
            //    //}//permision end
            //    //else { fun.validationMessge("You do not have permission to access this form !!!!!"); }//permision else end

            //}
            //catch { }
        }

        private void frmRoutAdd_Shown(object sender, EventArgs e)
        {
            txtfrom.Focus();
        }

        private void btnewaccountno_Enter(object sender, EventArgs e)
        {
            Ndal.godFocusOnButton(btnewaccountno);
        }

        private void btnewaccountno_Leave(object sender, EventArgs e)
        {
            Ndal.lostFocusOnButton(btnewaccountno);
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            Ndal.godFocusOnButton(button2);
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            Ndal.lostFocusOnButton(button2);
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            Ndal.lostFocusOnButton(button1);

        }

        private void button1_Enter(object sender, EventArgs e)
        {
            Ndal.godFocusOnButton(button1);
        }

        private void frmRoutAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            BUSS.FormOpenClass.AddRootOpened = false;
               
        }
    }
}
