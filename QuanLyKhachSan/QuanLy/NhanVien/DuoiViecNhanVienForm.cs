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
    public partial class DuoiViecNhanVienForm : Form
    {
        public DuoiViecNhanVienForm()
        {
            InitializeComponent();
        }

        MyDB mydb = new MyDB();

        private void LoadDanhSachNhanVien()
        {
            SqlCommand command = new SqlCommand("select * from TaiKhoan", mydb.GetConnection);
            SqlDataAdapter dap = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            dap.Fill(table);
            DanhSachNhanVienDGV.DataSource = table;
        }

        private void DuoiViecNhanVienForm_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
        }

        private void duoiViecBt_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Nhân Viên Này Không", "Xóa Nhân Viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int Id = int.Parse(idTb.Text);
                    SqlCommand command = new SqlCommand("dbo.XoaTaiKhoan", mydb.GetConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                    mydb.OpenConnection();
                    if ((command.ExecuteNonQuery() == 1))
                    {
                        mydb.CloseConnection();
                    }
                    else
                    {
                        mydb.CloseConnection();
                    }
                    MessageBox.Show("Xóa Nhân Viên Thành Công", "Xóa Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNhanVien();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xóa Nhân Viên Không Thành Công/n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DanhSachNhanVienDGV_Click(object sender, EventArgs e)
        {
            idTb.Text = DanhSachNhanVienDGV.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
