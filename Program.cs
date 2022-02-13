using PointofSaleSoftware.Screens.ProductsF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointofSaleSoftware
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
            //Application.Run(new Screens.ProductsF.frmPurchase());
            Application.Run(new frmSearchPurchase());
        }
    }
}
