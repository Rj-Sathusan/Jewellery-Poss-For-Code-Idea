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
     class additem : DAT.NewDataAccessLayer
    {

        //private string Message;
        public int id { get; set; }
        public string invoiceid { get; set; }
        public int itemid { get; set; }
        public double unitprice { get; set; }
        public decimal propercent { get; set; }
        public decimal quantity { get; set; }
        public double total { get; set; }
        public double profit { get; set; }
        public double linetotal { get; set; }
        public DateTime add_date { get; set; }
        public int userid { get; set; }
        public string Message{ get; set; }
        private long shif_id { get; set; }

        DAT.NewDataAccessLayer nda1 = new DAT.NewDataAccessLayer();


        public additem(int id, string invoiceid, int itemid, double unitprice, decimal propercent, decimal quantity, double total, double profit, double linetotal, DateTime add_date, int userid, long shif_id)
        {
            
            this.id = id;
            this.invoiceid = invoiceid;
            this.itemid = itemid;
            this.unitprice = unitprice;
            this.propercent = propercent;
            this.quantity = quantity;
            this.total = total;
            this.profit = profit;
            this.linetotal = linetotal;
            this.add_date = add_date;
            this.userid = userid;
            this.shif_id = shif_id;
            //this.Message = "";
        }

        public additem()
        {
        }

        public additem(int id, string invoiceid, int itemid, double unitprice, decimal propercent, decimal quantity, double total, double profit, double linetotal, DateTime add_date, int userid, string message) 
        {
            Message = message;
        }

        public additem(int id)
        {
            this.id = id;
        }

        public bool Create()
        {
            DAT.NewDataAccessLayer dat = new DAT.NewDataAccessLayer();
            MySqlParameter[] param = new MySqlParameter[12];

            param[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            param[0].Value = id;
            param[1] = new MySqlParameter("@invoiceno", MySqlDbType.Text, 150);
            param[1].Value = invoiceid;
            param[2] = new MySqlParameter("@itemid", MySqlDbType.Int32);
            param[2].Value = itemid;
            param[3] = new MySqlParameter("@unitprice", MySqlDbType.Double);
            param[3].Value = unitprice;
            param[4] = new MySqlParameter("@propercentage", MySqlDbType.Decimal);
            param[4].Value = propercent;
            param[5] = new MySqlParameter("@quantity", MySqlDbType.Decimal);
            param[5].Value = quantity;
            param[6] = new MySqlParameter("@total", MySqlDbType.Double);
            param[6].Value = total;
            param[7] = new MySqlParameter("@profit", MySqlDbType.Double);
            param[7].Value = profit;
            param[8] = new MySqlParameter("@linetotal", MySqlDbType.Double);
            param[8].Value = linetotal;
            param[9] = new MySqlParameter("@adddate", MySqlDbType.DateTime);
            param[9].Value = add_date;
            param[10] = new MySqlParameter("@userid", MySqlDbType.Int32);
            param[10].Value = userid;
            param[11] = new MySqlParameter("@shiftid0", MySqlDbType.Int64);
            param[11].Value = shif_id;

            if (dat.OpenConnection())
            {
                if (dat.ExecuteCommand("Addadditem", param))
                {
                    dat.CloseConnection();

                    this.Message = "Data Added";
                    param = null; dat = null;
                    return true;
                }
                else
                {
                    dat.CloseConnection();

                    this.Message = "Unable to add Data !";
                    param = null; dat = null;
                    return false;
                }
            }
            else
            {

                dat.CloseConnection();
                this.Message = "Server Not Connected !";
                param = null; dat = null;
                return false;
            }

        }

        public bool Modify()
        {
            DAT.NewDataAccessLayer dat = new DAT.NewDataAccessLayer();
            MySqlParameter[] param = new MySqlParameter[11];

            param[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            param[0].Value = id;
            param[1] = new MySqlParameter("@invoiceno", MySqlDbType.Text, 150);
            param[1].Value = invoiceid;
            param[2] = new MySqlParameter("@itemid", MySqlDbType.Int32);
            param[2].Value = itemid;
            param[3] = new MySqlParameter("@unitprice", MySqlDbType.Double);
            param[3].Value = unitprice;
            param[4] = new MySqlParameter("@propercent", MySqlDbType.Decimal);
            param[4].Value = propercent;
            param[5] = new MySqlParameter("@quantity", MySqlDbType.Decimal);
            param[5].Value = quantity;
            param[6] = new MySqlParameter("@total", MySqlDbType.Double);
            param[6].Value = total;
            param[7] = new MySqlParameter("@profit", MySqlDbType.Double);
            param[7].Value = profit;
            param[8] = new MySqlParameter("@linetotal", MySqlDbType.Double);
            param[8].Value = linetotal;
            param[9] = new MySqlParameter("@add_date", MySqlDbType.DateTime);
            param[9].Value = linetotal;
            param[10] = new MySqlParameter("@userid", MySqlDbType.Int32);
            param[10].Value = userid;

            if (dat.OpenConnection())
            {
                if (dat.ExecuteCommand("Updateadditem", param))
                {
                    dat.CloseConnection();

                    this.Message = "Data Updated";
                    param = null; dat = null;
                    return true;
                }
                else
                {
                    dat.CloseConnection();

                    this.Message = "Unable to update Data !";
                    param = null; dat = null;
                    return false;
                }
            }
            else
            {

                dat.CloseConnection();
                this.Message = "Server Not Connected !";
                param = null; dat = null;
                return false;
            }

        }

        public bool Remove()
        {
            DAT.NewDataAccessLayer dat = new DAT.NewDataAccessLayer();
            MySqlParameter[] param = new MySqlParameter[3];

            param[0] = new MySqlParameter("@id0", MySqlDbType.Int32);
            param[0].Value = id;


            if (dat.OpenConnection())
            {
                if (dat.ExecuteCommand("Deleteadditem", param))
                {
                    dat.CloseConnection();

                    this.Message = "Data successfully deleted !";
                    param = null; dat = null;
                    return true;
                }
                else
                {
                    dat.CloseConnection();

                    this.Message = "Can't Delete";
                    param = null; dat = null;
                    return false;
                }
            }
            else
            {

                dat.CloseConnection();
                this.Message = "Server Not Connected !";
                param = null; dat = null;
                return false;
            }

        }

        public DataTable GetAllItem()
        {
            comtable = null;
            if (OpenConnection())
            {
                comtable = SelectData("ItemBindinAdditem", null);
                sqlconnection.Close();
            }
            return comtable;
        }

        public bool
          getcomboitemdetail(TextBox txt, TextBox txt2)
        {


            MySqlParameter[] param = new MySqlParameter[3];
            param[0] = new MySqlParameter("@itemid0", MySqlDbType.Int32);
            param[0].Value = id;
            param[1] = new MySqlParameter("@unitprice0", MySqlDbType.Double);
            param[1].Direction = ParameterDirection.Output;
            param[2] = new MySqlParameter("@profirper0", MySqlDbType.Double);
            param[2].Direction = ParameterDirection.Output;



            if (OpenConnection())
            {

                if (ExecuteCommand("getcomboitemdetail", param))
                {
                    txt.Text = param[1].Value.ToString();
                    txt2.Text = param[2].Value.ToString();
                    CloseConnection();
                    param = null;

                    return true;
                }
                else
                {

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


    }

    
}
