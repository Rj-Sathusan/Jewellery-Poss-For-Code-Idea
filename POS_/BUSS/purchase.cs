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
    class purchase:DAT.NewDataAccessLayer
    {
         private int id;
        private int invoice_id;
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
        private string paid_statues;
        private string invoice_statues;
        private DateTime purchase_date;

        //private int payment_method_id;
        //private int cheque_no;

//Start---------------Getter/setter-----------------------------


        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int INVOICE_ID
        {
            get { return this.invoice_id; }
            set { this.invoice_id = value; }
        }
        public int SUPPLIER_ID
        {
            get { return this.supplier_id; }
            set { this.supplier_id = value; }
        }
        public double TOTEL
        {
            get { return this.totel; }
            set { this.totel = value; }
        }
        public double PROFIT
        {
            get { return this.profit; }
            set { this.profit = value; }
        }
        public double DISCOUNT_PERCENTAGE
        {
            get { return this.discount_percentage; }
            set { this.discount_percentage = value; }
        }
        public double DISCOUNT
        {
            get { return this.discount; }
            set { this.discount = value; }
        }
        public double SUB_TOTEL
        {
            get { return this.sub_totel; }
            set { this.sub_totel = value; }
        }
        public double VAT
        {
            get { return this.vat; }
            set { this.vat = value; }
        }
        public double ADDITIONAL_CHARGE
        {
            get { return this.additional_charge; }
            set { this.additional_charge = value; }
        }
        public double INVOICE_NET_TOTEL
        {
            get { return this.invoice_net_totel; }
            set { this.invoice_net_totel = value; }
        }
        public long SHIFT_ID
        {
            get { return this.shift_id; }
            set { this.shift_id = value; }
        }
        public int USER_ID
        {
            get { return this.user_id; }
            set { this.user_id = value; }
        }
        public DateTime PURCHASE_DATE
        {
            get { return this.purchase_date; }
            set { this.purchase_date = value; }
        }
            public string PAID_STATUES
        {
            get { return this.paid_statues; }
            set { this.paid_statues = value; }
        }

            public DateTime ADDDATE
        {
            get { return this.adddate; }
            set { this.adddate = value; }
        }

            public string INVOICE_STATUES
        {
            get { return this.invoice_statues; }
            set { this.invoice_statues = value; }
        }

        //    public DateTime ADDDATE
        //{
        //    get { return this.adddate; }
        //    set { this.adddate = value; }
        //}
        //public int PAYMENT_METHOD_ID
        //{
        //    get { return this.payment_method_id; }
        //    set { this.payment_method_id = value; }
        //}
        //public int CHEQUE_NO
        //{
        //    get { return this.cheque_no; }
        //    set { this.cheque_no = value; }
        //}

         

//END---------------Getter/setter-----------------------------

//Start---------------------SAVE------------------Proceture---------------

        public bool Savepurchase()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[17];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                param[1] = new MySqlParameter("@invoice_id0", MySqlDbType.Int32);
                param[1].Value = invoice_id;
                param[2] = new MySqlParameter("@supplier_id0", MySqlDbType.Int32);
                param[2].Value = supplier_id;
                param[3] = new MySqlParameter("@totel0", MySqlDbType.Double);
                param[3].Value = totel;
                param[4] = new MySqlParameter("@profit0", MySqlDbType.Double);
                param[4].Value = profit;
                param[5] = new MySqlParameter("@discount_percentage0", MySqlDbType.Double);
                param[5].Value = discount_percentage;
                param[6] = new MySqlParameter("@discount0", MySqlDbType.Double);
                param[6].Value = discount;
                param[7] = new MySqlParameter("@sub_totel0", MySqlDbType.Double);
                param[7].Value = sub_totel;
                param[8] = new MySqlParameter("@vat0", MySqlDbType.Double);
                param[8].Value = vat;
                param[9] = new MySqlParameter("@additional_charge0", MySqlDbType.Double);
                param[9].Value = additional_charge;
                param[10] = new MySqlParameter("@invoice_net_totel0", MySqlDbType.Double);
                param[10].Value = invoice_net_totel;
                param[11] = new MySqlParameter("@shift_id0", MySqlDbType.Int64);
                param[11].Value = shift_id;
                param[12] = new MySqlParameter("@user_id0", MySqlDbType.Int32);
                param[12].Value = user_id;
                param[13] = new MySqlParameter("@paid_statues0", MySqlDbType.VarChar, 60);
                param[13].Value = paid_statues;
                param[14] = new MySqlParameter("@invoice_statues0", MySqlDbType.VarChar, 60);
                param[14].Value = invoice_statues;
                param[15] = new MySqlParameter("@purchase_date0", MySqlDbType.VarChar, 60);
                param[15].Value = purchase_date;
                param[16] = new MySqlParameter("@adddate0", MySqlDbType.VarChar, 60);
                param[16].Value = adddate;
                //param[13] = new MySqlParameter("@adddate0", MySqlDbType.DateTime);
                //param[13].Value = adddate;
                //param[14] = new MySqlParameter("@payment_method_id0", MySqlDbType.Int32);
                //param[14].Value = payment_method_id;
                //param[15] = new MySqlParameter("@cheque_no0", MySqlDbType.Int32);
                //param[15].Value = cheque_no;
                     if (OpenConnection())
                {
                    if (ExecuteCommand(" purchaseSummerySave", param))
                    {

                        //ShowMessage("Data Saved Successfully", "Warning");
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

        public bool Editpurchase()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[16];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                param[1] = new MySqlParameter("@invoice_id0", MySqlDbType.Int32);
                param[1].Value = invoice_id;
                param[2] = new MySqlParameter("@supplier_id0", MySqlDbType.Int32);
                param[2].Value = supplier_id;
                param[3] = new MySqlParameter("@totel0", MySqlDbType.Double);
                param[3].Value = totel;
                param[4] = new MySqlParameter("@profit0", MySqlDbType.Double);
                param[4].Value = profit;
                param[5] = new MySqlParameter("@discount_percentage0", MySqlDbType.Double);
                param[5].Value = discount_percentage;
                param[6] = new MySqlParameter("@discount0", MySqlDbType.Double);
                param[6].Value = discount;
                param[7] = new MySqlParameter("@sub_totel0", MySqlDbType.Double);
                param[7].Value = sub_totel;
                param[8] = new MySqlParameter("@vat0", MySqlDbType.Double);
                param[8].Value = vat;
                param[9] = new MySqlParameter("@additional_charge0", MySqlDbType.Double);
                param[9].Value = additional_charge;
                param[10] = new MySqlParameter("@invoice_net_totel0", MySqlDbType.Double);
                param[10].Value = invoice_net_totel;
                param[11] = new MySqlParameter("@shift_id0", MySqlDbType.Int64);
                param[11].Value = shift_id;
                param[12] = new MySqlParameter("@user_id0", MySqlDbType.Int32);
                param[12].Value = user_id;
                param[13] = new MySqlParameter("@adddate0", MySqlDbType.DateTime);
                param[13].Value = adddate;
                param[14] = new MySqlParameter("@payment_method_id0", MySqlDbType.Int32);
                //param[14].Value = payment_method_id;
                //param[15] = new MySqlParameter("@cheque_no0", MySqlDbType.Int32);
                //param[15].Value = cheque_no;
                     if (OpenConnection())
                {
                    if (ExecuteCommand(" purchaseEdit", param))
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

        public bool Deletepurchase()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[1];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                     if (OpenConnection())
                {
                    if (ExecuteCommand(" purchaseDelete", param))
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

        public DataTable Getpurchase()
        {
            comtable = null;


            if (OpenConnection())
            {
                comtable = SelectData("purchaseSelect", null);
                sqlconnection.Close();
            }

            return comtable;
        }
        public void BindpurchaseDetails(DataGridView dgv)
        {

            BindGrid(dgv, Getpurchase());
        }

//Start-----------------constructer-------------------------------

        public purchase(int id, int invoice_id, int supplier_id, double totel, double profit, double discount_percentage, double discount, double sub_totel, double vat, double additional_charge, double invoice_net_totel, long shift_id, int user_id, DateTime adddate, int payment_method_id, int cheque_no, string invoice_statues, string paid_statues, DateTime purchase_date)
        {
            this.id = id;
            this.invoice_id = invoice_id;
            this.supplier_id = supplier_id;
            this.totel = totel;
            this.profit = profit;
            this.discount_percentage = discount_percentage;
            this.discount = discount;
            this.sub_totel = sub_totel;
            this.vat = vat;
            this.additional_charge = additional_charge;
            this.invoice_net_totel = invoice_net_totel;
            this.shift_id = shift_id;
            this.user_id = user_id;
            this.adddate = adddate;
            this.invoice_statues = invoice_statues;
            this.paid_statues = paid_statues;
            this.purchase_date = purchase_date;
            //this.payment_method_id = payment_method_id;
            //this.cheque_no = cheque_no;


//End-----------------------constructer-------------------------------
}
        //Start-----------------constructer-------------------------------

        //public purchase(int id)
        //{
        //    this.id = id;
            
        //}
        //End-----------------------constructer-------------------------------


        //Start-----------------constructer-------------------------------

        public purchase(int invoice_id)
        {
            this.invoice_id = invoice_id;

        }
        //End-----------------------constructer-------------------------------


        //Start-----------------constructer-------------------------------

        public purchase()
        {
         
        }
        //End-----------------------constructer-------------------------------

        public DataTable Getinvoicebyno()
        {
            DataTable dt = new DataTable();

            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@invoice_id0", MySqlDbType.VarChar, 60);
            param[0].Value = invoice_id;

            if (OpenConnection())
            {
                dt = SelectData("invoicesearch", param);
                CloseConnection();
            }

            return dt;
        }

        public void BindinvoiceDetailSearch(DataGridView dgv)
        {

            BindGrid(dgv, Getinvoicebyno());
        }

        public DataTable purchasebinfcombo()
        {
            comtable = null;
            if (OpenConnection())
            {
                comtable = SelectData("purchaseBindinCombo", null);
                sqlconnection.Close();
            }
            return comtable;
        }
    }
}
