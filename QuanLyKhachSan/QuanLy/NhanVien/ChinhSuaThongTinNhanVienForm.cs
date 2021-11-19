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
    public partial class ChinhSuaThongTinNhanVienForm : Form
    {
        public ChinhSuaThongTinNhanVienForm()
        {
            InitializeComponent();
        }

        MyDB mydb = new MyDB();

        private void xacNhanBt_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(idTb.Text);
                string username = userNameTb.Text;
                string password = passwordTb.Text;
                string hoTen = hoTenTb.Text;
                string role;
                if (radioButtonNhanVien.Checked == true)
                {
                    role = "NhanVien";
                }
                else
                {
                    role = "QuanLy";
                }
                string phone = sdtTb.Text; ;
                SqlCommand command = new SqlCommand("dbo.SuaTaiKhoan", mydb.GetConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                command.Parameters.Add("@Password", SqlDbType.NChar).Value = password.Trim();
                command.Parameters.Add("@HoTen", SqlDbType.NChar).Value = hoTen.Trim();
                command.Parameters.Add("@Role", SqlDbType.NChar).Value = role.Trim();
                command.Parameters.Add("@Phone", SqlDbType.NChar).Value = phone.Trim();
                mydb.OpenConnection();
                if ((command.ExecuteNonQuery() == 1))
                {
                    mydb.CloseConnection();
                }
                else
                {
                    mydb.CloseConnection();
                }
                MessageBox.Show("Sửa Thông Tin Nhân Viên Thành Công", "Sửa Thông Tin Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                idTb.Text = "";
                userNameTb.Text = "";
                passwordTb.Text = "";
                hoTenTb.Text = "";
                sdtTb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa Thông Tin Nhân Viên Không Thành Công/n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void huyBt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chonDSNhanVienBt_Click(object sender, EventArgs e)
        {
            DanhSachNhanVienForm form = new DanhSachNhanVienForm();
            form.ShowDialog();
            idTb.Text = DanhSachNhanVienForm.Id;
            userNameTb.Text = DanhSachNhanVienForm.username;
            passwordTb.Text = DanhSachNhanVienForm.password;
            hoTenTb.Text = DanhSachNhanVienForm.hoTen;
            try
            {
                if (DanhSachNhanVienForm.role.Trim() == "NhanVien")
                {
                    radioButtonNhanVien.Checked = true;
                }
                else
                {
                    radioButtonQuanLy.Checked = true;
                }
            }
            catch
            { }
            sdtTb.Text = DanhSachNhanVienForm.phone;
        }
    }
}
