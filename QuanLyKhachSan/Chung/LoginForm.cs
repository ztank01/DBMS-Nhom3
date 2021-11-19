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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void dangNhapBt_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.setConnect(usernameTb.Text, passwordTb.Text);
                MyDB db = new MyDB();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM TaiKhoan WHERE " +
                    "UserName = @user AND Password = @pass", db.GetConnection);
                command.Parameters.Add("@user", SqlDbType.VarChar).Value = usernameTb.Text;
                command.Parameters.Add("@pass", SqlDbType.VarChar).Value = passwordTb.Text;
                adapter.SelectCommand = command;

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    Globals.role = table.Rows[0][4].ToString();
                    User DangDangNhap = new User(
                                int.Parse(table.Rows[0][0].ToString()),
                                table.Rows[0][1].ToString(),
                                table.Rows[0][2].ToString(),
                                table.Rows[0][3].ToString(),
                                table.Rows[0][4].ToString(),
                                table.Rows[0][5].ToString()
                        );
                    Globals.SetGlobalsUser(DangDangNhap);
                    if (Globals.role.Contains("QuanLy"))
                        this.DialogResult = DialogResult.OK;
                    else
                    {
                        Globals.SetGlobalsUserID(int.Parse(table.Rows[0][0].ToString()));
                        this.DialogResult = DialogResult.Yes;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username of password", "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Error" ,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void huyBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
