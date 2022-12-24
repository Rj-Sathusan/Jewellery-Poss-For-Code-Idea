using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_.NEWPRE.Category
{
    public partial class frmAddCatergory : Form
    {
        function_ fun = new function_(); BUS.Category cat = new BUS.Category();
        int save = 0, scon = 0; 
        public frmAddCatergory(long shiftid,Int32 branchid,int con)
        {
            InitializeComponent();
            this.Text = this.Text = BUS.Global.shopname + " >>>>>>> " + "New Category";
            lauser.Text = shiftid.ToString(); labranch.Text = branchid.ToString(); scon = con;
            txtdiscription.Focus();
           
        }
      
        public frmAddCatergory()
        {
            InitializeComponent();
            this.Text = this.Text = BUS.Global.shopname + " >>>>>>> " + "New Category";

            lauser.Text = "1"; labranch.Text = "1";
        }
        private void fill_grid()
        {
     

        }
        public void getcatid()
        {
         
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {

                if (msg.WParam.ToInt32() == (int)Keys.Enter)
                {
                    if (dataGridView1.SelectedRows.Count >= 1 )
                    {
                        DialogResult result = MessageBox.Show("Are You Sure You Want To Modify ?\n\nCategory Id : " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "\n\nCategory : " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "", "Point of Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            cat._Categoryid = Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                            txtdiscription.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                            button1.Visible = false;
                            button3.Visible = true; button5.Text = "Cancel";
                          
                            if (dataGridView1.SelectedRows.Count >= 1)
                            { dataGridView1.SelectedRows[0].Selected = false; }
                            txtdiscription.Focus();
                            return true;
                        }
                    }
                }
                else if (msg.WParam.ToInt32() == (int)Keys.F12)
                {//da      tagridview select


                    try
                    {

                        dataGridView1.Rows[0].Selected = true;
                        dataGridView1.Focus();

                        return true;
                    }
                    catch { }




                }

                else if (msg.WParam.ToInt32() == (int)Keys.Delete)
                {//da      tagridview select


                  

                }
                else if (msg.WParam.ToInt32() == (int)Keys.F11)
                {//datagridview unselect

                    try
                    {


                        dataGridView1.SelectedRows[0].Selected = false;


                    }
                    catch { }



                }
                else if (msg.WParam.ToInt32() == (int)Keys.Escape)
                {//datagridview unselect

                    try
                    {

                        DialogResult result = MessageBox.Show("Are You Sure You Want To Exit  ?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            this.Close();
                        }

                    }
                    catch { }



                }
            }
            catch { }
            return base.ProcessCmdKey(ref msg, keyData);
            return true;
        }
        private void frmAddCatergory_Load(object sender, EventArgs e)
        {
            try
            {
              

                lauser.Visible = false;
                lashift.Visible = false;
              
                button3.Visible = false;
             
            }
            catch { }
        }


        private bool Validation()
        {

            if (string.IsNullOrEmpty(txtdiscription.Text.Trim()))
            {
                fun.validationMessge("Please Enetr the Category Name !!!!!"); txtdiscription.Focus(); return false;
            }

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (fun.ShowMessage("Do You Want To Save ?\n\nCategory : " + txtdiscription.Text.Trim() + "", "Confirm"))
                {
                    cat._Shiftid = Convert.ToInt64(lauser.Text);
                    cat._BranceId = Convert.ToInt32(labranch.Text);
                    cat._CategoryName = txtdiscription.Text.Trim();
                    cat._createdate = DateTime.Now;
                    cat._Categoryid = Convert.ToInt64(DateTime.Now.ToString("yyyyMMddHHmmss"));

                    cat.AddCategory();
                   
                    cat.BindDatagridview(dataGridView1);

                    if (scon == 1) { save = 1; lasave.Text = save.ToString(); this.Close(); }
                    TextBox[] txt = { txtdiscription };
                    fun.TextClear(txt);
                    if (dataGridView1.SelectedRows.Count >= 1)
                    { dataGridView1.SelectedRows[0].Selected = false; }
                    txtdiscription.Focus();
                }
                
                    
                
            }
            catch 
            {
              
                txtdiscription.Text = ""; txtdiscription.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (Validation())
                {
                    if (fun.ShowMessage("Do You Want To Save ?\n\nCategory : " + txtdiscription.Text.Trim() + "", "Confirm"))
                    {
                        cat._CategoryName = this.txtdiscription.Text.Trim();
                        cat.EditCategory();

                        button3.Visible = false;
                        button1.Visible = true;
                     
                        cat.BindDatagridview(dataGridView1);
                        TextBox[] txt = { txtdiscription };
                        fun.TextClear(txt); button5.Text = "Delete";
                        if (dataGridView1.SelectedRows.Count >= 1)
                        { dataGridView1.SelectedRows[0].Selected = false; }
                        txtdiscription.Focus();
                    }
                }
               


                   
            }
            catch 
            {
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (button5.Text == "Cancel")
                {
                    TextBox[] txt = { txtdiscription };
                    fun.TextClear(txt); button5.Text = "Delete"; button3.Visible = false; button1.Visible = true ; 
                    txtdiscription.Focus();
                }
                else
                {
                    if (dataGridView1.SelectedRows.Count == 0)
                    {
                        fun.validationMessge("Please Select Catergory From Table !!!");
                    }
                    else
                    {
                        if (fun.ShowMessage("Are You Sure You Want To Delete ?\n\nCategory Id : " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "\n\nCategory : " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "", "Confirm"))
                        {
                            cat._Categoryid = Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                            cat.DeleteCategory();
                          
                            cat.BindDatagridview(dataGridView1);
                            if (dataGridView1.SelectedRows.Count >= 1)
                            { dataGridView1.SelectedRows[0].Selected = false; }
                            txtdiscription.Focus();

                        }


                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Exit  ?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (result == DialogResult.Yes)
             {
                 this.Close();
             }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try {cat._CategoryName=this.textBox1.Text.Trim();
            
                     cat.SearchBindDatagridview(dataGridView1);
                     if (dataGridView1.SelectedRows.Count >= 1)
                     { dataGridView1.SelectedRows[0].Selected = false; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want To Modify ?\n\nCategory Id : " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "\n\nCategory : " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "", "Point of Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                   cat._Categoryid     =Convert.ToInt64( dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtdiscription.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    button1.Visible = false;
                    button3.Visible = true; button5.Text = "Cancel";

                    if (dataGridView1.SelectedRows.Count >= 1)
                    { dataGridView1.SelectedRows[0].Selected = false; }
                    txtdiscription.Focus();
                }
                // txtcatergory_id.ReadOnly = true;
            }
            catch
            {
                // MessageBox.Show(ex.Message);
               
            }
        }

        private void frmAddCatergory_Shown(object sender, EventArgs e)
        {
            txtdiscription.Focus();
        }

        private void txtdiscription_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Enter)
                {
                    
             
                    if (button1.Visible == true)
                    {
                        fun.FistLeterCapita(txtdiscription);
                        button1.Focus();
                    }
                    else { fun.FistLeterCapita(txtdiscription); button3.Focus(); }
                    //this.SelectNextControl(txtdescription, true, true, true, true);
                }
            }
            catch { }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    int col = dataGridView1.CurrentCell.ColumnIndex;
                    int row = dataGridView1.CurrentCell.RowIndex;

                    if (col < dataGridView1.ColumnCount - 1)
                    {
                        col++;
                    }
                    else
                    {
                        col = 0;
                        row++;
                    }

                    if (row == dataGridView1.RowCount)
                        dataGridView1.Rows.Add();

                    dataGridView1.CurrentCell = dataGridView1[col, row];
                    e.Handled = true;
                }
                // txtcatergory_id.ReadOnly = true;
            }
            catch
            {
                // MessageBox.Show(ex.Message);

            }
        }

        private void txtdiscription_TextChanged(object sender, EventArgs e)
        {

        }

        private void lasave_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Enter(object sender, EventArgs e)
        {
            fun.godFocusOnButton(button1);
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            fun.lostFocusOnButton(button1);
        }

        private void button3_Enter(object sender, EventArgs e)
        {
            fun.godFocusOnButton(button3);
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            fun.lostFocusOnButton(button3);
        }

        private void button5_Enter(object sender, EventArgs e)
        {
            fun.godFocusOnButton(button5);
        }

        private void button5_Leave(object sender, EventArgs e)
        {
            fun.lostFocusOnButton(button5);
        }

        private void button4_Enter(object sender, EventArgs e)
        {
            fun.godFocusOnButton(button4);
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            fun.lostFocusOnButton(button4);
        }
    }
}
