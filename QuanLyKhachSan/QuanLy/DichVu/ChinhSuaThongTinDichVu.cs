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
    public partial class ChinhSuaThongTinDichVu : Form
    {
        public ChinhSuaThongTinDichVu()
        {
            InitializeComponent();
        }

        MyDB mydb = new MyDB();


        private void themBt_Click(object sender, EventArgs e)
        {
            try
            {
                int maDV = int.Parse(maDvTb.Text);
                string tenDV = tenDvTb.Text;
                int donGia = int.Parse(donGiaTb.Text);
                SqlCommand command = new SqlCommand("dbo.SuaDichVu", mydb.GetConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MaDV", SqlDbType.Int).Value = maDV;
                command.Parameters.Add("@TenDV", SqlDbType.NChar).Value = tenDV;
                command.Parameters.Add("@DonGia", SqlDbType.Int).Value = donGia;
                mydb.OpenConnection();
                if ((command.ExecuteNonQuery() == 1))
                {
                    mydb.CloseConnection();
                }
                else
                {
                    mydb.CloseConnection();
                }
                MessageBox.Show("Sửa Dịch Vụ Thành Công", "Sửa Dịch Vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maDvTb.Text = "";
                tenDvTb.Text = "";
                donGiaTb.Text = "";
            }
            catch
            {
                MessageBox.Show("Sửa Dịch Vụ Không Thành Công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chonDSDichVuBt_Click(object sender, EventArgs e)
        {
            DanhSachDichVuForm form = new DanhSachDichVuForm();
            form.ShowDialog();
            maDvTb.Text = DanhSachDichVuForm.maDV;
            tenDvTb.Text = DanhSachDichVuForm.tenDV;
            donGiaTb.Text = DanhSachDichVuForm.donGia;
        }

        private void huyBt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
