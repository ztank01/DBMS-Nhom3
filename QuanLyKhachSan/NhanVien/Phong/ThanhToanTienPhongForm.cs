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
    public partial class ThanhToanTienPhongForm : Form
    {
        public ThanhToanTienPhongForm()
        {
            InitializeComponent();
        }
        MyDB mydb = new MyDB();
        private void xacNhanBt_Click(object sender, EventArgs e)
        {
            
            int MaKhach = Int32.Parse(maKhachTb.Text);
            int MaPhong = Int32.Parse(maPhongTb.Text);
            int SoTienThanhToan = Int32.Parse(soTienTraTb.Text);
            bool XacNhan = true;
            if (verif())
            {
                try
                {

                    SqlCommand command = new SqlCommand("dbo.ThanhToan", mydb.GetConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@maKhach", SqlDbType.Int).Value = MaKhach;
                    command.Parameters.Add("@maPhong", SqlDbType.Int).Value = MaPhong;
                    command.Parameters.Add("@SoTienTra", SqlDbType.Int).Value = SoTienThanhToan;
                    command.Parameters.Add("@XacNhan", SqlDbType.Bit).Value = XacNhan;
                    mydb.OpenConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        mydb.CloseConnection();

                    }
                    else
                    {
                        mydb.CloseConnection();

                    }
                    MessageBox.Show("Thanh Toan Thanh Cong", "Thanh Toan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error", "Thanh Toan That Bai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", " Thanh Toan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((label5.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void chonDSKhachBt_Click(object sender, EventArgs e)
        {
            SqlCommand commd = new SqlCommand("dbo.DanhSachThue");
            commd.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(commd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DanhSachKhachDGV.ReadOnly = true;
            DanhSachKhachDGV.RowTemplate.Height = 80;
            DanhSachKhachDGV.DataSource = table;
            DanhSachKhachDGV.AllowUserToAddRows = false;
        }

        private void danhSachPhongBt_Click(object sender, EventArgs e)
        {
            
        }

        private void DanhSachKhachDGV_Click(object sender, EventArgs e)
        {
            maPhongTb.Text = DanhSachKhachDGV.CurrentRow.Cells[1].Value.ToString();
            maKhachTb.Text = DanhSachKhachDGV.CurrentRow.Cells[0].Value.ToString();
        }

        private void DanhSachPhongDGV_Click(object sender, EventArgs e)
        {
          
        }

        private void DanhSachKhachDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void huyBt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
