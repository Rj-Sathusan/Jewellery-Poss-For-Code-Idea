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
    class supplier : DAT.NewDataAccessLayer
    {      
        private int id;
        private string phone_number;
        private string name;
        private string email;
        private string adress;
        private string fax;

//Start---------------Getter/setter-----------------------------


        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string PHONE_NUMBER
        {
            get { return this.phone_number; }
            set { this.phone_number = value; }
        }
        public string EMAIL
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string ADRESS
        {
            get { return this.adress; }
            set { this.adress = value; }
        }
        public string FAX
        {
            get { return this.fax; }
            set { this.fax = value; }
        }

//END---------------Getter/setter-----------------------------

//Start---------------------SAVE------------------Proceture---------------

        public bool Savesupplier()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[6];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                param[1] = new MySqlParameter("@phone_number0", MySqlDbType.VarChar, 60);
                param[1].Value = phone_number;
                param[2] = new MySqlParameter("@email0", MySqlDbType.VarChar, 60);
                param[2].Value = email;
                param[3] = new MySqlParameter("@adress0", MySqlDbType.VarChar, 60);
                param[3].Value = adress;
                param[4] = new MySqlParameter("@fax0", MySqlDbType.VarChar, 60);
                param[4].Value = fax;
                param[5] = new MySqlParameter("@name0", MySqlDbType.VarChar, 60);
                param[5].Value = name;
                     if (OpenConnection())
                {
                    if (ExecuteCommand("supplierSave", param))
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

        public bool Editsupplier()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[6];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                param[1] = new MySqlParameter("@phone_number0", MySqlDbType.VarChar, 60);
                param[1].Value = phone_number;
                param[2] = new MySqlParameter("@email0", MySqlDbType.VarChar, 60);
                param[2].Value = email;
                param[3] = new MySqlParameter("@adress0", MySqlDbType.VarChar, 60);
                param[3].Value = adress;
                param[4] = new MySqlParameter("@fax0", MySqlDbType.VarChar, 60);
                param[4].Value = fax;
                param[5] = new MySqlParameter("@name0", MySqlDbType.VarChar, 60);
                param[5].Value = name;
                     if (OpenConnection())
                {
                    if (ExecuteCommand("supplierEdit", param))
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

        public bool Deletesupplier()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[1];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                     if (OpenConnection())
                {
                    if (ExecuteCommand("supplierDelete", param))
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

        public DataTable Getsupplier()
        {
            comtable = null;


            if (OpenConnection())
            {
                comtable = SelectData("supplierSelect", null);
                sqlconnection.Close();
            }

            return comtable;
        }
        public void BindsupplierDetails(DataGridView dgv)
        {

            BindGrid(dgv, Getsupplier());
        }

//Start-----------------constructer-------------------------------

        public supplier(int id,string name,string phone_number,string email,string adress,string fax)
        {
            this.id = id;
            this.name = name;
            this.phone_number = phone_number;
            this.email = email;
            this.adress = adress;
            this.fax = fax;


//End-----------------------constructer-------------------------------
}

        public supplier(int id)
        {
            this.id = id;
        }

        public supplier()
        {
            // TODO: Complete member initialization
        }
    }
}

