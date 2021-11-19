using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class Globals
    {
        public static string connect { get; private set; }
        public static void setConnect(String uname, String pass)
        {
            connect = @"Data Source=(localdb)\ProjectsV13;User ID=" + uname + ";Password=" + pass +
            "; initial Catalog=QuanLyKhachSan;integrated Security=true;";

        }
        public static string role { get; set; }
        public static int GlobalsUserID { get; private set; }
        public static void SetGlobalsUserID(int uid)
        {
            GlobalsUserID = uid;
        }
        public static User GlobalsUser { get; private set; }
        public static void SetGlobalsUser (User taikhoan)
        {
            GlobalsUser = taikhoan;
        }

    }
}
