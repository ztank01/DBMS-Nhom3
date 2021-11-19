using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm fLogin = new LoginForm();
            DialogResult result = new DialogResult();
            result = fLogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                Application.Run(new QuanLyMainForm());
            }
            else
            {
                if (result == DialogResult.Yes)
                {
                    Application.Run(new NhanVienMainForm());
                }
                else
                    Application.Exit();
            }               
        }
    }
}
