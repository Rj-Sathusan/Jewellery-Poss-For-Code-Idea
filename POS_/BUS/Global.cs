using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace POS_.BUS
{
    static class Global
    {
        public static string fastival = System.IO.File.ReadAllText(Application.StartupPath + @"\festival.txt", Encoding.UTF8);

        public static string shopname="";
        public static string address="";
        public static string mobile;
        public static string land;
        public static string email="";
        public static string web;
        public static string greting;
        public static string partno;

        public static string PrinterPos="";
        public static string PrinterDot = "";
        public static string BarcodePrinter = "";

       // public static string invoicebottomdesc ="EXCHANGE ACCEPTED WITHIN 3 DAYS ";
       // public static string subinvoicebottomdesc = " WITH ORIGINAL RECEIPT ";

         public static string invoicebottomdesc ="";
         public static string subinvoicebottomdesc = "";

        public static string exheading = "";
        public static string exsuheding = "  ";
        public static string exdetails = " ";


        public static string com = "";
        public static string poleactive;
        public static string printmasage;
        public static string savemasage;
        public static string invoicediscount;
        public static string loyaltiactive;
        public static string commisionactive;


        public static string polecom="0"; // if condision  !="0"
        public static string poledescription = "NEXT CUSTOMER PLEASE";

        public static DataTable allitems;
        public static DataTable bankforcard;
        public static DataTable addminyearviessave;
        public static DataTable bankforqrcode;
        public static DataTable bankforbankname;
        public static DataTable tobank;





    }
}
