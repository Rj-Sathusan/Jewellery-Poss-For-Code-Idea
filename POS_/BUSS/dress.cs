using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_.BUSS
{
    using MySql.Data.MySqlClient;
    using System.Windows.Forms;
    using System.Data;


    class dress : DAT.NewDataAccessLayer
    {
        private int id;
        private string name;
        private int age;
        private string adress;
        private double amount;
        private long shift_id;

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
        public int AGE
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string ADRESS
        {
            get { return this.adress; }
            set { this.adress = value; }
        }
        public double AMOUNT
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
        public long SHIFT_ID
        {
            get { return this.shift_id; }
            set { this.shift_id = value; }
        }

        //END---------------Getter/setter-----------------------------

        //Start---------------------SAVE------------------Proceture---------------

        public bool Savedress()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[6];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                param[1] = new MySqlParameter("@name0", MySqlDbType.VarChar, 60);
                param[1].Value = name;
                param[2] = new MySqlParameter("@age0", MySqlDbType.Int32);
                param[2].Value = age;
                param[3] = new MySqlParameter("@adress0", MySqlDbType.VarChar, 60);
                param[3].Value = adress;
                param[4] = new MySqlParameter("@amount0", MySqlDbType.Double);
                param[4].Value = amount;
                param[5] = new MySqlParameter("@shift_id0", MySqlDbType.Int64);
                param[5].Value = shift_id;
                if (OpenConnection())
                {
                    if (ExecuteCommand(" dress_Save", param))
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

        public bool Editdress()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[6];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                param[1] = new MySqlParameter("@name0", MySqlDbType.VarChar, 60);
                param[1].Value = name;
                param[2] = new MySqlParameter("@age0", MySqlDbType.Int32);
                param[2].Value = age;
                param[3] = new MySqlParameter("@adress0", MySqlDbType.VarChar, 60);
                param[3].Value = adress;
                param[4] = new MySqlParameter("@amount0", MySqlDbType.Double);
                param[4].Value = amount;
                param[5] = new MySqlParameter("@shift_id0", MySqlDbType.Int64);
                param[5].Value = shift_id;
                if (OpenConnection())
                {
                    if (ExecuteCommand(" dress_Edit", param))
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

        public bool Deletedress()
        {

            try
            {
                MySqlParameter[] param = new MySqlParameter[1];
                param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
                param[0].Value = id;
                if (OpenConnection())
                {
                    if (ExecuteCommand(" Delete_dress ", param))
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

        public DataTable Getdress()
        {
            comtable = null;


            if (OpenConnection())
            {
                comtable = SelectData("dress_Select", null);
                sqlconnection.Close();
            }

            return comtable;
        }
        public void BinddressDetails(DataGridView dgv)
        {

            BindGrid(dgv, Getdress());
        }

        //Start-----------------constructer-------------------------------

        public dress(int id)
        {
            this.id = id;
        }
        //End-----------------------constructer-------------------------------

        public dress()
        {
        }



        //Start-----------------constructer-------------------------------

        public dress(int id, string name, int age, string adress, double amount, long shift_id)
        {

            this.id = id;
            this.name = name;
            this.age = age;
            this.adress = adress;
            this.amount = amount;
            this.shift_id = shift_id;


            //End-----------------------constructer-------------------------------        
        }

    }
}

