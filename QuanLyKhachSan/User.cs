using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class User
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string HoTen { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }

        public User(int id, string uname, string pass, string ten, string role, string phn)
        {
            this.Id = id;
            this.userName = uname;
            this.password = pass;
            this.HoTen = ten;
            this.Role = role;
            this.Phone = phn;
        }
    }
}
