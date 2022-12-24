using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_
{
    static class Program
    {
        /// <summary>
        ///// The main entry Point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1("1", "1"));
            Application.Run(new PRE.DRESS());
        }
    }
}
