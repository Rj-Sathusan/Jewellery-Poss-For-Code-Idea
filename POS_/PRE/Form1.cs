using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_
{
    public partial class Form1 : Form
    {
        string shiffid, username;
        public Form1(string sid,string uname)
        {
            InitializeComponent();
            shiffid = sid; username = uname;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public bool FormOpenFunction(string formtxt)
        {

            bool isopen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text.Equals(formtxt))
                {
                    isopen = true;
                    f.Focus();
                    break;
                }
            }
            return isopen;
           
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //if (!Config.AddBrandOpened)
            //{
            //    PRE.Brand.frmAddBrand frm = new PRE.Brand.frmAddBrand();
            //    frm.MdiParent = this;
            //    frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();


            //}

        }

        private void listOfBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!Config.ListOfBrandOpened)
            //{
            //    PRE.Brand.frmListofBrand frm = new PRE.Brand.frmListofBrand();
            //    frm.MdiParent = this;
            //    frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();

            //}
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!BUSS.FormOpenClass.AddCategoryOpened)
            {
                PRE.NewCategory.frmAddCategory frm = new PRE.NewCategory.frmAddCategory(shiffid, username);

                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
                frm.BringToFront();
            }
        }

        private void listOfCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!BUSS.FormOpenClass.ListOfCategoryOpened)
            {
                PRE.NewCategory.frmListofCategory frm = new PRE.NewCategory.frmListofCategory(shiffid, username);

                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();

            }
        }

        private void listOfProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!Config.ListOfProductOpened)
            //{
            //    PRE.Items.frmNewListofPoduct frm = new PRE.Items.frmNewListofPoduct();
            //    frm.MdiParent = this;
            //    frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();

            //}
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!Config.AddProductOpened)
            //{
            //    PRE.Items.frmAddProduct frm = new PRE.Items.frmAddProduct();
            //    frm.MdiParent = this;
            //    frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();


            //}
        }

        private void listOfStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!Config.ListOfStaffOpened)
            //{
            //    PRE.Staff.frmLisofStaff frm = new PRE.Staff.frmLisofStaff();
            //    frm.MdiParent = this;
            //    frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();

            //}
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!Config.AddStaffOpened)
            //{
            //    PRE.Staff.frmStaff frm = new PRE.Staff.frmStaff();
            //    frm.MdiParent = this;
            //    frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();


            //}
            if (!BUSS.FormOpenClass.ListOfCategoryOpened)
            {
                PRE.USER.USER frm = new PRE.USER.USER();

                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();

            }
        }

        private void listOfRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!BUSS.FormOpenClass.LisfOfRootOpened)
            {
            PRE.Customer.frmListofRoute frm = new PRE.Customer.frmListofRoute(shiffid, username);

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();

            }
        }

        private void listOfCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //if (!Config.ListOfRetailerOpened)
            //{
            //    PRE.Customer.ListofCustomer frm = new PRE.Customer.ListofCustomer();
            //    frm.MdiParent = this;
            //    frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();

            //}
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!Config.AddRetailerOpened)
            //{
            //    PRE.Customer.frmCustomer frm = new PRE.Customer.frmCustomer();
            //    frm.MdiParent = this;
            //    frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();

            //}
            PRE.Customer.CUSTOMER frm = new PRE.Customer.CUSTOMER();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void routeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!Config.AddRootOpened)
            //{
            if (!BUSS.FormOpenClass.AddRootOpened)
            {
                PRE.Customer.frmRoutAdd frm = new PRE.Customer.frmRoutAdd(shiffid, username);

                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
                frm.BringToFront();
            }

            //}
        }

        private void listOfCommanDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!Config.ListOfDiscountSchemeOpened)
            //{
            //    PRE.DIS.frmListOfCommanDiscount frm = new PRE.DIS.frmListOfCommanDiscount();
            //    frm.MdiParent = this;
            //    frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();

            //}
        }

        private void commonDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!Config.AddCommonDiscountSchemeOpened)
            //{
            //    PRE.DIS.frmCommanDiscountAdd frm = new PRE.DIS.frmCommanDiscountAdd();
            //    frm.MdiParent = this;
            //    frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();

            //}
        }

        private void listOfSpecialDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!Config.LisfOfSpecialDiscountpened)
            //{
            //    PRE.DIS.frmNewListOfSpecialDiscount frm = new PRE.DIS.frmNewListOfSpecialDiscount();
            //    frm.MdiParent = this;
            //    frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();

            //}
        }

        private void specialDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!Config.AddSpecialDiscountFreeOpened)
            //{
            //    PRE.DIS.frmSpecialDiscountAdd frm = new PRE.DIS.frmSpecialDiscountAdd();
            //    frm.MdiParent = this;
            //    frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();

            //}
        }

        private void createInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!Config.InvoiceOpened)
            //{
            //    PRE.Invoices.frmInvoiceCreate frm = new PRE.Invoices.frmInvoiceCreate();
            //    frm.MdiParent = this;
            //    frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();

            //}

        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRE.SUPPLIER.SUPPLIER frm = new PRE.SUPPLIER.SUPPLIER();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRE.PURCHASE.PURCHASE frm = new PRE.PURCHASE.PURCHASE();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void paymentMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRE.PAYMENT.PAYMENT frm = new PRE.PAYMENT.PAYMENT();

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
