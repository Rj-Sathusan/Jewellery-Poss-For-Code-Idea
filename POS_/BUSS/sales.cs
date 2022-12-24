using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;
 using MySql.Data.MySqlClient;
 using System.Windows.Forms;
 using System.Data;

namespace POS_.BUSS
{
     class sales : DAT.NewDataAccessLayer
    {
         private int id;
        private DateTime invoice_date;
        private int customer;
        private string invoice_no;
        private string invoice_type;

//Start---------------Getter/setter-----------------------------


        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public DateTime INVOICE_DATE
        {
            get { return this.invoice_date; }
            set { this.invoice_date = value; }
        }
        public int CUSTOMER
        {
            get { return this.customer; }
            set { this.customer = value; }
        }
        public string INVOICE_NO
        {
            get { return this.invoice_no; }
            set { this.invoice_no = value; }
        }
        public string INVOICE_TYPE
        {
            get { return this.invoice_type; }
            set { this.invoice_type = value; }
        }

//END---------------Getter/setter-----------------------------

//Start---------------------SAVE------------------Proceture---------------

        public bool Savesales()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[5];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                param[1] = new MySqlParameter("@invoice_date0", MySqlDbType.DateTime);
                param[1].Value = invoice_date;
                param[2] = new MySqlParameter("@customer0", MySqlDbType.Int32);
                param[2].Value = customer;
                param[3] = new MySqlParameter("@invoice_no0", MySqlDbType.VarChar, 60);
                param[3].Value = invoice_no;
                param[4] = new MySqlParameter("@invoice_type0", MySqlDbType.VarChar, 60);
                param[4].Value = invoice_type;
                     if (OpenConnection())
                {
                    if (ExecuteCommand(" salesSave", param))
                    {

                        ShowMessage("Data Saved Successfully", "Warning");
                        CloseConnection();
                        param = null;

                        return true;
                    }
                    else
                    {

                        ShowMessage("Duplicate entry", "Error");
                        param = null;
                        return false;
                    }

                }
                else
                {
                    ShowMessage("Server Not Connected", "Error");

                    param = null;
                    return false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }
     

//END-------------------------------SAVE------------------Proceture----------------------
     

//Start---------------------------EDIT----------------Proceture-----------------------

        public bool Editsales()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[5];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                param[1] = new MySqlParameter("@invoice_date0", MySqlDbType.DateTime);
                param[1].Value = invoice_date;
                param[2] = new MySqlParameter("@customer0", MySqlDbType.Int32);
                param[2].Value = customer;
                param[3] = new MySqlParameter("@invoice_no0", MySqlDbType.VarChar, 60);
                param[3].Value = invoice_no;
                param[4] = new MySqlParameter("@invoice_type0", MySqlDbType.VarChar, 60);
                param[4].Value = invoice_type;
                     if (OpenConnection())
                {
                    if (ExecuteCommand(" salesEdit", param))
                    {

                        ShowMessage("Data Edited Successfully", "Warning");
                        CloseConnection();
                        param = null;

                        return true;
                    }
                    else
                    {

                        ShowMessage("Duplicate entry", "Error");
                        param = null;
                        return false;
                    }

                }
                else
                {
                    ShowMessage("Server Not Connected", "Error");

                    param = null;
                    return false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }
     

//END----------------------------------------------EDIT-------------------------Proceture------------
     

//Start-------------------------DELETE----------------------Proceture------------------

        public bool Deletesales()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[1];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                     if (OpenConnection())
                {
                    if (ExecuteCommand(" salesDelete", param))
                    {

                        ShowMessage("Data Deleted Successfully", "Warning");
                        CloseConnection();
                        param = null;

                        return true;
                    }
                    else
                    {

                        ShowMessage("Duplicate entry", "Error");
                        param = null;
                        return false;
                    }

                }
                else
                {
                    ShowMessage("Server Not Connected", "Error");

                    param = null;
                    return false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }
     

//END------------------------------------DELETE--------------------Proceture-------------------
     
        // ============================================ Get all details in sales ==============================//////

        public DataTable Getsales()
        {
            comtable = null;


            if (OpenConnection())
            {
                comtable = SelectData("salesSelect", null);
                sqlconnection.Close();
            }

            return comtable;
        }
        public void BindsalesDetails(DataGridView dgv)
        {

            BindGrid(dgv, Getsales());
        }

//Start-----------------constructer-------------------------------
        public sales(int id)
        {
            this.id = id;
        }

        public sales(int id,DateTime invoice_date,int customer,string invoice_no,string invoice_type)
        {
            this.id = id;
            this.invoice_date = invoice_date;
            this.customer = customer;
            this.invoice_no = invoice_no;
            this.invoice_type = invoice_type;


//End-----------------------constructer-------------------------------        
}

        public sales()
        {
            // TODO: Complete member initialization
        }

    }
}
