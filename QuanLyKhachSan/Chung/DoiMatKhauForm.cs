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
    public partial class DoiMatKhauForm : Form
    {
        public DoiMatKhauForm()
        {
            InitializeComponent();
        }
        MyDB mydb = new MyDB();
        private void doiMatKhauBt_Click(object sender, EventArgs e)
        {
            int id = Globals.GlobalsUserID;
            string repass = repassTb.Text;
            string pass = PassTb.Text;
            if (verif())
            {
                try
                {

                    SqlCommand command = new SqlCommand("dbo.SuaTaiKhoan", mydb.GetConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = PassTb.Text.Trim() ;
                    command.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = Globals.GlobalsUser.HoTen.Trim();
                    command.Parameters.Add("@Role", SqlDbType.NVarChar).Value = Globals.GlobalsUser.Role.Trim();
                    command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Globals.GlobalsUser.Phone.Trim();
                    mydb.OpenConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        mydb.CloseConnection();

                    }
                    else
                    {
                        mydb.CloseConnection();

                    }
                    MessageBox.Show("Success", "Doi Mat Khau Thanh cong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error/n" + ex.Message, "Nhap sai Mat Khau old", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", " Khong duoc bo trong ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verif()
        {
            if ((PassTb.Text.Trim() == "") || (repassTb.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                if (PassTb.Text.Trim() == repassTb.Text.Trim())
                {
                    return true;
                }
                MessageBox.Show("Mật khẩu ở 2 ô phải giống nhau","Không trùng mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
