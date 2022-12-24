
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
    public partial class frmListofRoute : Form
    {
        BUSCLASS.Root ro;// = new BUSCLASS.Root();
        private Form1 frm_main = (Form1)Application.OpenForms["Form1"];
   
        DAT.NewDataAccessLayer ndal = new DAT.NewDataAccessLayer();
        string shiftid, username;
        //public frmListofRoute(string _shiftid,string _username)
        //{
        //    InitializeComponent();
        //    try { Bind_Data(); } catch { }
        //}

        public frmListofRoute(string _shiftid, string _username)
        {
            InitializeComponent();
            try { shiftid = _shiftid; username = _username; Bind_Data(); }
            catch { }
        }

        private void frmListofRoute_Shown(object sender, EventArgs e)
        {
            txt_find.Focus();
        }

        private void frmListofRoute_Load(object sender, EventArgs e)
        {
        BUSS.FormOpenClass.LisfOfRootOpened = true;
        }
        public void Serach_Bind_Data()
        {

            // this.brandBindingSource.DataSource =
            //
            //dgv_datas.DataSource = bra.Get_All();
            //ro.searchdate = this.txt_find.Text.Trim();
            try
            {
                dataGridView1.Rows.Clear();

                this.ro = new BUSCLASS.Root();
                ndal.BindGrid(dataGridView1, this.ro.SearchRoute(this.txt_find.Text));

                if (dataGridView1.SelectedRows.Count >= 1)
                {
                    dataGridView1.SelectedRows[0].Selected = false;
                }
                this.ro = null;
            }
            catch { }
        }
        private void frmListofRoute_FormClosing(object sender, FormClosingEventArgs e)
        {
            BUSS.FormOpenClass.LisfOfRootOpened = false;
        }
        public void Bind_Data()
        {
            try
            {
                dataGridView1.Rows.Clear();
                
                this.ro = new BUSCLASS.Root();
                ndal.BindGrid(dataGridView1, this.ro.ShowAllRoute());

                if (dataGridView1.SelectedRows.Count >= 1)
                {
                    dataGridView1.SelectedRows[0].Selected = false;
                }
                this.ro = null;
            }
            catch { }
        }

        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            try { Serach_Bind_Data(); } catch { }
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //PRE.Customer.frmRoutAdd frm = new PRE.Customer.frmRoutAdd("1", "1");
                //frm.MdiParent = PRE.Customer.frmRoutAdd.ActiveForm;
                //frm.ShowDialog();
                /*
                PRE.Customer.frmRoutAdd frm = new PRE.Customer.frmRoutAdd("1", "1");
              //  PRE.Rote.frmRouteAdd frm = new PRE.Rote.frmRouteAdd();
                //   frm.MdiParent = frmAddBrand.ActiveForm;
                frm.WindowState = FormWindowState.Maximized;
                frm.BringToFront();
                frm.ShowDialog();
                */
                //Bind_Data();
                if (!BUSS.FormOpenClass.AddRootOpened)
                {
                    PRE.Customer.frmRoutAdd frm1 = new PRE.Customer.frmRoutAdd(shiftid, username);

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (ndal.ShowMessage("Are You Sure You Want To Exit", "Confirm"))
            {
                base.Close();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {

                if (msg.WParam.ToInt32() == (int)Keys.F1)
                {//da      tagridview select


                    //PRE.Rote.frmRouteAdd frm = new PRE.Rote.frmRouteAdd();
                    ////   frm.MdiParent = frmAddBrand.ActiveForm;
                    //frm.WindowState = FormWindowState.Maximized;
                    //frm.BringToFront();
                    //frm.ShowDialog();

                    //Bind_Data();

                    return true;
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

        private void dgv_datas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //PRE.Rote.frmRouteAdd frm = new PRE.Rote.frmRouteAdd(dgv_datas.Rows[e.RowIndex].Cells[0].Value.ToString());

                //frm.WindowState = FormWindowState.Maximized;
                //frm.ShowDialog();

                //Bind_Data();
            }
            catch { }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string a = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string b = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string c = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string d = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();




                PRE.Customer.frmRoutAdd frm1 = new PRE.Customer.frmRoutAdd(shiftid, username, a, b, c, d);

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
