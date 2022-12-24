using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace POS_
{
    public class Connection
    {
        public static string connString = BUSS.Config.ConnectionString; //@"server=127.0.0.1;user id=root;database=com_system;default command timeout=1000";//accountposforonline

      // public static string connString = @"database='com_system'; datasource='192.168.1.15'; username='root'; password='12345';default command timeout=1000";//
    
    }
}
