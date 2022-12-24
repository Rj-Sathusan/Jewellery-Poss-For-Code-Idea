using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_.PRE.NewCategory
{
    public partial class frmListofCategory : Form
    {
        private Form1 frm_main = (Form1)Application.OpenForms["Form1"];
   
        BUSS.Category bra;// = new BUSS.Category();
        function_ fun = new function_();

        string shiftid, username;
        public frmListofCategory(string _shiftid,string _username)
        {
            InitializeComponent();
            shiftid = _shiftid; username = _username;
            try
            {
                Bind_Data();
            }
            catch { }
        }

        public frmListofCategory(SplitContainer spco)
        {
            InitializeComponent();
            try
            {
              //  splitContainer = spco;
                Bind_Data();
            }
            catch { }
        }
        public void Bind_Data()
        {
            dgv_datas.Rows.Clear();

            this.bra = new BUSS.Category();
            fun.BindGrid(dgv_datas, this.bra.ShowAllCategory());

            if (dgv_datas.SelectedRows.Count >= 1)
            {
                dgv_datas.SelectedRows[0].Selected = false;
            }
            this.bra = null;
           
        }

        public void Serach_Bind_Data()
        {
            try
            {

                dgv_datas.Rows.Clear();

                this.bra = new BUSS.Category();
                fun.BindGrid(dgv_datas, this.bra.Search_Get_All(this.txt_find.Text));

                if (dgv_datas.SelectedRows.Count >= 1)
                {
                    dgv_datas.SelectedRows[0].Selected = false;
                }
                this.bra = null;
            }
            catch { }
        }
        private void frmListofBrand_Load(object sender, EventArgs e)
        {
          BUSS.FormOpenClass.ListOfCategoryOpened = true;
         
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
                else if (msg.WParam.ToInt32() == (int)Keys.F11)
                {//datagridview unselect

                  



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

        private void frmListofBrand_FormClosing(object sender, FormClosingEventArgs e)
        {
           BUSS.FormOpenClass.ListOfCategoryOpened = false;
        }

        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            try { Serach_Bind_Data(); } catch { }
         
        }

        private void frmListofBrand_Shown(object sender, EventArgs e)
        {
            txt_find.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fun.ShowMessage("Are You Sure You Want To Exit", "Confirm"))
            {
                base.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                PRE.Category.frmAddCategory frm = new PRE.Category.frmAddCategory();
               // frm.MdiParent = frmAddCategory.ActiveForm;
                frm.WindowState = FormWindowState.Maximized;
                frm.BringToFront();
                frm.ShowDialog();
                Bind_Data();
               // this.Close();
                 */

                if (!BUSS.FormOpenClass.AddRootOpened)
                {
                    PRE.NewCategory.frmAddCategory frm1 = new PRE.NewCategory.frmAddCategory(shiftid, username);

                    // frmAddCategory frmAddCategory = new frmAddCategory(this);
                    frm1.MdiParent = (Form)this.frm_main;
                    frm1.Show();
                    base.Close();


                    //if (!BUSS.FormOpenClass.LisfOfRootOpened)
                    //{
                    //    PRE.Customer.frmListofRoute frm = new PRE.Customer.frmListofRoute(shiftid, username);

                    //    frm.MdiParent = (Form)this.frm_main;
                    //    frm.ShowDialog();

                    //}

                }
            }
            catch { }

        }

        private void dgv_datas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         //   new frmAddBrand(this.dgv_datas.CurrentRow.Cells["id"].Value.ToString(), this) { MdiParent = this.frm_main }.Show();
            try
            {
                string a =dgv_datas.Rows[e.RowIndex].Cells[0].Value.ToString();
                string b = dgv_datas.Rows[e.RowIndex].Cells[1].Value.ToString();




                PRE.NewCategory.frmAddCategory frm1 = new PRE.NewCategory.frmAddCategory(shiftid, username, a, b);

                // frmAddCategory frmAddCategory = new frmAddCategory(this);
                frm1.MdiParent = (Form)this.frm_main;
                frm1.BringToFront();
                frm1.Show();
                this.Close();
            }
            catch { }
        }
    }
}
