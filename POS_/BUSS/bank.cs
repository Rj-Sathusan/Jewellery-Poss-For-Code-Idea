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
    class bank: DAT.NewDataAccessLayer
    {
        private string id;
        private string name;
        private string account_typ;
        private string account_num;

//Start---------------Getter/setter-----------------------------


        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string NAME
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string ACCOUNT_TYP
        {
            get { return this.account_typ; }
            set { this.account_typ = value; }
        }
        public string ACCOUNT_NUM
        {
            get { return this.account_num; }
            set { this.account_num = value; }
        }

//END---------------Getter/setter-----------------------------

//Start---------------------SAVE------------------Proceture---------------

        public bool Savebank()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[4];
                param[0] = new MySqlParameter("@id0", MySqlDbType.VarChar, 60);
                param[0].Value = id;
                param[1] = new MySqlParameter("@name0", MySqlDbType.VarChar, 60);
                param[1].Value = name;
                param[2] = new MySqlParameter("@account_typ0", MySqlDbType.VarChar, 60);
                param[2].Value = account_typ;
                param[3] = new MySqlParameter("@account_num0", MySqlDbType.VarChar, 60);
                param[3].Value = account_num;
                     if (OpenConnection())
                {
                    if (ExecuteCommand(" bankSave", param))
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

        public bool Editbank()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[4];
                param[0] = new MySqlParameter("@id0", MySqlDbType.VarChar, 60);
                param[0].Value = id;
                param[1] = new MySqlParameter("@name0", MySqlDbType.VarChar, 60);
                param[1].Value = name;
                param[2] = new MySqlParameter("@account_typ0", MySqlDbType.VarChar, 60);
                param[2].Value = account_typ;
                param[3] = new MySqlParameter("@account_num0", MySqlDbType.VarChar, 60);
                param[3].Value = account_num;
                     if (OpenConnection())
                {
                    if (ExecuteCommand(" bankEdit", param))
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

        public bool Deletebank()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[1];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                     if (OpenConnection())
                {
                    if (ExecuteCommand(" bankDelete", param))
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

        public DataTable Getbank()
        {
            comtable = null;


            if (OpenConnection())
            {
                comtable = SelectData("bankSelect", null);
                sqlconnection.Close();
            }

            return comtable;
        }
        public void BindbankDetails(DataGridView dgv)
        {

            BindGrid(dgv, Getbank());
        }

//Start-----------------constructer-------------------------------

        public bank(string id, string name, string account_typ, string account_num)
        {
            this.id = id;
            this.name = name;
            this.account_typ = account_typ;
            this.account_num = account_num;
        }

        public bank(string id)
        {
            this.id = id;
        }



//End-----------------------constructer-------------------------------


  
 }
}
