using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace POS_.BUS
{
    class Category
    {
        public long _Categoryid { get; set; }
        public long _asgid { get; set; }
        public long _esgid { get; set; }
       
        public string _CategoryName { get; set; }
     //  public long   { get; set; }
        public  DateTime _createdate { get; set; }
        public Int32 _BranceId { get; set; }
        public long _Shiftid { get; set; }
        public int savecheck { get; set; }
        //public Category(Int32 catid,string catname,Int32 userid,DateTime cdate,Int32 branchid,Int32 shiftid)
        //{

        //    _Categoryid = catid; _CategoryName = catname; _Userid = userid; _createdate = cdate; _BranceId = branchid; _Shiftid = shiftid;
        //}

        public void AddNewFastival()
        {
            savecheck = 0;
            DAT.DataAccessLayer dat = new DAT.DataAccessLayer();

            MySqlParameter[] param = new MySqlParameter[5];
            param[0] = new MySqlParameter("@des", MySqlDbType.VarChar, 100);
            param[0].Value = _CategoryName;

            param[1] = new MySqlParameter("@shiftid", MySqlDbType.Int64);
            param[1].Value = _Shiftid;

            param[2] = new MySqlParameter("@date1", MySqlDbType.DateTime);
            param[2].Value = _createdate.ToString("yyyy-MM-dd");

            param[3] = new MySqlParameter("@branceid", MySqlDbType.Int32);
            param[3].Value = _BranceId;
            param[4] = new MySqlParameter("@caid", MySqlDbType.Int64);
            param[4].Direction = ParameterDirection.Output;
            dat.Open();
            dat.ExecuteCommand("AddNewFastival", param);
            dat.Close();
            savecheck = 1;
            dat = null;
        }

        public void DeleteFastival()
        {
            DAT.DataAccessLayer dat = new DAT.DataAccessLayer();

            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@ide", MySqlDbType.Int64);
            param[0].Value = _Categoryid;
            dat.Open();
            dat.ExecuteCommand("DeleteFastival", param);
            dat.Close();
            dat = null;
        }

        public void SearchFistival(DataGridView dgv)
        {
            function fun = new function();
            DAT.DataAccessLayer dat = new DAT.DataAccessLayer();
            //  DAT.DataAccessLayer dat = new DAT.DataAccessLayer();

            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("@dese", MySqlDbType.VarChar, 100);
            param[0].Value = _CategoryName;
            dat.Open();
            fun.BindGrid(dgv, dat.SelectData("SearchFistival", param));
            dat.Close();
            fun = null; dat = null;
        }
        public void EditFastival()
        {
            DAT.DataAccessLayer dat = new DAT.DataAccessLayer();

            MySqlParameter[] param = new MySqlParameter[2];
            param[0] = new MySqlParameter("@des", MySqlDbType.VarChar, 100);
            param[0].Value = _CategoryName;


            param[1] = new MySqlParameter("@ide", MySqlDbType.Int64);
            param[1].Value = _Categoryid;
            dat.Open();
            dat.ExecuteCommand("EditFastival", param);
            dat.Close();
            dat = null;
        }

        public void BindDatagridviewFastival(DataGridView dgv)
        {
            function fun = new function();
            DAT.DataAccessLayer dat = new DAT.DataAccessLayer();
            dat.Open();
            fun.BindGrid(dgv, dat.SelectData("DisplayAllFastival", null));
            dat.Close();
            fun = null; dat = null;
        }
        public void AddCategory()
        {

            DAT.NewDataAccessLayer dat = new DAT.NewDataAccessLayer();
          
            MySqlParameter[] param = new MySqlParameter[5];
            param[0] = new MySqlParameter("@des", MySqlDbType.VarChar, 100);
            param[0].Value = _CategoryName;

            param[1] = new MySqlParameter("@shiftid", MySqlDbType.Int64);
            param[1].Value = _Shiftid;

            param[2] = new MySqlParameter("@date1", MySqlDbType.DateTime);
            param[2].Value = _createdate.ToString("yyyy-MM-dd");

            param[3] = new MySqlParameter("@branceid", MySqlDbType.Int32);
            param[3].Value = _BranceId;
            param[4] = new MySqlParameter("@caid", MySqlDbType.Int64);
            param[4].Direction = ParameterDirection.Output;

            if (dat.OpenConnection())
            {

                if (dat.ExecuteCommand("AddCategory", param))
                {
                    dat.ShowMessage("Data Saved Successfully", "Warning");
                    dat.CloseConnection(); 
                    dat = null; param = null;
                 
                }
                else
                {
                    dat.ShowMessage("Duplicate entry  " + _CategoryName + "", "Warning");
                    dat = null; param = null;
                  
                }
             
            }
            else
            {
                dat = null; param = null;
              
            }
            
        }

        public void AdduseCategory()
        {
            DAT.DataAccessLayer dat = new DAT.DataAccessLayer();

            MySqlParameter[] param = new MySqlParameter[6];
            param[0] = new MySqlParameter("@des", MySqlDbType.VarChar, 100);
            param[0].Value = _CategoryName;

            param[1] = new MySqlParameter("@shiftid1", MySqlDbType.Int64);
            param[1].Value = _Shiftid;

            param[2] = new MySqlParameter("@date1", MySqlDbType.DateTime);
            param[2].Value = _createdate.ToString("yyyy-MM-dd");

            param[3] = new MySqlParameter("@branceid", MySqlDbType.Int32);
            param[3].Value = _BranceId;

            param[4] = new MySqlParameter("@acid", MySqlDbType.Int64);
            param[4].Direction = ParameterDirection.Output;

            param[5] = new MySqlParameter("@exid", MySqlDbType.Int64);
            param[5].Direction = ParameterDirection.Output;
         
            dat.Open();
            dat.ExecuteCommand("AdduseCategory", param);
            dat.Close();
            dat = null;
        }

        public void EditUsedCategory()
        {
            DAT.DataAccessLayer dat = new DAT.DataAccessLayer();

            MySqlParameter[] param = new MySqlParameter[4];
            param[0] = new MySqlParameter("@des1", MySqlDbType.VarChar, 100);
            param[0].Value = _CategoryName;

            param[1] = new MySqlParameter("@ide", MySqlDbType.Int64);
            param[1].Value = _Categoryid;

            param[2] = new MySqlParameter("@acid", MySqlDbType.Int64);
            param[2].Value = _asgid;

            param[3] = new MySqlParameter("@exid", MySqlDbType.Int64);
            param[3].Value = _esgid;
         
            dat.Open();
            dat.ExecuteCommand("EditUsedCategory", param);
            dat.Close();
            dat = null;
        }


        public void EditCategory()
        {
            DAT.NewDataAccessLayer dat = new DAT.NewDataAccessLayer();
          
            MySqlParameter[] param = new MySqlParameter[2];
            param[0] = new MySqlParameter("@des", MySqlDbType.VarChar, 100);
            param[0].Value = _CategoryName;
           
            param[1] = new MySqlParameter("@ide", MySqlDbType.Int64);
            param[1].Value = _Categoryid;


            if (dat.OpenConnection())
            {

                if (dat.ExecuteCommand("EditCategory", param))
                {
                    dat.ShowMessage("Data Saved Successfully", "Warning");
                    dat.CloseConnection(); dat = null; param = null;
                    
                }
                else
                {
                    dat.ShowMessage("Duplicate entry  " + _CategoryName + "", "Warning");
                    dat = null; param = null;
                    
                }

            }
            else
            {
                dat = null; param = null;
                
            }
        }

        public void DeleteCategory()
        {
            DAT.NewDataAccessLayer dat = new DAT.NewDataAccessLayer();
            
            MySqlParameter[] param = new MySqlParameter[1];

            param[0] = new MySqlParameter("@ide", MySqlDbType.Int64);
            param[0].Value = _Categoryid;

            if (dat.OpenConnection())
            {
                if (dat.ExecuteCommand("DeleteCategory", param))
                {
                    dat.ShowMessage("Deleted successfully", "Warning");
                    dat.CloseConnection();
                    dat = null; param = null;
               
                }
                else
                {

                    dat.ShowMessage("You can't delete this category !!!", "Warning");
                    dat.CloseConnection(); 
                    dat = null; param = null;
                }
                
            }
            else
            {
                dat = null; param = null;
               
            }
           
        }

        public void BindDatagridview(DataGridView dgv)
        {
            DAT.NewDataAccessLayer dat = new DAT.NewDataAccessLayer();

            if (dat.OpenConnection())
            {
               dat.BindGrid(dgv, dat.SelectData("DisplayAllCategory", null));
               dat.CloseConnection();
            }

            dat = null;
        }

        public void BindDatagridviewuseItem(DataGridView dgv)
        {
            function fun = new function();
            DAT.DataAccessLayer dat = new DAT.DataAccessLayer();
            dat.Open();
            fun.BindGrid(dgv, dat.SelectData("DisplayAllUsedCategory", null));
            dat.Close();
            fun = null; dat = null;
        }

      
        public void SearchBindDatagridview(DataGridView dgv)
        {
            DAT.NewDataAccessLayer dat = new DAT.NewDataAccessLayer();
          
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("@dese", MySqlDbType.VarChar, 100);
            param[0].Value = _CategoryName;

            if (dat.OpenConnection())
            {
                dat.BindGrid(dgv, dat.SelectData("SearchCategory", param));
               
                dat.CloseConnection();
                dat = null;
            }
          
        }

        public void SearchUsedBindDatagridview(DataGridView dgv)
        {
            function fun = new function();
            DAT.DataAccessLayer dat = new DAT.DataAccessLayer();
            //  DAT.DataAccessLayer dat = new DAT.DataAccessLayer();

            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("@dese", MySqlDbType.VarChar, 100);
            param[0].Value = _CategoryName;
            dat.Open();
            fun.BindGrid(dgv, dat.SelectData("SearchUsedCategory", param));
            dat.Close();
            fun = null; dat = null;
        }
    }
}
