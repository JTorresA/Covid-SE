using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_SE
{
    static class Program
    {
        public static formInicio F1 = null;
        public static Covid_SE F2 = null;
        public static formRes F3 = null;

        public static string _diagnostico = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formInicio());
        }
    }
}
