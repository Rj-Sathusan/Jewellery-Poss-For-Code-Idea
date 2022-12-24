using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.IO;
using System.Dynamic;
using System.Windows;
//using MySql.Data.MySqlClient;
using System.Threading;



namespace POS_
{
    class function
    {
        public double  totalamount { get; set; }
         //string i = @"database='sysfor_retail-1'; datasource='192.168.1.11'; username='root'; password='12345'";

        //string i = @"server=127.0.0.1;user id=root;database=poscop ";
      // string i = @"database='pos1107_'; datasource='posuser@1107'; username='posuser1107'; password='posuser@1107'";
 
        public string caranceformat(double amount)
        {
            return String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:N2}", amount);

        }
        public void godFocusOnButton(Button but)
        {
            but.BackColor = Color.LightGreen;

        }

        public void lostFocusOnButton(Button but)
        {
            but.BackColor = SystemColors.Control;

        }
        public void InputNumberOnley(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }


        public double doubleformat(string amount)
        {
            return double.Parse(amount, System.Globalization.NumberStyles.Currency);
        }
        public void BindGridButton(DataGridView dgv, DataTable table)
        {
            // GetValue(x)
            dgv.RowCount = table.Rows.Count;
            for (Int32 i = 0; i < dgv.RowCount; i++)
            {
                for (Int32 x = 0; x < dgv.ColumnCount - 1; x++)
                {
                    dgv[x, i].Value = table.Rows[i].ItemArray[x].ToString().Trim();
                }
            }



        }


        public void BindGridBranch(DataGridView dgv, DataTable table)
        {
            // GetValue(x)
            dgv.RowCount = table.Rows.Count;
            for (Int32 i = 0; i < dgv.RowCount; i++)
            {
                for (Int32 x = 0; x < dgv.ColumnCount - 7; x++)
                {
                    dgv[x, i].Value = table.Rows[i].ItemArray[x].ToString().Trim();
                }
            }



        }

        public void BindGridBranchforsaleupdate(DataGridView dgv, DataTable table)
        {
            // GetValue(x)
            dgv.RowCount = table.Rows.Count;
            for (Int32 i = 0; i < dgv.RowCount; i++)
            {
                for (Int32 x = 0; x < dgv.ColumnCount - 4; x++)
                {
                    dgv[x, i].Value = table.Rows[i].ItemArray[x].ToString().Trim();
                }
            }



        }


        public void BindGridBranch1(DataGridView dgv, DataTable table)
        {
            // GetValue(x)
            dgv.RowCount = table.Rows.Count;
            for (Int32 i = 0; i < dgv.RowCount; i++)
            {
                for (Int32 x = 0; x < dgv.ColumnCount - 3; x++)
                {
                    dgv[x, i].Value = table.Rows[i].ItemArray[x].ToString().Trim();
                }
            }



        }
        public void BindGridButton2(DataGridView dgv, DataTable table)
        {
            // GetValue(x)
            dgv.RowCount = table.Rows.Count;
            for (Int32 i = 0; i < dgv.RowCount; i++)
            {
                for (Int32 x = 0; x < dgv.ColumnCount - 2; x++)
                {
                    dgv[x, i].Value = table.Rows[i].ItemArray[x].ToString().Trim();
                }
            }



        }

        public double CalculateAmountByUsingDatagridview(DataGridView dgv, Int32 columindes)
        {
            totalamount = 0;
            for (Int32 a = 0; dgv.Rows.Count > a; a++)
            {
                totalamount += doubleformat(dgv.Rows[a].Cells[columindes].Value.ToString());
            }
            return totalamount;
        }

        public double CalculateAmountByUsingDatagridviewCondition(DataGridView dgv, Int32 columindes,Int32 condi,string conditionValue)
        {
            totalamount = 0;
            for (Int32 a = 0; dgv.Rows.Count > a; a++)
            {
                if (dgv.Rows[a].Cells[condi].Value.ToString() != conditionValue)
                {
                    totalamount += doubleformat(dgv.Rows[a].Cells[columindes].Value.ToString());
                }
            }
            return totalamount;
        }
 

        public void datagridviewcolor(DataGridView dgv) { dgv.DefaultCellStyle.BackColor = Color.LightGray; dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White; }
      
   

        public void TextClear(TextBox[] Boxes)
        {
            try
            {
                for (Int32 i = 0; i < Boxes.Length; i++)
                {
                    Boxes[i].Text = string.Empty;
                }
            }
            catch (Exception) { }
        }

  

        public void BindGrid(DataGridView dgv, DataTable table)
        {
           // GetValue(x)
            dgv.RowCount = table.Rows.Count;
            for (Int32 i = 0; i < dgv.RowCount; i++)
            {
                for (Int32 x = 0; x < dgv.ColumnCount; x++)
                {
                    dgv[x, i].Value = table.Rows[i].ItemArray[x].ToString().Trim();
                }
            }



        }


      

       
     

        public void LableTransferant(Label[] lebel, PictureBox picBox)
        {
            for (Int32 i = 0; i < lebel.Length; i++)
            {
                lebel[i].Parent = picBox;
                lebel[i].BackColor = Color.Transparent;
            }
        }

        public void timeDisplay(Label lab)
        {
            string s, m;
            Int32 x = DateTime.Now.Second;
            Int32 y = DateTime.Now.Minute;
            Int32 w = DateTime.Now.Hour;

            if (x < 10)
            {
                s = "0" + x;

            }
            else { s = x.ToString(); }

            if (y < 10)
            {
                m = "0" + y;

            }
            else
            {
                m = y.ToString();

                lab.Text = w.ToString() + ":" + m + ":" + s;


            }


        }


     

        public void checkString(KeyPressEventArgs e, TextBox txt) {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 46 || e.KeyChar == 8 || e.KeyChar == 40)//true or false
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        public void checkStringwithsub(KeyPressEventArgs e, TextBox txt)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 46 || e.KeyChar == 8 ||e.KeyChar==45)//true or false
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public void checknumber(KeyPressEventArgs e, TextBox txt)
        {

            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 46 || e.KeyChar == 8 || e.KeyChar == 42)//true or false
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        
        
        }
        public void AddMessage() { MessageBox.Show("Data Saved Successfuly !!!","Add Message",MessageBoxButtons.OK,MessageBoxIcon.Information); }
        public void EditMessge() { MessageBox.Show("Data Updated Successfuly !!!", "Update Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        public void DeleteMessge() { MessageBox.Show("Data Deleted Successfuly !!!", "Delete Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        public void validationMessge(string validate) { MessageBox.Show(validate, "Warnig Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        public void listboxclear(ListBox listname) {
            for (Int32 i = 0; i < listname.Items.Count; i++) { listname.Items.RemoveAt(i); i--; }
        }
        public void comboboxclear(ComboBox comname) { for (Int32 i = 0; i < comname.Items.Count; i++) { comname.Items.RemoveAt(i); i--; } }


        public bool ShowMessage(string message, string Con)
        {
            if (Con != "Confirm")
            {
                if (Con == "Warning")
                {
                    MessageBox.Show(message, BUSS.Config.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Con == "Information")
                {
                    MessageBox.Show(message, BUSS.Config.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (Con == "Error")
                {
                    MessageBox.Show(message, BUSS.Config.ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else if (MessageBox.Show(message, BUSS.Config.ApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
    
    }

    
}
