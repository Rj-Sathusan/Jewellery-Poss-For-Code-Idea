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
    class sales_payment:DAT.NewDataAccessLayer
    {
         private int id;
        private int customer_id;
        private double paid_amount;
        private string payment_method;
        private string discription;

//Start---------------Getter/setter-----------------------------


        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int CUSTOMER_ID
        {
            get { return this.customer_id; }
            set { this.customer_id = value; }
        }
        public double PAID_AMOUNT
        {
            get { return this.paid_amount; }
            set { this.paid_amount = value; }
        }
        public string PAYMENT_METHOD
        {
            get { return this.payment_method; }
            set { this.payment_method = value; }
        }
        public string DISCRIPTION
        {
            get { return this.discription; }
            set { this.discription = value; }
        }

//END---------------Getter/setter-----------------------------

//Start---------------------SAVE------------------Proceture---------------

        public bool Savesales_payment()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[5];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                param[1] = new MySqlParameter("@customer_id0", MySqlDbType.Int32);
                param[1].Value = customer_id;
                param[2] = new MySqlParameter("@paid_amount0", MySqlDbType.Double);
                param[2].Value = paid_amount;
                param[3] = new MySqlParameter("@payment_method0", MySqlDbType.VarChar, 60);
                param[3].Value = payment_method;
                param[4] = new MySqlParameter("@discription0", MySqlDbType.VarChar, 60);
                param[4].Value = discription;
                     if (OpenConnection())
                {
                    if (ExecuteCommand(" sales_paymentSave", param))
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

        public bool Editsales_payment()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[5];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                param[1] = new MySqlParameter("@customer_id0", MySqlDbType.Int32);
                param[1].Value = customer_id;
                param[2] = new MySqlParameter("@paid_amount0", MySqlDbType.Double);
                param[2].Value = paid_amount;
                param[3] = new MySqlParameter("@payment_method0", MySqlDbType.VarChar, 60);
                param[3].Value = payment_method;
                param[4] = new MySqlParameter("@discription0", MySqlDbType.VarChar, 60);
                param[4].Value = discription;
                     if (OpenConnection())
                {
                    if (ExecuteCommand(" sales_paymentEdit", param))
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

        public bool Deletesales_payment()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[1];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                     if (OpenConnection())
                {
                    if (ExecuteCommand(" sales_paymentDelete", param))
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

        // ============================================ Get all details in Shop ==============================//////

        public DataTable Getsales_payment()
        {
            comtable = null;


            if (OpenConnection())
            {
                comtable = SelectData("sales_paymentSelect", null);
                sqlconnection.Close();
            }

            return comtable;
        }
        public void Bindsales_paymentDetails(DataGridView dgv)
        {

            BindGrid(dgv, Getsales_payment());
        }

//Start-----------------constructer-------------------------------

        public sales_payment(int id,int customer_id,double paid_amount,string payment_method,string discription)
        {
            this.id = id;
            this.customer_id = customer_id;
            this.paid_amount = paid_amount;
            this.payment_method = payment_method;
            this.discription = discription;


//End-----------------------constructer-------------------------------
}

   //Start-----------------constructer-------------------------------

        public sales_payment(int id)
        {
            this.id = id;

      //End-----------------------constructer-------------------------------
        }

    }
}
