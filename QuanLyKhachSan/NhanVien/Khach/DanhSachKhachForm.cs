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
    public partial class DanhSachKhachForm : Form
    {
        public DanhSachKhachForm()
        {
            InitializeComponent();
        }
        MyDB mydb = new MyDB();
        string hoten;
        string phai;
        string Diachi;
        string quoctich;
        int Phong;
        int ngdaidien;
        
        private void duoiViecBt_Click(object sender, EventArgs e)
        {
            ChinhSuaThongTinKhachForm chinhsuakhach = new ChinhSuaThongTinKhachForm();
            chinhsuakhach.cmndtb.Text = idTb.Text;
            chinhsuakhach.userNameTb.Text = hoten;
            if (phai == "Nam")
            {
                chinhsuakhach.radioButton1.Checked = true;
            }
            else
            {
                chinhsuakhach.radioButton2.Checked = true;
            }
            chinhsuakhach.diachiTb.Text = Diachi;
            chinhsuakhach.Quoctichtb.Text = quoctich;
            chinhsuakhach.phongtb.Text = Phong.ToString();
            chinhsuakhach.ngdaidientb.Text = ngdaidien.ToString();
           
            Close();
            chinhsuakhach.Show();
        }

        private void DanhSachDichVuDGV_Click(object sender, EventArgs e)
        {
            idTb.Text = DanhSachDichVuDGV.CurrentRow.Cells[0].Value.ToString();
            hoten = DanhSachDichVuDGV.CurrentRow.Cells[1].Value.ToString();
            phai = DanhSachDichVuDGV.CurrentRow.Cells[2].Value.ToString();
            Diachi = DanhSachDichVuDGV.CurrentRow.Cells[3].Value.ToString();
            quoctich = DanhSachDichVuDGV.CurrentRow.Cells[4].Value.ToString();
            Phong = Int32.Parse(DanhSachDichVuDGV.CurrentRow.Cells[5].Value.ToString());
            ngdaidien = Int32.Parse(DanhSachDichVuDGV.CurrentRow.Cells[6].Value.ToString());
        }

        private void DanhSachKhachForm_Load(object sender, EventArgs e)
        {
            SqlCommand commd = new SqlCommand("dbo.XemThongTinKhach");
            commd.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(commd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DanhSachDichVuDGV.ReadOnly = true;
            DanhSachDichVuDGV.RowTemplate.Height = 80;
            DanhSachDichVuDGV.DataSource = table;
            DanhSachDichVuDGV.AllowUserToAddRows = false;
        }
    }
}
