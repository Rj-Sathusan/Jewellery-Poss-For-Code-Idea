using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace POS_.BUSS
{
   
     class Category : DAT.NewDataAccessLayer
    {
        public string searchdate { get; set; }
        DAT.NewDataAccessLayer Ndal = new DAT.NewDataAccessLayer();
        private int id;
        private string description;
        private bool ispet;
        private int creditlimit;
        private string createuser;
        private DateTime createdate;
        private string accessuser;
        private DateTime accessdate;
        private string message;
        private long orderby;

        public Category()
        {
            this.message = "";
        }

        public Category(int id)
        {
            this.message = "";
            this.id = id;
        }

        public Category(int id, string description, bool ispet, int creditlimit,long orderby)
        {
            this.message = "";
            this.id = id;
            this.description = description;
            this.ispet = ispet;
            this.creditlimit = creditlimit;
            this.orderby = orderby;
        }

        public bool Create()
        {
            DAT.NewDataAccessLayer dat = new DAT.NewDataAccessLayer();
            MySqlParameter[] param = new MySqlParameter[3];

            param[0] = new MySqlParameter("@desc1", MySqlDbType.VarChar, 150);
            param[0].Value = description;
           
            param[1] = new MySqlParameter("@cuda", MySqlDbType.DateTime);
            param[1].Value =DateTime.Now;


            param[2] = new MySqlParameter("@orby", MySqlDbType.Int64);
            param[2].Value = orderby;
          



             if (dat.OpenConnection())
            {
                if (dat.ExecuteCommand("AddCategory", param))
                {
                    dat.CloseConnection();

                    this.message = "Data successfully deleted !";
                    param = null; dat = null;
                    return true;
                }
                else
                {
                    dat.CloseConnection();

                    this.message = "This Category already exists !";
                    param = null; dat = null;
                    return false;
                }
            }
            else
            {

                dat.CloseConnection();
                this.message = "Server Not Connected !";
                param = null; dat = null;
                return false;
            }

        }


        public DataTable Search_Get_All(string referance)
        {

            MySqlParameter[] param = new MySqlParameter[1];
            DAT.NewDataAccessLayer dat = new DAT.NewDataAccessLayer();
            DataTable dataTable = new DataTable();

            param[0] = new MySqlParameter("@searchdata", MySqlDbType.VarChar, 150);
            param[0].Value = referance;
            if (dat.OpenConnection())
            {
                dataTable = dat.SelectData("SearchAllCategory", param);
                dat.CloseConnection();
                dat = null; param = null;

                return dataTable;
            }
            else
            {
                return dataTable;
            }

        }

        //public int GetLastCategoryOrder()
        //{
        //    orderby = 0;
        //    comtable = null;
          
        //    if (OpenConnection())
        //    {
        //        comtable = SelectData("MaxCategoryOrder", null);
        //        sqlconnection.Close();
        //    }
        //    orderby = Convert.ToInt32( comtable.Rows[0].ItemArray[0].ToString())+1;
        //    comtable = null;
        //    return orderby;
        //}
        //public Category Get(string reference)
        //{
        //    Category category2;/*
        //    base.Select("*");
        //    base.From(this.TBL_Master);
        //    string str = reference;
        //    if (str != null)
        //    {
        //        if (str == "Id")
        //        {
        //            base.Where("id", this.Id, true);
        //        }
        //        else if (str == "Description")
        //        {
        //            base.Where("description", this.Description, true);
        //        }
        //    }
        //    DataTable table = base.Get();
        //    if (table.Rows.Count == 0)
        //    {
        //        category2 = null;
        //    }
        //    else
        //    {
        //        category2 = new Category {
        //            Id = table.Rows[0]["id"].ToString(),
        //            Description = table.Rows[0]["description"].ToString(),
        //            IsPet = bool.Parse(table.Rows[0]["ispet"].ToString()),
        //            CreditLimit = int.Parse(table.Rows[0]["creditlimit"].ToString()),
        //            Createuser = table.Rows[0]["createuser"].ToString(),
        //            Createdate = DateTime.Parse(table.Rows[0]["createdate"].ToString()),
        //            Accessuser = table.Rows[0]["accessuser"].ToString(),
        //            Accessdate = DateTime.Parse(table.Rows[0]["accessdate"].ToString())
        //        };
        //    }*/
        //    return category2;
        //}
        public DataTable ShowAllCategory()
        {


            MySqlParameter[] param = new MySqlParameter[1];
            DAT.NewDataAccessLayer dat = new DAT.NewDataAccessLayer();
            DataTable dataTable = new DataTable();

            if (dat.OpenConnection())
            {
                dataTable = dat.SelectData("SelectAllCategory", null);
                dat.CloseConnection();
                dat = null; param = null;

                return dataTable;
            }
            else
            {
                return dataTable;
            }


        }

        public DataTable Get_All()
        {
         
                comtable = null;
                if (OpenConnection())
                {
                    comtable = SelectData("AllCategory", null);
                    sqlconnection.Close();
                }

                return comtable;
            
        }

      
        public bool Modify()
        {

            DAT.NewDataAccessLayer dat = new DAT.NewDataAccessLayer();
            MySqlParameter[] param = new MySqlParameter[4];

            param[0] = new MySqlParameter("@desc1", MySqlDbType.VarChar, 150);
            param[0].Value = description;

            param[1] = new MySqlParameter("@cuda", MySqlDbType.DateTime);
            param[1].Value = DateTime.Now;


            param[2] = new MySqlParameter("@orby", MySqlDbType.Int64);
            param[2].Value = orderby;

            param[3] = new MySqlParameter("@id1", MySqlDbType.Int32);
            param[3].Value =id;




            if (dat.OpenConnection())
            {
                if (dat.ExecuteCommand("EditCategory", param))
                {
                    dat.CloseConnection();

                    this.message = "Data successfully deleted !";
                    param = null; dat = null;
                    return true;
                }
                else
                {
                    dat.CloseConnection();

                    this.message = "This Category already exists !";
                    param = null; dat = null;
                    return false;
                }
            }
            else
            {

                dat.CloseConnection();
                this.message = "Server Not Connected !";
                param = null; dat = null;
                return false;
            }
        }

        //public string New_Id()
        //{
        //    //base.Select_Max("id", null);
        //    //base.From(this.TBL_Master);
        //    return base.Generate_Id("CG", base.Get().Rows[0]["id"].ToString());
        //}

        public bool Remove()
        {

            DAT.NewDataAccessLayer dat = new DAT.NewDataAccessLayer();
            MySqlParameter[] param = new MySqlParameter[1];

          

            param[0] = new MySqlParameter("@id1", MySqlDbType.Int32);
            param[0].Value = id;




            if (dat.OpenConnection())
            {
                if (dat.ExecuteCommand("DeleteCategory", param))
                {
                    dat.CloseConnection();

                    this.message = "Data successfully deleted !";
                    param = null; dat = null;
                    return true;
                }
                else
                {
                    dat.CloseConnection();

                    this.message = "Can't Delete Category !";
                    param = null; dat = null;
                    return false;
                }
            }
            else
            {

                dat.CloseConnection();
                this.message = "Server Not Connected !";
                param = null; dat = null;
                return false;
            }

        }

        public string Response_Message()
        {
           return this.message;
        }

        public DataTable Search(string key)
        {
            //base.Select("*");
            //base.From(this.TBL_Master);
            //string[] textArray1 = new string[] { "((Description LIKE '%", key, "%') OR (Id LIKE '%", key, "%'))" };
            //base.Where(string.Concat(textArray1), true);
            DataTable dt =new DataTable();
            return dt;
        }

        //public bool ServerValid(bool is_edit)
        //{
        //    if (this.Get("Description") != null)
        //    {
        //        if (!is_edit)
        //        {
        //            this.message = "Description already exists !";
        //            return false;
        //        }
        //        else if (this.Get("Id").Description != this.Description)
        //        {
        //            this.message = "Description already exists !";
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        public int Id
        {
            get {
               return this.id;
            }
            set { 
                this.id = value;
            }
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
        public string Description
        {
            get {
             return   this.description;
            }
            set {
                this.description = value;
            }
        }

        public bool IsPet
        {
            get {
              return   this.ispet;
            }
            set {
                this.ispet = value;
            }
        }

        public int CreditLimit
        {
            get {
              return  this.creditlimit;
            }
            set {
                this.creditlimit = value;
            }
        }
        public long OrderBy
        {
            get{
               return this.orderby;
            }
            set{
                this.orderby = value;
            }
        }

        public string Createuser
        {
            get {
              return  this.createuser;
            }
            set {
                this.createuser = value;
            }
        }

        public DateTime Createdate
        {
            get {
               return this.createdate;
            }
            set {
                this.createdate = value;
            }
        }

        public string Accessuser
        {
            get {
              return  this.accessuser;
            }
            set {
                this.accessuser = value;
            }
        }

        public DateTime Accessdate
        {
            get {
               return this.accessdate;
            }
            set {
                this.accessdate = value;
            }
        }

        //public string TBL_Master =>
        //    "2_tbl_categorys";
    }
}

