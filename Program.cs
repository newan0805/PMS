using Product_Management_System.Admin_Forms;
using Product_Management_System.Forms;
using Product_Management_System.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.FormLogin());
            /*Application.Run(new FormUsers());*/
            /*Application.Run(new TestInsert());*/
            /*Application.Run(new FormUserManagement());*/
        }
    }
}
