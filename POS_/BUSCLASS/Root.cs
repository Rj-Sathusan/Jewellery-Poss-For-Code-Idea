namespace POS_.BUSCLASS
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using MySql.Data.MySqlClient;

    public class Root 
    {
       
        private string message;

        public int routid { get; set; }
        public string fromrouat { get; set; }
        public string torouat { get; set; }
        public long shiftid { get; set; }

        public DateTime createdate { get; set; }
        public int accessuser { get; set; }
        public DateTime accessdate { get; set; }
        public string distr { get; set; }

        public string routserch { get; set; }

       
       

        public Root()
        {
            this.message = "";
        }

        public Root(int id)
        {
            this.message = "";
            this.routid = id;
        }
        public Root(int id,long shiftid,DateTime createdate)
        {
            this.message = "";
            this.routid = id;
            this.shiftid = shiftid;
            this.createdate = createdate;
        }

        public Root(int id, string fromroute, string toroute,string dist,DateTime createdate,long shiftid)
        {
            this.message = "";
            this.routid = id;
            this.fromrouat = fromroute;
            this.torouat = toroute;
            this.createdate = createdate;
            this.distr = dist;
            this.shiftid = shiftid;
        }

        public bool Create()
        {
            DAT.NewDataAccessLayer dat = new DAT.NewDataAccessLayer();
            MySqlParameter[] param = new MySqlParameter[5];

            param[0] = new MySqlParameter("@froute", MySqlDbType.VarChar, 150);
            param[0].Value = fromrouat;
            param[1] = new MySqlParameter("@troute", MySqlDbType.VarChar, 150);
            param[1].Value = torouat;

            param[2] = new MySqlParameter("@cuda", MySqlDbType.DateTime);
            param[2].Value = createdate;

            param[3] = new MySqlParameter("@sid", MySqlDbType.Int64);
            param[3].Value = shiftid;
            param[4] = new MySqlParameter("@dist", MySqlDbType.VarChar,100);
            param[4].Value = distr;

            if (dat.OpenConnection())
            {
                if (dat.ExecuteCommand("AddRoute", param))
                {
                    dat.CloseConnection();

                    this.message = "Data successfully saved !";
                    param = null; dat = null;
                    return true;
                }
                else
                {
                    dat.CloseConnection();

                    this.message = "Route already exists !";
                    param = null; dat = null;
                    return false;
                }
            }
            else
            {

                dat.CloseConnection();
                this.message="Server Not Connected !";
                param = null; dat = null;
                return false;
            }


           
        }

        public List<Root> GetAllRoute()
        {

           
            MySqlParameter[] param = new MySqlParameter[1];
            DAT.NewDataAccessLayer dat = new DAT.NewDataAccessLayer();
            DataTable dataTable=new DataTable();

            if (dat.OpenConnection())
            {
                dataTable = dat.SelectData("SelectAllRoute", null);
                dat.CloseConnection();
                dat = null; param = null;

                if (dataTable.Rows.Count == 0)
                {
                    return (List<Root>)null;
                }
                else
                {
                    List<Root> rootlist = new List<Root>();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        Root newroot = new Root();
                        newroot.Id = Convert.ToInt32(row["id"].ToString());
                        newroot.Fromrouat = row["froute"].ToString();
                        newroot.Torouat = row["troute"].ToString();
                        newroot.Distr = row["districk"].ToString();
                        rootlist.Add(newroot);
                    }
                    return rootlist;
                
                }
            }
            else
            {
                return (List<Root>)null;
            }

           
        }

        public DataTable ShowAllRoute()
        {


            MySqlParameter[] param = new MySqlParameter[1];
            DAT.NewDataAccessLayer dat = new DAT.NewDataAccessLayer();
            DataTable dataTable = new DataTable();

            if (dat.OpenConnection())
            {
                dataTable = dat.SelectData("SelectAllRoute", null);
                dat.CloseConnection();
                dat = null; param = null;

                return dataTable;
            }
            else
            {
                return dataTable;
            }


        }


        public DataTable SearchRoute(string referance)
        {


            MySqlParameter[] param = new MySqlParameter[1];
            DAT.NewDataAccessLayer dat = new DAT.NewDataAccessLayer();
            DataTable dataTable = new DataTable();

            param[0] = new MySqlParameter("@searchdata", MySqlDbType.VarChar, 150);
            param[0].Value = referance;
            if (dat.OpenConnection())
            {
                dataTable = dat.SelectData("SearchAllRoute", param);
                dat.CloseConnection();
                dat = null; param = null;

                return dataTable;
            }
            else
            {
                return dataTable;
            }


        }

        //public Root Get(string reference)
        //{
        //    Root root2;

        //    comtable = null;
        //    MySqlParameter[] param = new MySqlParameter[1];

        //    param[0] = new MySqlParameter("@ico", MySqlDbType.VarChar, 30);
        //    param[0].Value = reference;

        //    if (OpenConnection())
        //    {
        //        comtable = SelectData("GetRootDetailsByRouteid", param);
        //        sqlconnection.Close();
        //    }
        //    param = null;

        //    DataTable table = comtable;
        //    comtable = null;

        //    if (table.Rows.Count == 0)
        //    {
        //        root2 = null;
        //    }
        //    else
        //    {
        //        root2 = new Root
        //        {
        //            Id = table.Rows[0]["id"].ToString(),
        //            Description = table.Rows[0]["description"].ToString(),
        //            Createuser = table.Rows[0]["createuser"].ToString(),
        //            Createdate = DateTime.Parse(table.Rows[0]["createdate"].ToString()),
        //            Accessuser = table.Rows[0]["accessuser"].ToString(),
        //            Accessdate = DateTime.Parse(table.Rows[0]["accessdate"].ToString()),
        //            Staffid = table.Rows[0]["staffid"].ToString()
        //        };
        //    }
        //    return root2;
        //}

        //public DataTable Get_All()
        //{
        //    base.Select("*");
        //    base.From(this.TBL_Master);
        //    base.Order_By("Id", "ASC");
        //    return base.Get();
        //}

        public bool Modify()
        {

            DAT.NewDataAccessLayer dat = new DAT.NewDataAccessLayer();
            MySqlParameter[] param = new MySqlParameter[6];

            param[0] = new MySqlParameter("@froute", MySqlDbType.VarChar, 150);
            param[0].Value = fromrouat;
            param[1] = new MySqlParameter("@troute", MySqlDbType.VarChar, 150);
            param[1].Value = torouat;

            param[2] = new MySqlParameter("@cuda", MySqlDbType.DateTime);
            param[2].Value = createdate;

            param[3] = new MySqlParameter("@sid", MySqlDbType.Int64);
            param[3].Value = shiftid;
            param[4] = new MySqlParameter("@dist", MySqlDbType.VarChar, 100);
            param[4].Value = distr;
            param[5] = new MySqlParameter("@rid", MySqlDbType.Int32);
            param[5].Value = routid;

            if (dat.OpenConnection())
            {
                if (dat.ExecuteCommand("EditRoute", param))
                {
                    dat.CloseConnection();

                    this.message = "Data successfully saved !";
                    param = null; dat = null;
                    return true;
                }
                else
                {
                    dat.CloseConnection();

                    this.message = "Route already exists !";
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
        //    base.Select_Max("id", null);
        //    base.From(this.TBL_Master);
        //    return base.Generate_Id("RO", base.Get().Rows[0]["id"].ToString());
        //}

        public bool Remove()
        {
            DAT.NewDataAccessLayer dat = new DAT.NewDataAccessLayer();
            MySqlParameter[] param = new MySqlParameter[3];

            param[0] = new MySqlParameter("@cuda", MySqlDbType.DateTime);
            param[0].Value = createdate;

            param[1] = new MySqlParameter("@sid", MySqlDbType.Int64);
            param[1].Value = shiftid;
           
            param[2] = new MySqlParameter("@rid", MySqlDbType.Int32);
            param[2].Value = routid;

            if (dat.OpenConnection())
            {
                if (dat.ExecuteCommand("DeleteRoute", param))
                {
                    dat.CloseConnection();

                    this.message = "Data successfully deleted !";
                    param = null; dat = null;
                    return true;
                }
                else
                {
                    dat.CloseConnection();

                    this.message = "Can't Delete";
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

        //public string Response_Message() => 
        //    this.message;

        //public DataTable Search(string key)
        //{
        //    base.Select("*");
        //    base.From(this.TBL_Master);
        //    string[] textArray1 = new string[] { "((Description LIKE '%", key, "%') OR (Id LIKE '%", key, "%'))" };
        //    base.Where(string.Concat(textArray1), true);
        //    return base.Get();
        //}

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

        //public DataTable Search_Get_All()
        //{

        //    comtable = null;
        //    MySqlParameter[] param = new MySqlParameter[1];

        //    param[0] = new MySqlParameter("@ide", MySqlDbType.VarChar, 30);
        //    param[0].Value = searchdate;
        //    if (OpenConnection())
        //    {
        //        comtable = SelectData("SerachRoute", param);
        //        sqlconnection.Close();
        //    }
        //    param = null;
        //    return comtable;
        //}

        //public DataTable Get_All()
        //{
        //    comtable = null;
        //    if (OpenConnection())
        //    {
        //        comtable = SelectData("AllRoute", null);
        //        sqlconnection.Close();
        //    }

        //    return comtable;
        //}


        public int Id
        {
            get {
                return this.routid;
            }
            set{
                this.routid = value;
            }
        }

        public string Fromrouat
        {
            get {
                return this.fromrouat;
            }
            set{
                this.fromrouat = value;
            }
        }//distr

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
        public string Distr
        {
            get
            {
                return this.distr;
            }
            set
            {
                this.distr = value;
            }
        }//distr

        public string Torouat
        {
            get
            {
                return this.torouat;
            }
            set
            {
                this.torouat = value;
            }
        }

        public long Shiftid
        {
            get{
                return this.shiftid;
            }
            set{
                this.shiftid = value;
            }
        }

       

        public DateTime Createdate
        {
            get{ 
              return   this.createdate;
            }
            set {
                this.createdate = value;
            }
        }

       

        public DateTime Accessdate
        {
            get {
             return    this.accessdate;
            }
            set {
                this.accessdate = value;
            }
        }

        //public string TBL_Master {
        //   "5_tbl_roots";
        //}
    }
}

