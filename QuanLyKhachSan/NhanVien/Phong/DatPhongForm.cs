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
    public partial class DatPhongForm : Form
    {
        public DatPhongForm()
        {
            InitializeComponent();
        }
        MyDB mydb = new MyDB();
       
        private void xacNhanBt_Click(object sender, EventArgs e)
        {
            
            int MaKhach = Int32.Parse(maKhachTb.Text);
            int MaPhong = Int32.Parse(maPhongTb.Text);
            DateTime NgayThue = NgayThueDTP.Value;
            DateTime NgayTra = NgayTraDTP.Value;
            int SoTien = Int32.Parse(daTraTb.Text);
            int SoNgay=0;
            if (NgayThue.Year == NgayTra.Year && NgayTra.Month == NgayThue.Month && NgayTra.Day != NgayThue.Day)
            {
                SoNgay = (NgayTra.Day - NgayThue.Day) ;
            }
            else if (NgayThue.Year == NgayTra.Year && NgayTra.Month != NgayThue.Month)
            {
                int song = 0;
                for (int i = NgayThue.Month + 1; i < NgayTra.Month; i++)
                {
                    song = song + DateTime.DaysInMonth(NgayTra.Year, i);
                }
                song = song + (DateTime.DaysInMonth(NgayThue.Year, NgayThue.Month) - NgayThue.Day) + NgayTra.Day;
                SoNgay = song ;
            }
            SqlCommand com = new SqlCommand("select * from Phong where MaPhong="+MaPhong, mydb.GetConnection);
            SqlDataAdapter adap = new SqlDataAdapter(com);
            DataTable tab = new DataTable();
            adap.Fill(tab);
            int GiaPhong= int.Parse(tab.Rows[0]["DonGiaNgay"].ToString());
            int TongTien = GiaPhong * SoNgay;
            int Conlai = TongTien - SoTien;
            int NvNhan = Globals.GlobalsUserID;
           
            if (verif())
            {
                try
                {
                    SqlCommand command = new SqlCommand("dbo.DATPHONG", mydb.GetConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@maKhach", SqlDbType.Int).Value = MaKhach;
                    command.Parameters.Add("@maPhong", SqlDbType.Int).Value = MaPhong;
                    command.Parameters.Add("@NgayDen", SqlDbType.DateTime).Value = NgayThue.ToString();
                    command.Parameters.Add("@NgayTra", SqlDbType.DateTime).Value = NgayTra.ToString();
                    command.Parameters.Add("@TongTien", SqlDbType.Int).Value = TongTien;
                    command.Parameters.Add("@SoTien", SqlDbType.Int).Value = SoTien;
                    command.Parameters.Add("@Conlai", SqlDbType.Int).Value = Conlai;
                    command.Parameters.Add("@Nhanvien", SqlDbType.Int).Value = NvNhan;

                    mydb.OpenConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        mydb.CloseConnection();
                    }
                    else
                    {
                        mydb.CloseConnection();
                    }
                    MessageBox.Show("Success", "Dat Phong Thanh Cong", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("Error", "Dat Phong that bai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", " Dat Phong That bai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((label1.Text.Trim() == "")|| (label2.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void huyBt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chonDSKhachBt_Click(object sender, EventArgs e)
        {
            SqlCommand commd = new SqlCommand("dbo.XemThongTinKhach");
            commd.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(commd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DanhSachKhachDGV.ReadOnly = true;
            DanhSachKhachDGV.RowTemplate.Height = 80;
            DanhSachKhachDGV.DataSource = table;
            DanhSachKhachDGV.AllowUserToAddRows = false;
        }

        private void chonDSPhongBt_Click(object sender, EventArgs e)
        {
            SqlCommand commd = new SqlCommand("select MaPhong, Loai, DonGiaNgay from Phong");
            commd.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(commd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DanhSachPhongDGV.ReadOnly = true;
            DanhSachPhongDGV.RowTemplate.Height = 80;
            DanhSachPhongDGV.DataSource = table;
            DanhSachPhongDGV.AllowUserToAddRows = false;
        }

        private void DanhSachKhachDGV_Click(object sender, EventArgs e)
        {
            maKhachTb.Text = DanhSachKhachDGV.CurrentRow.Cells[0].Value.ToString();
        }

        private void DanhSachPhongDGV_Click(object sender, EventArgs e)
        {
            maPhongTb.Text = DanhSachPhongDGV.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
