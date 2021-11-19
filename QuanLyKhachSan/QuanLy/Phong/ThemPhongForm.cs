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
    public partial class ThemPhongForm : Form
    {
        public ThemPhongForm()
        {
            InitializeComponent();
        }

        MyDB mydb = new MyDB();

        private void themBt_Click(object sender, EventArgs e)
        {
            try
            {
                int maPhong = int.Parse(maPhongTb.Text);
                int soGiuong = int.Parse(soGiuongTb.Text);
                string loai = loaiTb.Text;
                int donGiaNgay = int.Parse(donGiaNgayTb.Text);
                SqlCommand command = new SqlCommand("dbo.ThemPhong", mydb.GetConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@maPhong", SqlDbType.Int).Value = maPhong;
                command.Parameters.Add("@soGiuong", SqlDbType.Int).Value = soGiuong;
                command.Parameters.Add("@loai", SqlDbType.NChar).Value = loai;
                command.Parameters.Add("@donGiaNgay", SqlDbType.Int).Value = donGiaNgay;
                mydb.OpenConnection();
                if ((command.ExecuteNonQuery() == 1))
                {
                    mydb.CloseConnection();
                }
                else
                {
                    mydb.CloseConnection();
                }
                MessageBox.Show("Thêm Phòng Thành Công", "Thêm Phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm Phòng Không Thành Công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void huyBt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
