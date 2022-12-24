
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
    class payment : DAT.NewDataAccessLayer
    {
        private int id;
        private string payment_method;
        private DateTime date;

        //Start---------------Getter/setter-----------------------------


        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string PAYMENT_METHOD
        {
            get { return this.payment_method; }
            set { this.payment_method = value; }
        }
        public DateTime DATE
        {
            get { return this.date; }
            set { this.date = value; }
        }

        //END---------------Getter/setter-----------------------------


        //Start---------------------SAVE------------------Proceture---------------

        public bool Savepayment()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[3];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                param[1] = new MySqlParameter("@payment_method0", MySqlDbType.VarChar, 60);
                param[1].Value = payment_method;
                param[2] = new MySqlParameter("@date0", MySqlDbType.DateTime);
                param[2].Value = date;
                if (OpenConnection())
                {
                    if (ExecuteCommand("paymentSave", param))
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

        public bool Editpayment()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[2];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                param[1] = new MySqlParameter("@payment_method0", MySqlDbType.VarChar, 60);
                param[1].Value = payment_method;
                if (OpenConnection())
                {
                    if (ExecuteCommand(" paymentEdit", param))
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

        public bool Deletepayment()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[1];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                if (OpenConnection())
                {
                    if (ExecuteCommand(" paymentDelete", param))
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


        //Start-----------------constructer-------------------------------

        public payment(int id, string payment_method, DateTime date)
        {
            this.id = id;
            this.payment_method = payment_method;
            this.date = date;


            //End-----------------------constructer-------------------------------
        }

        //Start-----------------constructer-------------------------------

        public payment(int id)
        {
            this.id = id;

            //End-----------------------constructer-------------------------------
        }

        public payment()
        {
            // TODO: Complete member initialization
        }


        public DataTable Getpayment()
        {
            comtable = null;


            if (OpenConnection())
            {
                comtable = SelectData("paymentSelect", null);
                sqlconnection.Close();
            }

            return comtable;
        }
        public void BindPaymentDetails(DataGridView dgv)
        {

            BindGrid(dgv, Getpayment());
        }
    }
}
