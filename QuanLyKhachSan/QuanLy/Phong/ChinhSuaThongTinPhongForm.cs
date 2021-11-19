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
    public partial class ChinhSuaThongTinPhongForm : Form
    {
        public ChinhSuaThongTinPhongForm()
        {
            InitializeComponent();
        }

        MyDB mydb = new MyDB();

        private void chonDSPhongBt_Click(object sender, EventArgs e)
        {
            DanhSachPhongForm form = new DanhSachPhongForm();
            form.ShowDialog();
            maPhongTb.Text = DanhSachPhongForm.maPhong;
            soGiuongTb.Text = DanhSachPhongForm.soGiuong;
            loaiTb.Text = DanhSachPhongForm.loai;
            donGiaNgayTb.Text = DanhSachPhongForm.donGiaNgay;
        }

        private void themBt_Click(object sender, EventArgs e)
        {
            try
            {
                int maPhong = int.Parse(maPhongTb.Text);
                int soGiuong = int.Parse(soGiuongTb.Text);
                string loai = loaiTb.Text;
                int donGiaNgay = int.Parse(donGiaNgayTb.Text);
                SqlCommand command = new SqlCommand("dbo.SuaPhong", mydb.GetConnection);
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
                MessageBox.Show("Sửa Phòng Thành Công", "Sửa Phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maPhongTb.Text = "";
                soGiuongTb.Text = "";
                loaiTb.Text = "";
                donGiaNgayTb.Text = "";
            }
            catch
            {
                MessageBox.Show("Sửa Phòng Không Thành Công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void huyBt_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
