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
    class customer : DAT.NewDataAccessLayer
    {
         private int id;
        private string name;
        private string adress;
        private string phone_no;
        private string phone_no2;
        private int route_id;
        private long shift_id;
        private string p;

//Start---------------Getter/setter-----------------------------


        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string NAME
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string ADRESS
        {
            get { return this.adress; }
            set { this.adress = value; }
        }
        public string PHONE_NO
        {
            get { return this.phone_no; }
            set { this.phone_no = value; }
        }
        public string PHONE_NO2
        {
            get { return this.phone_no2; }
            set { this.phone_no2 = value; }
        }
        public int ROUTE_ID
        {
            get { return this.route_id; }
            set { this.route_id = value; }
        }
        public long SHIFT_ID
        {
            get { return this.shift_id; }
            set { this.shift_id = value; }
        }

//END---------------Getter/setter-----------------------------

//Start---------------------SAVE------------------Proceture---------------

        public bool Savecustomer()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[7];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                param[1] = new MySqlParameter("@name0", MySqlDbType.VarChar, 60);
                param[1].Value = name;
                param[2] = new MySqlParameter("@adress0", MySqlDbType.VarChar, 60);
                param[2].Value = adress;
                param[3] = new MySqlParameter("@phone_no0", MySqlDbType.VarChar, 60);
                param[3].Value = phone_no;
                param[4] = new MySqlParameter("@phone_no20", MySqlDbType.VarChar, 60);
                param[4].Value = phone_no2;
                param[5] = new MySqlParameter("@route_id0", MySqlDbType.Int32);
                param[5].Value = route_id;
                param[6] = new MySqlParameter("@shift_id0", MySqlDbType.Int64);
                param[6].Value = shift_id;
                     if (OpenConnection())
                {
                    if (ExecuteCommand(" customerSave", param))
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

        public bool Editcustomer()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[7];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                param[1] = new MySqlParameter("@name0", MySqlDbType.VarChar, 60);
                param[1].Value = name;
                param[2] = new MySqlParameter("@adress0", MySqlDbType.VarChar, 60);
                param[2].Value = adress;
                param[3] = new MySqlParameter("@phone_no0", MySqlDbType.VarChar, 60);
                param[3].Value = phone_no;
                param[4] = new MySqlParameter("@phone_no20", MySqlDbType.VarChar, 60);
                param[4].Value = phone_no2;
                param[5] = new MySqlParameter("@route_id0", MySqlDbType.Int32);
                param[5].Value = route_id;
                param[6] = new MySqlParameter("@shift_id0", MySqlDbType.Int64);
                param[6].Value = shift_id;
                     if (OpenConnection())
                {
                    if (ExecuteCommand(" customerEdit", param))
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

        public bool Deletecustomer()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[1];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                     if (OpenConnection())
                {
                    if (ExecuteCommand(" customerDelete", param))
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

        public DataTable Getcustomer()
        {
            comtable = null;


            if (OpenConnection())
            {
                comtable = SelectData("customerSelect", null);
                sqlconnection.Close();
            }

            return comtable;
        }
        public void BindcustomerDetails(DataGridView dgv)
        {

            BindGrid(dgv, Getcustomer());
        }

//Start-----------------constructer-------------------------------

        public customer(int id,string name,string adress,string phone_no,string phone_no2,int route_id,long shift_id)
        {
            this.id = id;
            this.name = name;
            this.adress = adress;
            this.phone_no = phone_no;
            this.phone_no2 = phone_no2;
            this.route_id = route_id;
            this.shift_id = shift_id;


//End-----------------------constructer-------------------------------
}

 //Start-----------------constructer-------------------------------

public customer(int id)
 {
            this.id = id;
            //End-----------------------constructer-------------------------------
     }

//Start-----------------constructer-------------------------------

public customer(string name)
{
    this.name = name;
    //End-----------------------constructer-------------------------------
}


public DataTable GetCustomebyname()
{
    DataTable dt = new DataTable();

    MySqlParameter[] param = new MySqlParameter[1];

    param[0] = new MySqlParameter("@name0", MySqlDbType.VarChar, 60);
    param[0].Value = name;

    if (OpenConnection())
    {
        dt = SelectData("customersearch", param);
        CloseConnection();
    }

    return dt;
}

public void BindcustomerDetaisSearch(DataGridView dgv)
{

    BindGrid(dgv, GetCustomebyname());
}
public customer()
{
    // TODO: Complete member initialization
}


    }
}
