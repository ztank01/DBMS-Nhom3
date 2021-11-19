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
    public partial class DanhSachDichVuForm : Form
    {
        public DanhSachDichVuForm()
        {
            InitializeComponent();
        }
        MyDB mydb = new MyDB();
        public static string maDV;
        public static string tenDV;
        public static string donGia;
        private void DanhSachDichVuForm_Load(object sender, EventArgs e)
        {
            SqlCommand commd = new SqlCommand("dbo.XemDanhSachDV");
            commd.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(commd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DanhSachDichVuDGV.ReadOnly = true;
            DanhSachDichVuDGV.RowTemplate.Height = 80;
            DanhSachDichVuDGV.DataSource = table;
            DanhSachDichVuDGV.AllowUserToAddRows = false;
        }

        private void duoiViecBt_Click(object sender, EventArgs e)
        {
            maDV = DanhSachDichVuDGV.CurrentRow.Cells[0].Value.ToString();
            tenDV = DanhSachDichVuDGV.CurrentRow.Cells[1].Value.ToString();
            donGia = DanhSachDichVuDGV.CurrentRow.Cells[2].Value.ToString();
            DatDichVuForm dichvu = new DatDichVuForm();
            dichvu.maDvTb.Text = idTb.Text;
            dichvu.Show();
            Close();
        }

        private void DanhSachDichVuDGV_Click(object sender, EventArgs e)
        {
            idTb.Text = DanhSachDichVuDGV.CurrentRow.Cells[0].Value.ToString();
        }

        private void chonBt_Click(object sender, EventArgs e)
        {
            maDV = DanhSachDichVuDGV.CurrentRow.Cells[0].Value.ToString();
            tenDV = DanhSachDichVuDGV.CurrentRow.Cells[1].Value.ToString();
            donGia = DanhSachDichVuDGV.CurrentRow.Cells[2].Value.ToString();
            if (Globals.role.Contains("NhanVien"))
            {
                DatDichVuForm dichvu = new DatDichVuForm();
                dichvu.maDvTb.Text = idTb.Text;
                dichvu.Show();
            }
            Close();
        }
    }
}
