using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_.PRE.PURCHASE
{//updated
    public partial class PURCHASE : Form
    {
        private int id;
        public int invoice_id;
        private int supplier_id;
        private double totel;
        private double profit;
        private double discount_percentage;
        private double discount;
        private double sub_totel;
        private double vat;
        private double additional_charge;
        private double invoice_net_totel;
        private long shift_id;
        private int user_id;
        private DateTime adddate;
        private int payment_method_id;
        private int cheque_no;
        private string paid_statues;
        private string invoice_statues;
        private DateTime purchase_date;


        BUSS.purchase purchase;
        DAT.NewDataAccessLayer Ndal = new DAT.NewDataAccessLayer();
        POS_.function_ fun = new POS_.function_();
        DataTable dt;
        BUSS.additem additem;

        public PURCHASE()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            try
            {
                purchase = new BUSS.purchase();
                //purchase.BindpurchaseDetails(dataGridView1);
            }
            catch { }

                btn_save.Text = "Save";
               
       }

        private bool Send_Data()
        {
           
                this.purchase = new BUSS.purchase(id, invoice_id, supplier_id, totel, profit, discount_percentage, discount, sub_totel, vat, additional_charge, invoice_net_totel, shift_id, user_id, adddate, payment_method_id, cheque_no,invoice_statues,paid_statues,purchase_date);
                if (id == 0)
                {
                    return purchase.Savepurchase();
                }

                else
                {

                    return purchase.Editpurchase();
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
                purchase = new BUSS.purchase(id);
                flag2 = purchase.Deletepurchase();
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation()) {
                    this.Start_Process(false);

                    System.Threading.Thread.Sleep(250);
                    PRE.PURCHASE.PURCHASE_SUMMARY frm = new PRE.PURCHASE.PURCHASE_SUMMARY();
                    frm.invoice_idtxt.Text = Convert.ToString(supplier_idtxt.SelectedValue.ToString());
                    frm.id = Convert.ToInt32(invoice_idtxt.Text);

                    frm.label1.Text = "Supplier : "+supplier_idtxt.Text;
                    frm.label2.Text = "Invoice Net Total : Rs. " + invoice_net_toteltxt.Text;

                    this.Hide();

                    frm.Show();
                }
                

            }
            catch { }
        }

      


        public bool Validation()
        {


            if (string.IsNullOrEmpty(this.invoice_idtxt.Text.Trim()))
            { fun.validationMessge("Please Enter invoice_id"); this.invoice_idtxt.Focus(); return false; }
            if (string.IsNullOrEmpty(this.supplier_idtxt.Text.Trim()))
            { fun.validationMessge("Please Enter supplier_id"); this.supplier_idtxt.Focus(); return false; }
            if (string.IsNullOrEmpty(this.toteltxt.Text.Trim()))
            { fun.validationMessge("Please Enter totel"); this.toteltxt.Focus(); return false; }
            if (string.IsNullOrEmpty(this.profittxt.Text.Trim()))
            { fun.validationMessge("Please Enter profit"); this.profittxt.Focus(); return false; }
            if (string.IsNullOrEmpty(this.discount_percentagetxt.Text.Trim()))
            { fun.validationMessge("Please Enter discount_percentage"); this.discount_percentagetxt.Focus(); return false; }
            if (string.IsNullOrEmpty(this.discounttxt.Text.Trim()))
            { fun.validationMessge("Please Enter discount"); this.discounttxt.Focus(); return false; }
            if (string.IsNullOrEmpty(this.sub_toteltxt.Text.Trim()))
            { fun.validationMessge("Please Enter sub_totel"); this.sub_toteltxt.Focus(); return false; }
            if (string.IsNullOrEmpty(this.vattxt.Text.Trim()))
            { fun.validationMessge("Please Enter vat"); this.vattxt.Focus(); return false; }
            if (string.IsNullOrEmpty(this.additional_chargetxt.Text.Trim()))
            { fun.validationMessge("Please Enter additional_charge"); this.additional_chargetxt.Focus(); return false; }
            if (string.IsNullOrEmpty(this.invoice_net_toteltxt.Text.Trim()))
            { fun.validationMessge("Please Enter invoice_net_totel"); this.invoice_net_toteltxt.Focus(); return false; }
            //if (string.IsNullOrEmpty(this.user_idtxt.Text.Trim()))
            //{ fun.validationMessge("Please Enter user_id"); this.user_idtxt.Focus(); return false; }

            else
            {
                if (string.IsNullOrEmpty(idtxt.Text.Trim())) { this.id = 0; }
                else { this.id = Convert.ToInt32(this.idtxt.Text); }

                this.invoice_id = Convert.ToInt32(this.invoice_idtxt.Text);
                this.supplier_id = Convert.ToInt32(supplier_idtxt.SelectedValue.ToString());
                totel = Convert.ToDouble(toteltxt.Text);
                profit = Convert.ToDouble(profittxt.Text);
                discount_percentage = Convert.ToDouble(discount_percentagetxt.Text);
                discount = Convert.ToDouble(discounttxt.Text);
                sub_totel = Convert.ToDouble(sub_toteltxt.Text);
                vat = Convert.ToDouble(vattxt.Text);
                additional_charge = Convert.ToDouble(additional_chargetxt.Text);
                invoice_net_totel = Convert.ToDouble(invoice_net_toteltxt.Text);
                paid_statues = "0";
                invoice_statues = "Complete";
                purchase_date = DateTime.Now;
                this.shift_id = 0;
                //this.user_id = Convert.ToInt32(this.user_idtxt.Text);
                adddate = DateTime.Now;
                //adddate = DateTime.Parse(adddatetxt.Text);
                //this.payment_method_id = Convert.ToInt32(this.payment_method_idtxt.Text);
                //this.cheque_no = Convert.ToInt32(this.cheque_notxt.Text);
            }
            return true;
        }

        private void PURCHASE_Load(object sender, EventArgs e)
        {

            try
            {
                //purchase = new BUSS.purchase();
                //purchase.BindpurchaseDetails(dataGridView1);
                Bind_Data();
            }
            catch { }
        }

        private void additem_btn(object sender, EventArgs e)
        {

        }

        private void additem_btn_Click(object sender, EventArgs e)
        {

        }

        private void additm_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.invoice_idtxt.Text.Trim()))
            { fun.validationMessge("Please Enter invoice_id"); this.invoice_idtxt.Focus(); return; }
            if (string.IsNullOrEmpty(this.supplier_idtxt.Text.Trim()))
            { fun.validationMessge("Please Enter supplier_id"); this.supplier_idtxt.Focus(); return; }

            else
            {
                try
                {
                    //Send datas to add item form
                    PRE.PURCHASE.ADDITEM frm = new PRE.PURCHASE.ADDITEM();
                    frm.userid = Convert.ToInt32(supplier_idtxt.SelectedValue.ToString());
                    frm.invoiceid = Convert.ToString(invoice_idtxt.Text);
                    invoice_idtxt.Enabled = false;
                    supplier_idtxt.Enabled = false;
                    frm.ShowDialog();

                    //refresh gridview with invoice id
                    System.Threading.Thread.Sleep(250);
                    invoice_id = Convert.ToInt32(invoice_idtxt.Text.Trim());
                    purchase = new BUSS.purchase(invoice_id);
                    purchase.BindinvoiceDetailSearch(dataGridView1);

                    if (dataGridView1.SelectedRows.Count >= 1)
                    { dataGridView1.SelectedRows[0].Selected = false; }

                    //send gridview totels to textboxes
                    double total = 0;
                    //double sub_totel = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        total = (total + double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()));
                        sub_totel = (sub_totel + double.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString()));
                    }
                    toteltxt.Text = Convert.ToString(total);
                    sub_toteltxt.Text = Convert.ToString(sub_totel);

                }
                catch { }
            }
        }

       
        private void invoice_idtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                invoice_id = Convert.ToInt32(invoice_idtxt.Text.Trim());
                purchase = new BUSS.purchase(invoice_id);
                purchase.BindinvoiceDetailSearch(dataGridView1);

                if (dataGridView1.SelectedRows.Count >= 1)
                { dataGridView1.SelectedRows[0].Selected = false; }

                //send gridview totels to textboxes
                double total = 0;
                double prof = 0;
                double sub_totel2 = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    total = (total + double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()));
                    sub_totel2 = (sub_totel2 + double.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString()));
                    prof = (prof + double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()));
                }
                toteltxt.Text = Convert.ToString(total);
                sub_toteltxt.Text = Convert.ToString(sub_totel2);
                profittxt.Text = Convert.ToString(prof);
                sub_totel = sub_totel2;
            }
            catch (Exception ) {}
           
               
             
        }


        private void Bind_Data()
        {
            try
            {
                this.supplier_idtxt.DataSource = new BUSS.purchase().purchasebinfcombo();
                this.supplier_idtxt.ValueMember = "id";
                this.supplier_idtxt.DisplayMember = "name";

            }
            catch
            {

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void toteltxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void profittxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void discounttxt_TextChanged(object sender, EventArgs e)
        {

            try
            {
                sub_toteltxt.Text = Convert.ToString(Convert.ToDecimal(sub_totel) - Convert.ToDecimal(discounttxt.Text));

            }
            catch { sub_toteltxt.Text = "0"; }
        //    try
        //    {
        //        discounttxt.Text = Convert.ToString(Convert.ToDecimal(discount_percentagetxt.Text) - Convert.ToDecimal(toteltxt.Text));

        //    }
        //    catch { discounttxt.Text = "0"; }
        }

        private void discount_percentagetxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                discounttxt.Text = Convert.ToString(( Convert.ToDecimal(discount_percentagetxt.Text) * Convert.ToDecimal(toteltxt.Text) ) / 100 );
                
            }
            catch { discounttxt.Text = "0"; }
        }

        private void vattxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(additional_chargetxt.Text.Trim())) { this.additional_chargetxt.Text = "0"; }
                invoice_net_toteltxt.Text = Convert.ToString(Convert.ToDecimal(vattxt.Text) + Convert.ToDecimal(additional_chargetxt.Text) + Convert.ToDecimal(sub_toteltxt.Text));
            }
            catch { invoice_net_toteltxt.Text = "0"; }
        }

        private void additional_chargetxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(vattxt.Text.Trim())) { this.vattxt.Text = "0"; }
                invoice_net_toteltxt.Text = Convert.ToString(Convert.ToDecimal(vattxt.Text) + Convert.ToDecimal(additional_chargetxt.Text) + Convert.ToDecimal(sub_toteltxt.Text));
            }
            catch { invoice_net_toteltxt.Text = "0"; }
        }

        private void supplier_idtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //this.id = Convert.ToInt32(dataGridView1.SelectedRows[1].Cells[0].Value.ToString());
                //this.additem = new BUSS.additem(this.id);
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    this.purchase = new BUSS.purchase(id);
                    purchase.Deletepurchase();
                }
            }
            catch ( Exception ex) { MessageBox.Show(ex.Message);}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
