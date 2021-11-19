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
    public partial class DoiThongTinTaiKhoanForm : Form
    {
        public DoiThongTinTaiKhoanForm()
        {
            InitializeComponent();
        }
        MyDB mydb = new MyDB();
        private void xacNhanBt_Click(object sender, EventArgs e)
        {
            int id = Globals.GlobalsUserID;
            string hoten = hoTenTb.Text;
            string sdt = sdtTb.Text;
            if (verif())
            {
                try
                {

                    SqlCommand command = new SqlCommand("dbo.SuaTaiKhoan", mydb.GetConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Globals.GlobalsUser.password.Trim();
                    command.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = hoten.Trim();
                    command.Parameters.Add("@Role", SqlDbType.NVarChar).Value = Globals.GlobalsUser.Role.Trim();
                    command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = sdt.Trim() ;
                    mydb.OpenConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        mydb.CloseConnection();

                    }
                    else
                    {
                        mydb.CloseConnection();

                    }
                    MessageBox.Show("Success", "Doi Thong Tin Thanh cong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error", "Thay doi That bai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", " Khong duoc bo trong ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verif()
        {
            if ((label4.Text.Trim() == "") || (label5.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
