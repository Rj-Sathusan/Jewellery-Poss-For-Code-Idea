namespace POS_.PRE.NewCategory
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public class frmAddCategory : Form
    {
        int c = 0;
        DAT.NewDataAccessLayer Ndal = new DAT.NewDataAccessLayer();
        // private frmListOfCategory frm_list_of_categorys;
        private BUSS.Category category;
        private int id;
        private string description;
        private bool ispet;
        private int creditlimit;
        private int orderby;

        private long shiftid;
        private IContainer components;
        private Panel panel1;
        private Label label2;
        public TextBox txt_description;
        private Button button2;
        private Button button1;
        private Label label1;
        public TextBox txt_id;
        private ProgressBar pb_loading;
        private Button button3;

        string Shiftid, username;
        public frmAddCategory(string _shiftid,string _username)
        {
            this.components = null;
            this.InitializeComponent();
            try
            { Shiftid = _shiftid; username = _username; GetLastOorderBy(); }
            catch { }
        }
        public void GetLastOorderBy()
        {

           // txtorder.Text = cat.GetLastCategoryOrder().ToString();
        }
        //public frmAddCategory(frmListOfCategory frm_list_of_category)
        //{
        //    this.functions = new Functions();
        //    this.components = null;
        //    this.InitializeComponent();
        //    this.frm_list_of_categorys = frm_list_of_category;
        //}

        public frmAddCategory(string _shiftid,string _username, string id, string des)
        {
          //  this.functions = new DAT.function_();

            this.components = null;
            this.InitializeComponent();
            Shiftid = _shiftid; username = _username;
            this.txt_id.Text = id;
            this.txt_description.Text = des;
           //// this.txt_credit_limit.Text = creditlimit;
            //if (ispet == "Pet")
            //{ ckb_pet.Checked = true; }
            //else { ckb_pet.Checked =false; }
            //txtorder.Text = orderby;
            
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Start_Process(false);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           

            // if( functions.ShowMessage("Are You Sure You Want To Exit  ?", DAT.MessageType.Confirm)){
            //    base.Close();
            //}
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Start_Process(true);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FrmAddCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
          BUSS.FormOpenClass.AddCategoryOpened = false;
        }

        private void FrmAddCategory_Load(object sender, EventArgs e)
        {
            BUSS.FormOpenClass.AddCategoryOpened = true;
           
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {

                if (msg.WParam.ToInt32() == (int)Keys.Enter)
                {

                }
                else if (msg.WParam.ToInt32() == (int)Keys.F12)
                {//da      tagridview select





                }

                else if (msg.WParam.ToInt32() == (int)Keys.Delete)
                {//da      tagridview select



                }
                else if (msg.WParam.ToInt32() == (int)Keys.F2)
                {//datagridview unselect


                    //if(ckb_pet.Checked==true)
                    //{

                    //    ckb_pet.Checked = false;
                    //    ckb_pet.Focus();
                    //}
                    //else
                    //{ ckb_pet.Checked = true;ckb_pet.Focus(); }


                }
                else if (msg.WParam.ToInt32() == (int)Keys.F4)
                {//datagridview unselect

                    try
                    {

                        DialogResult result = MessageBox.Show("Are You Sure You Want To Exit  ?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            base.Close();
                        }

                    }
                    catch { }



                }
            }
            catch { }
            return base.ProcessCmdKey(ref msg, keyData);
            //return true;
        }

        //private void Get_Data()
        //{
        //    this.category = new BUS.Category(this.id);
        //    this.category = this.category.Get("Id");
        //    this.txt_description.Text = this.category.Description;
        //    this.ckb_pet.Checked = this.category.IsPet;
        //    this.txt_credit_limit.Text = this.category.CreditLimit.ToString();
        //}

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pb_loading = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pb_loading);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_description);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 222);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(202, 78);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 24);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete [F3]";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            this.button3.Enter += new System.EventHandler(this.button3_Enter);
            this.button3.Leave += new System.EventHandler(this.button3_Leave);
            // 
            // pb_loading
            // 
            this.pb_loading.Location = new System.Drawing.Point(103, 107);
            this.pb_loading.Margin = new System.Windows.Forms.Padding(2);
            this.pb_loading.Name = "pb_loading";
            this.pb_loading.Size = new System.Drawing.Size(282, 10);
            this.pb_loading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pb_loading.TabIndex = 5;
            this.pb_loading.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 64;
            this.label1.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.White;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(103, 23);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(144, 22);
            this.txt_id.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(297, 78);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel [F4]";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            this.button2.Enter += new System.EventHandler(this.button2_Enter);
            this.button2.Leave += new System.EventHandler(this.button2_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(103, 78);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save [ENT]";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button1.Enter += new System.EventHandler(this.button1_Enter);
            this.button1.Leave += new System.EventHandler(this.button1_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Description";
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.Color.White;
            this.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_description.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.Location = new System.Drawing.Point(103, 49);
            this.txt_description.Margin = new System.Windows.Forms.Padding(2);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(212, 22);
            this.txt_description.TabIndex = 0;
            this.txt_description.Enter += new System.EventHandler(this.Txt_description_Enter);
            this.txt_description.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_description_KeyDown);
            this.txt_description.Leave += new System.EventHandler(this.Txt_description_Leave);
            // 
            // frmAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 222);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddCategory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddCategory_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddCategory_Load);
            this.Shown += new System.EventHandler(this.frmAddCategory_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private bool Remove_Data()
        {
            bool flag2;
           if (string.IsNullOrEmpty(txt_id.Text.Trim()))
            {
               Ndal.ShowMessage("Please select the data !", "Error");
                flag2= false;
            }

           else if (!this.Ndal.ShowMessage("Are sure delete this data ?", "Confirm"))
           {
               flag2 = true;
           }
           else
           {
                id = Convert.ToInt32(txt_id.Text);
                category = new BUSS.Category(id);
                flag2= category.Remove();
            }
           return flag2;
        }

        private void Reset_Data()
        {
            this.txt_id.Clear();
            this.txt_description.Clear();
            this.txt_description.Focus();
           // this.txt_credit_limit.Text = "";

            //GetLastOorderBy(); 
        }

        private bool Send_Data()
        {
            if (Valid())
            {
                category = new BUSS.Category(id, description, ispet, creditlimit, shiftid);
                if (id == 0)
                {
                    return category.Create();
                }
                return category.Modify();
            }
            else
            {
                
                return false;
            }
        }
        private void Txt_description_Enter(object sender, EventArgs e)
        {
            //this.functions.Focus(this.txt_description);
        }

        private void Txt_description_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                //txt_credit_limit.Focus();
                button1.Focus();
            }
            
            //if (e.KeyCode == Keys.Enter)
            //{
            //    this.Start_Process(true);
            //}
            //if (e.KeyCode == Keys.F2)
            //{
            //    this.Reset_Data();
            //}
            //if (e.KeyCode == Keys.F3)
            //{
            //    this.Start_Process(false);
            //}
            //if (e.KeyCode == Keys.F4)
            //{
            //    base.Close();
            //}
        }

        private void Txt_description_Leave(object sender, EventArgs e)
        {
            //this.functions.Leave(this.txt_description);
        }

        private bool Valid()
        {
   
            if(string.IsNullOrEmpty(txt_id.Text.Trim())){id=0;}else{id =Convert.ToInt32( txt_id.Text);}
            shiftid = Convert.ToInt64(Shiftid);

            description = txt_description.Text.Trim();
            ispet =false;c = 0;
            if (string.IsNullOrEmpty(description))
            {
                Ndal.ShowMessage("Invalid description !", "Error");
                //  txt_description.Focus();
                c = 3;
                return false;
            }
            creditlimit = 0;
                c = 1;
                orderby = 0;
            //try
            //{
            //    creditlimit = 0;
            //    c = 1;
            //    orderby = 0;
             
            //}
            //catch
            //{
            //    if (c == 0)
            //    {
            //        Ndal.ShowMessage("Invalid credit limit !", "Error");
            //       // txt_credit_limit.Focus();
            //        return false;
            //    }
            //    else
            //    {

            //        Ndal.("Invalid Order !", "Error");
            //       // txtorder.Focus();
            //        return false;
            //    }
            //}
           
            return true;
        }
        private async void Start_Process(bool is_send)
        {
           
            Task<bool> task = is_send? new Task<bool>(new Func<bool>(Remove_Data)) : new Task<bool>(new Func<bool>(Send_Data));
            pb_loading.Visible=true;
            task.Start();
            if (await task)
               
            {
                Reset_Data();
               pb_loading.Visible=false;

               Ndal.ShowMessage(category.Message, "Information");
                //if (frm_list_of_categorys != null)
                //{
                //    frm_list_of_categorys.Bind_Data();
                //    ((Form)this).Close();
                //}
            }
            else
            {
                try
                {
                    pb_loading.Visible = false;
                   // functions.ShowMessage(category.Response_Message(), DAT.MessageType.Error);

                    //if (c == 3)
                    //{
                    //    txt_description.Focus();

                    //}
                    //else if (c == 0)
                    //{
                    //    txt_credit_limit.Focus();
                    //}
                    //else if (c == 1) { txtorder.Focus(); }
                }
                catch
                {
                }
            }
        }

        private async void Save_Process(bool is_send)
        {

            Task<bool> task = is_send ? new Task<bool>(new Func<bool>(Remove_Data)) : new Task<bool>(new Func<bool>(Send_Data));
            pb_loading.Visible = true;
            task.Start();
            if (await task)

            {
                Reset_Data();
                pb_loading.Visible = false;
                //if (frm_list_of_categorys != null)
                //{
                //    frm_list_of_categorys.Bind_Data();
                //    ((Form)this).Close();
                //}
            }
            else
            {
                try
                {
                    pb_loading.Visible = false;
                    // functions.ShowMessage(category.Response_Message(), DAT.MessageType.Error);

                    //if (c == 3)
                    //{
                    //    txt_description.Focus();

                    //}
                    //else if (c == 0)
                    //{
                    //    txt_credit_limit.Focus();
                    //}
                    //else if (c == 1) { txtorder.Focus(); }
                }
                catch
                {
                }
            }
        }

        private void frmAddCategory_Shown(object sender, EventArgs e)
        {
            txt_description.Focus();
        }

        private void txt_credit_limit_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode==Keys.Enter)
            //{ txtorder.Focus(); }
        }

        private void ckb_pet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { button1.Focus(); }
        }

        private void txt_credit_limit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //functions.InputNumberOnley(txt_credit_limit, e);
        }

        private void txtorder_KeyPress(object sender, KeyPressEventArgs e)
        {
            //functions.InputNumberOnley(txtorder, e);
        }

        private void txtorder_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode==Keys.Enter)
            //{
            //    ckb_pet.Focus();

            //}
        }

        private void button1_Enter(object sender, EventArgs e)
        {
           Ndal .godFocusOnButton(button1);
        }

        private void button1_Leave(object sender, EventArgs e)
        {
           Ndal.lostFocusOnButton(button1);
        }

        private void button3_Enter(object sender, EventArgs e)
        {
            Ndal.godFocusOnButton(button3);
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            Ndal.godFocusOnButton(button2);
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            Ndal.lostFocusOnButton(button3);
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            Ndal.lostFocusOnButton(button2);
        }
    }
    }


