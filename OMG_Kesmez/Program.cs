using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
# gia war hier
namespace OMG_Kesmez
{
    internal static class Program
    {
        private static IModel Model;
        private static IView View;
        private static IController Controller;
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View());
            //Hallo Ömer
        }
    }
}
