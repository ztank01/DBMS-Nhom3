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
    public partial class XoaPhongForm : Form
    {
        public XoaPhongForm()
        {
            InitializeComponent();
        }

        MyDB mydb = new MyDB();

        private void xoaPhongBt_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Phòng Này Không", "Xóa Phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int maPhong = int.Parse(maPhongTb.Text);
                    SqlCommand command = new SqlCommand("dbo.XoaPhong", mydb.GetConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@maPhong", SqlDbType.Int).Value = maPhong;
                    mydb.OpenConnection();
                    if ((command.ExecuteNonQuery() == 1))
                    {
                        mydb.CloseConnection();
                    }
                    else
                    {
                        mydb.CloseConnection();
                    }
                    MessageBox.Show("Xóa Phòng Thành Công", "Xóa Phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachPhong();
                }
            }
            catch 
            { 
                MessageBox.Show("Xóa Phòng Không Thành Công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void LoadDanhSachPhong()
        {
            SqlCommand command = new SqlCommand("select * from Phong", mydb.GetConnection);
            SqlDataAdapter dap = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            dap.Fill(table);
            DanhSachPhongDGV.DataSource = table;
        }

        private void XoaPhongForm_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhong();
        }

        private void DanhSachPhongDGV_Click(object sender, EventArgs e)
        {
            maPhongTb.Text = DanhSachPhongDGV.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
