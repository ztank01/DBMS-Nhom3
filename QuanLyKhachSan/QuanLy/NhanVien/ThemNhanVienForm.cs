using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class ThemNhanVienForm : Form
    {
        public ThemNhanVienForm()
        {
            InitializeComponent();
        }

        MyDB mydb = new MyDB();

        private void themBt_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(idTb.Text);
                string username = userNameTb.Text;
                string password = passwordTb.Text;
                string hoTen = hoTenTb.Text;
                string role;
                if(radioButtonNhanVien.Checked == true)
                {
                    role = "NhanVien";
                }
                else
                {
                    role = "QuanLy";
                }
                string phone = sdtTb.Text;
                SqlCommand command = new SqlCommand("dbo.ThemTaiKhoan", mydb.GetConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                command.Parameters.Add("@UserName", SqlDbType.NChar).Value = username;
                command.Parameters.Add("@Password", SqlDbType.NChar).Value = password;
                command.Parameters.Add("@HoTen", SqlDbType.NChar).Value = hoTen;
                command.Parameters.Add("@Role", SqlDbType.NChar).Value = role;
                command.Parameters.Add("@Phone", SqlDbType.NChar).Value = phone;
                mydb.OpenConnection();
                if ((command.ExecuteNonQuery() == 1))
                {
                    mydb.CloseConnection();
                }
                else
                {
                    mydb.CloseConnection();
                }
                MessageBox.Show("Thêm Nhân Viên Thành Công", "Thêm Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm Nhân Viên Không Thành Công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void huyBt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
