using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SinhVien
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static Thread dangnhap;
        public static Thread dangki;
        public static Thread employee;
        [STAThread]
        static void Main()
        {
            dangnhap = new Thread(new ThreadStart(openSignIn));
            dangki = new Thread(new ThreadStart(openSignUp));
            employee = new Thread(new ThreadStart(Employee));
            employee.Start();
        }

        static void openSignIn()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignIn_Screen());
        }
        static void openSignUp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignUp_Screen());
        }
        static void Employee()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Employee_Screen());
        }

    }
}
