using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_.BUSS
{
    class user : DAT.NewDataAccessLayer
    {
        private int id;
        private string name;
        private string nic;
        private string designation;
        private string mobile;
        private string email;
        private string message;

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
        public string NIC
        {
            get { return this.nic; }
            set { this.nic = value; }
        }
        public string DESIGNATION
        {
            get { return this.designation; }
            set { this.designation = value; }
        }
        public string MOBILE
        {
            get { return this.mobile; }
            set { this.mobile = value; }
        }
        public string EMAIL
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Message
        {
            get
            {
                return this.message;
            }
            set
            {
                this.message = value;
            }
        }

        //END---------------Getter/setter-----------------------------

        //Start---------------------SAVE------------------Proceture---------------

        public bool Saveuser()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[6];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                param[1] = new MySqlParameter("@name0", MySqlDbType.VarChar, 60);
                param[1].Value = name;
                param[2] = new MySqlParameter("@nic0", MySqlDbType.VarChar, 60);
                param[2].Value = nic;
                param[3] = new MySqlParameter("@designation0", MySqlDbType.VarChar, 60);
                param[3].Value = designation;
                param[4] = new MySqlParameter("@mobile0", MySqlDbType.VarChar, 60);
                param[4].Value = mobile;
                param[5] = new MySqlParameter("@email0", MySqlDbType.VarChar, 60);
                param[5].Value = email;
                if (OpenConnection())
                {
                    if (ExecuteCommand(" userSave", param))
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

        public bool Edituser()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[6];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                param[1] = new MySqlParameter("@name0", MySqlDbType.VarChar, 60);
                param[1].Value = name;
                param[2] = new MySqlParameter("@nic0", MySqlDbType.VarChar, 60);
                param[2].Value = nic;
                param[3] = new MySqlParameter("@designation0", MySqlDbType.VarChar, 60);
                param[3].Value = designation;
                param[4] = new MySqlParameter("@mobile0", MySqlDbType.VarChar, 60);
                param[4].Value = mobile;
                param[5] = new MySqlParameter("@email0", MySqlDbType.VarChar, 60);
                param[5].Value = email;
                if (OpenConnection())
                {
                    if (ExecuteCommand(" userEdit", param))
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

        public bool Deleteuser()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[1];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                if (OpenConnection())
                {
                    if (ExecuteCommand(" userDelete", param))
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

        public user(int id, string name, string nic, string designation, string mobile, string email)
        {
            this.id = id;
            this.name = name;
            this.nic = nic;
            this.designation = designation;
            this.mobile = mobile;
            this.email = email;


            //End-----------------------constructer-------------------------------        
        }

        public user( string name)
        {
            this.name = name;
      


            //End-----------------------constructer-------------------------------        
        }

        //Start-----------------constructer-------------------------------

        public user(int id)
        {
            this.id = id;


            //End-----------------------constructer-------------------------------        
        }

        public user()
        {
        }

        public DataTable Getuser()
        {
            comtable = null;


            if (OpenConnection())
            {
                comtable = SelectData("selectUser", null);
                CloseConnection();
            }

            return comtable;
        }

        public void BindIuserDetailsFull(DataGridView dgv)
        {

            BindGrid(dgv, Getuser());
            if (dgv.SelectedRows.Count >= 1)
            {
                dgv.SelectedRows[0].Selected = false;
            }

        }
    }
}
