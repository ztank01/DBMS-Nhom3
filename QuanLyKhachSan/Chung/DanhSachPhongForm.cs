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
    public partial class DanhSachPhongForm : Form
    {
        public DanhSachPhongForm()
        {
            InitializeComponent();
        }
        MyDB mydb = new MyDB();
        public static string maPhong;
        public static string soGiuong;
        public static string loai;
        public static string donGiaNgay;
        private void DanhSachPhongForm_Load(object sender, EventArgs e)
        {
            SqlCommand commd = new SqlCommand("dbo.XemDanhSachPhong");
            commd.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(commd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DanhSachPhongDGV.ReadOnly = true;
            DanhSachPhongDGV.RowTemplate.Height = 80;
            DanhSachPhongDGV.DataSource = table;
            DanhSachPhongDGV.AllowUserToAddRows = false;
        }

        private void DanhSachDichVuDGV_Click(object sender, EventArgs e)
        {
            idTb.Text = DanhSachPhongDGV.CurrentRow.Cells[0].Value.ToString();

        }

        private void chonBt_Click(object sender, EventArgs e)
        {
            maPhong = DanhSachPhongDGV.CurrentRow.Cells[0].Value.ToString();
            soGiuong = DanhSachPhongDGV.CurrentRow.Cells[1].Value.ToString();
            loai = DanhSachPhongDGV.CurrentRow.Cells[2].Value.ToString();
            donGiaNgay = DanhSachPhongDGV.CurrentRow.Cells[3].Value.ToString();
            if (Globals.role.Contains("NhanVien"))
            {
                DatDichVuForm dichvu = new DatDichVuForm();
                dichvu.maPhongTb.Text = idTb.Text;
                dichvu.Show();
            }
            Close();
        }
    }
}
