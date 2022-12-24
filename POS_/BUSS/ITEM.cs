using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_.BUSS
{
    class ITEM : DAT.DataAccessLayer
    {
        private long itemid;
        private string serialno;
        private string itemname;
        private decimal quantity;
        private double unitprice;
        private decimal dispercent;
        private double discount;
        private decimal profpercent;
        private string category;

        public long ID 
        {
            get { return this.itemid; } set { this.itemid = value; }
        }
        public string SERIALNO 
        {
            get { return this.serialno; } set { this.serialno = value; }
        }
        public string ITEMNAME
        {
            get { return this.itemname; } set { this.itemname = value; }
        }
        public decimal QUANTITY 
        {
            get { return this.quantity; } set { this.quantity = value; }
        }
        public double UNITPRICE 
        {
            get { return this.unitprice; } set { this.unitprice = value; }
        }
        public decimal DISPERCENT 
        {
            get { return this.dispercent; } set { this.dispercent = value; }
        }
        public double DISCOUNT 
        {
            get { return this.discount; } set { this.discount = value; }
        }
        public decimal PROFPERCENT 
        {
            get { return this.profpercent; } set { this.profpercent = value; }
        }
        public string CATEGORY
        {
            get { return this.category; } set { this.category = value; }
        }


        ///==========================================================================================================
      
    }


}
