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
{
    public partial class ADDITEM : Form
    {
        DAT.NewDataAccessLayer Ndal = new DAT.NewDataAccessLayer();
        BUSS.additem additem = new BUSS.additem();
        private int id;
        public string invoiceid;
        private int itemid;
        private double unitprice;
        private decimal propercent;
        private decimal quantity;
        private double total;
        
        private double profit;
        private double linetotal;
        private DateTime add_date;
        public int userid;
        private long shiftid;

        public ADDITEM()
        {
            InitializeComponent();
        }


        private bool Validation()
        {

            this.shiftid = 0;
            if (string.IsNullOrEmpty(this.idtxt.Text.Trim())) 
            { this.id = 0; } 
            else { this.id = Convert.ToInt32(this.idtxt.Text); }

            //if (string.IsNullOrEmpty(this.cmb_itemname.Text.Trim()))
            //{ this.Ndal.ShowMessage("Please Select the Item Name !!!!", "Error"); cmb_itemname.Focus(); return false; }
            //else { this.cmb_itemname = this.cmb_itemname.Text.Trim();}

            if (string.IsNullOrEmpty(this.txt_unitprice.Text.Trim()))
            { this.Ndal.ShowMessage("Please Enter the Unit Price !!!!", "Error"); txt_unitprice.Focus(); return false; }
            else { this.unitprice = Convert.ToDouble(txt_unitprice.Text.Trim()); }

            if (string.IsNullOrEmpty(this.txt_quantity.Text.Trim()))
            { this.Ndal.ShowMessage("Please Enter the Quantity !!!!", "Error"); txt_quantity.Focus(); return false; }
            else { this.quantity = Convert.ToDecimal(txt_quantity.Text.Trim()); }

            if (string.IsNullOrEmpty(this.txt_total.Text.Trim()))
            { this.Ndal.ShowMessage("Please Enter the Total !!!!", "Error"); txt_total.Focus(); return false; }
            else { this.total = Convert.ToDouble(txt_total.Text.Trim()); }

            if (string.IsNullOrEmpty(this.txtpropercent.Text.Trim()))
            { this.Ndal.ShowMessage("Please Enter the Profit Percentage !!!!", "Error"); txtpropercent.Focus(); return false; }
            else { this.propercent = Convert.ToDecimal(txtpropercent.Text.Trim()); }

            if (string.IsNullOrEmpty(this.txt_profit.Text.Trim()))
            { this.Ndal.ShowMessage("Please Enter the Profit !!!!", "Error"); txt_profit.Focus(); return false; }
            else { this.profit = Convert.ToDouble(txt_profit.Text.Trim()); }

            if (string.IsNullOrEmpty(this.txt_linetotal.Text.Trim()))
            { this.Ndal.ShowMessage("Please Enter the Profit !!!!", "Error"); txt_linetotal.Focus(); return false; }
            else { this.linetotal = Convert.ToDouble(txt_linetotal.Text.Trim()); }

            if (string.IsNullOrEmpty(this.cmb_itemname.Text.Trim()))
            { this.Ndal.ShowMessage("Please Enter the Profit !!!!", "Error"); cmb_itemname.Focus(); return false; }
            else { this.itemid = Convert.ToInt32(cmb_itemname.SelectedValue.ToString()); }

            add_date = DateTime.Now;
            return true;

        }

        private void ClearData()
        {
            this.txt_unitprice.Clear();
            this.txt_quantity.Clear();
            this.txt_total.Clear();
            this.txtpropercent.Clear();
            this.txt_profit.Clear();
            this.txt_linetotal.Clear();
            this.cmb_itemname.Focus();
        }

        private void ADDITEM_Load_1(object sender, EventArgs e)
        {
            Bind_Data();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private bool Send_Data()
        {
            this.additem = new BUSS.additem(id, invoiceid, itemid, unitprice, propercent, quantity, total, profit, linetotal, add_date, userid,shiftid);
            if (id == 0)
            {
                return additem.Create();
            }
            else
            {
                return additem.Modify();
            }

        }

        private bool Remove_Data()
        {
            bool flag2;
            if (string.IsNullOrEmpty(idtxt.Text.Trim()))
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
                this.id = Convert.ToInt32(this.idtxt.Text);
                this.additem = new BUSS.additem(this.id);
                flag2 = this.additem.Remove();
            }
            return flag2;
        }



        private async void Start_Process(bool is_send)
        {

            Task<bool> task = ((is_send) ? new Task<bool>(new Func<bool>(Send_Data)) : new Task<bool>(new Func<bool>(Remove_Data)));
            task.Start();
            if (await task)
            {
                ClearData();
            }
            else
            {
                try
                {
                    Ndal.ShowMessage(additem.Message, "Error");
                }
                catch
                {
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
              if (Validation()) { this.Start_Process(true); }

                  this.Close();

            }
            catch { }
        }

        private void Bind_Data()
        {
            try
            {
                this.cmb_itemname.DataSource = new BUSS.additem().GetAllItem();
                this.cmb_itemname.ValueMember = "id";
                this.cmb_itemname.DisplayMember = "itemname";

            }
            catch
            {

            }
        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmb_itemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                itemid = Convert.ToInt32(cmb_itemname.SelectedValue.ToString());
                this.additem = new BUSS.additem(itemid);
                this.additem.getcomboitemdetail(txt_unitprice, txtpropercent);
            }
            catch { }
        }

        private void txt_unitprice_TextChanged(object sender, EventArgs e)
        {
            Alltextchanges();
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            Alltextchanges();

        }

        private void txtpropercent_TextChanged(object sender, EventArgs e)
        {
            Alltextchanges();
        }

        private void txt_linetotal_TextChanged(object sender, EventArgs e)
        {

        }

        //All calculation text changes 
        private void Alltextchanges()
        {
            try
            {
                txt_total.Text = Convert.ToString(Convert.ToDecimal(txt_unitprice.Text) * Convert.ToDecimal(txt_quantity.Text));
                txt_profit.Text = Convert.ToString((Convert.ToDecimal(txtpropercent.Text) * Convert.ToDecimal(txt_total.Text)) / 100);
                txt_linetotal.Text = Convert.ToString(Convert.ToDecimal(txt_total.Text) - Convert.ToDecimal(txt_profit.Text));

            }
            catch {txt_profit.Text = "0"; txt_linetotal.Text = "0"; txt_total.Text = "0"; }
        }
    }
}
