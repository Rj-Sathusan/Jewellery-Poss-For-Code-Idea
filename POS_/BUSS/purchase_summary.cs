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
    class purchase_summary:DAT.NewDataAccessLayer
    {

         private int id;
        private int invoice_no;
        private double amount;
        private DateTime collection_date;
        private int pay_method;
        private string cheque_no;
        private DateTime cheque_date;
        private string bank;
        private string note;
        private int is_cancel;
        private DateTime add_date;
        private int user_id;
        private long shift_id;

//Start---------------Getter/setter-----------------------------


        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int INVOICE_NO
        {
            get { return this.invoice_no; }
            set { this.invoice_no = value; }
        }
        public double AMOUNT
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
        public DateTime COLLECTION_DATE
        {
            get { return this.collection_date; }
            set { this.collection_date = value; }
        }
        public int PAY_METHOD
        {
            get { return this.pay_method; }
            set { this.pay_method = value; }
        }
        public string CHEQUE_NO
        {
            get { return this.cheque_no; }
            set { this.cheque_no = value; }
        }
        public DateTime CHEQUE_DATE
        {
            get { return this.cheque_date; }
            set { this.cheque_date = value; }
        }
        public string BANK
        {
            get { return this.bank; }
            set { this.bank = value; }
        }
        public string NOTE
        {
            get { return this.note; }
            set { this.note = value; }
        }
        public int IS_CANCEL
        {
            get { return this.is_cancel; }
            set { this.is_cancel = value; }
        }
        public DateTime ADD_DATE
        {
            get { return this.add_date; }
            set { this.add_date = value; }
        }
        public int USER_ID
        {
            get { return this.user_id; }
            set { this.user_id = value; }
        }
        public long SHIFT_ID
        {
            get { return this.shift_id; }
            set { this.shift_id = value; }
        }

//END---------------Getter/setter-----------------------------

//Start---------------------SAVE------------------Proceture---------------

        public bool Savepurchase_summary()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[13];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                param[1] = new MySqlParameter("@invoice_no0", MySqlDbType.Int32);
                param[1].Value = invoice_no;
                param[2] = new MySqlParameter("@amount0", MySqlDbType.Double);
                param[2].Value = amount;
                param[3] = new MySqlParameter("@collection_date0", MySqlDbType.DateTime);
                param[3].Value = collection_date;
                param[4] = new MySqlParameter("@pay_method0", MySqlDbType.Int32);
                param[4].Value = pay_method;
                param[5] = new MySqlParameter("@cheque_no0", MySqlDbType.VarChar, 60);
                param[5].Value = cheque_no;
                param[6] = new MySqlParameter("@cheque_date0", MySqlDbType.DateTime);
                param[6].Value = cheque_date;
                param[7] = new MySqlParameter("@bank0", MySqlDbType.VarChar, 60);
                param[7].Value = bank;
                param[8] = new MySqlParameter("@note0", MySqlDbType.VarChar, 60);
                param[8].Value = note;
                param[9] = new MySqlParameter("@is_cancel0", MySqlDbType.Int32);
                param[9].Value = is_cancel;
                param[10] = new MySqlParameter("@add_date0", MySqlDbType.DateTime);
                param[10].Value = add_date;
                param[11] = new MySqlParameter("@user_id0", MySqlDbType.Int32);
                param[11].Value = user_id;
                param[12] = new MySqlParameter("@shift_id0", MySqlDbType.Int64);
                param[12].Value = shift_id;
                     if (OpenConnection())
                {
                    if (ExecuteCommand(" purchase_summarySave", param))
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

        public bool Editpurchase_summary()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[13];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                param[1] = new MySqlParameter("@invoice_no0", MySqlDbType.Int32);
                param[1].Value = invoice_no;
                param[2] = new MySqlParameter("@amount0", MySqlDbType.Double);
                param[2].Value = amount;
                param[3] = new MySqlParameter("@collection_date0", MySqlDbType.DateTime);
                param[3].Value = collection_date;
                param[4] = new MySqlParameter("@pay_method0", MySqlDbType.Int32);
                param[4].Value = pay_method;
                param[5] = new MySqlParameter("@cheque_no0", MySqlDbType.VarChar, 60);
                param[5].Value = cheque_no;
                param[6] = new MySqlParameter("@cheque_date0", MySqlDbType.DateTime);
                param[6].Value = cheque_date;
                param[7] = new MySqlParameter("@bank0", MySqlDbType.VarChar, 60);
                param[7].Value = bank;
                param[8] = new MySqlParameter("@note0", MySqlDbType.VarChar, 60);
                param[8].Value = note;
                param[9] = new MySqlParameter("@is_cancel0", MySqlDbType.Int32);
                param[9].Value = is_cancel;
                param[10] = new MySqlParameter("@add_date0", MySqlDbType.DateTime);
                param[10].Value = add_date;
                param[11] = new MySqlParameter("@user_id0", MySqlDbType.Int32);
                param[11].Value = user_id;
                param[12] = new MySqlParameter("@shift_id0", MySqlDbType.Int64);
                param[12].Value = shift_id;
                     if (OpenConnection())
                {
                    if (ExecuteCommand(" purchase_summaryEdit", param))
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

        public bool Deletepurchase_summary()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[1];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                     if (OpenConnection())
                {
                    if (ExecuteCommand(" purchase_summaryDelete", param))
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

        public DataTable Getpurchase_summary()
        {
            DataTable dt = new DataTable();

            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@invoiceno0", MySqlDbType.VarChar, 60);
            param[0].Value = id;

            if (OpenConnection())
            {
                dt = SelectData("purchase_paymentSelect", param);
                CloseConnection();
            }

            return dt;
        }
        public void Bindpurchase_summaryDetails(DataGridView dgv)
        {

            BindGrid(dgv, Getpurchase_summary());
        }

//Start-----------------constructer-------------------------------

        public purchase_summary(int id,int invoice_no,double amount,DateTime collection_date,int pay_method,string cheque_no,DateTime cheque_date,string bank,string note,int is_cancel,DateTime add_date,int user_id,long shift_id)
        {
            this.id = id;
            this.invoice_no = invoice_no;
            this.amount = amount;
            this.collection_date = collection_date;
            this.pay_method = pay_method;
            this.cheque_no = cheque_no;
            this.cheque_date = cheque_date;
            this.bank = bank;
            this.note = note;
            this.is_cancel = is_cancel;
            this.add_date = add_date;
            this.user_id = user_id;
            this.shift_id = shift_id;


//End-----------------------constructer-------------------------------
}

        //Start-----------------constructer-------------------------------

        public purchase_summary(int id)
        {
            this.id = id;
            //End-----------------------constructer-------------------------------
        }

        public purchase_summary()
        {
            // TODO: Complete member initialization
        }

        public DataTable purchasebinfcombo()
        {
           

            comtable = null;
            if (OpenConnection())
            {
                comtable = SelectData("purchasesummaryBindinCombo", null);
                sqlconnection.Close();
            }
            return comtable;
        }
    }
}
