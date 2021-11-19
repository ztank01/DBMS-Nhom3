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
    public partial class XoaDichVu : Form
    {
        public XoaDichVu()
        {
            InitializeComponent();
        }

        MyDB mydb = new MyDB();

        private void LoadDanhSachDichVu()
        {
            SqlCommand command = new SqlCommand("select * from DichVu", mydb.GetConnection);
            SqlDataAdapter dap = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            dap.Fill(table);
            DanhSachDichVuDGV.DataSource = table;
        }

        private void XoaDichVu_Load(object sender, EventArgs e)
        {
            LoadDanhSachDichVu();
        }

        private void xoaPhongBt_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Dịch Vụ Này Không", "Xóa Dịch Vụ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int maDV = int.Parse(maDvTb.Text);
                    SqlCommand command = new SqlCommand("dbo.XoaDichVu", mydb.GetConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@MaDV", SqlDbType.Int).Value = maDV;
                    mydb.OpenConnection();
                    if ((command.ExecuteNonQuery() == 1))
                    {
                        mydb.CloseConnection();
                    }
                    else
                    {
                        mydb.CloseConnection();
                    }
                    MessageBox.Show("Xóa Dịch Vụ Thành Công", "Xóa Dịch Vụ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachDichVu();
                }
            }
            catch
            {
                MessageBox.Show("Xóa Dịch Vụ Không Thành Công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DanhSachDichVuDGV_Click(object sender, EventArgs e)
        {
            maDvTb.Text = DanhSachDichVuDGV.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
