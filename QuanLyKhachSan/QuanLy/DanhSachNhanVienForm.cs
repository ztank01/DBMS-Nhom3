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
    public partial class DanhSachNhanVienForm : Form
    {
        public DanhSachNhanVienForm()
        {
            InitializeComponent();
        }

        MyDB mydb = new MyDB();
        public static string Id;
        public static string username;
        public static string password;
        public static string hoTen;
        public static string role;
        public static string phone;

        private void duoiViecBt_Click(object sender, EventArgs e)
        {
            Id = DanhSachNhanVienDGV.CurrentRow.Cells[0].Value.ToString();
            username = DanhSachNhanVienDGV.CurrentRow.Cells[1].Value.ToString();
            password = DanhSachNhanVienDGV.CurrentRow.Cells[2].Value.ToString();
            hoTen = DanhSachNhanVienDGV.CurrentRow.Cells[3].Value.ToString();
            role = DanhSachNhanVienDGV.CurrentRow.Cells[4].Value.ToString();
            phone = DanhSachNhanVienDGV.CurrentRow.Cells[5].Value.ToString();
            Close();
        }

        private void DanhSachNhanVienForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from TaiKhoan", mydb.GetConnection);
            SqlDataAdapter dap = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            dap.Fill(table);
            DanhSachNhanVienDGV.DataSource = table;
        }

        private void DanhSachNhanVienDGV_Click(object sender, EventArgs e)
        {
            idTb.Text = DanhSachNhanVienDGV.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
