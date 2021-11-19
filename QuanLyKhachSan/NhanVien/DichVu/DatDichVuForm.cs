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
    public partial class DatDichVuForm : Form
    {
        public DatDichVuForm()
        {
            InitializeComponent();
        }
        MyDB mydb = new MyDB();
        private void xacNhanBt_Click(object sender, EventArgs e)
        {
            int MaDV = Int32.Parse(maDvTb.Text);
            int MaPhong = Int32.Parse(maPhongTb.Text);
            int SoLuong = (int)soLuongNUD.Value;
            if (verif())
            {
                try
                {
                    
                    SqlCommand command = new SqlCommand("dbo.DatDichVu", mydb.GetConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@maPhong", SqlDbType.Int).Value = MaPhong;
                    command.Parameters.Add("@maDV", SqlDbType.Int).Value = MaDV;
                    command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = SoLuong;


                    mydb.OpenConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        mydb.CloseConnection();

                    }
                    else
                    {
                        mydb.CloseConnection();

                    }
                    
                    SqlCommand com = new SqlCommand("select * from HoaDon where MaPhong="+ MaPhong+"and MaDV="+MaDV, mydb.GetConnection);
                    SqlDataAdapter adap = new SqlDataAdapter(com);
                    DataTable tab = new DataTable();
                    adap.Fill(tab);
                    thanhtientb.Text = tab.Rows[0]["ThanhTien"].ToString();
                    DatDichVuForm dichvu = new DatDichVuForm();
                    
                    MessageBox.Show("Success", "Dat Dich Vu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch 
                {
                    MessageBox.Show("Error", "Dat Dich Vu that bai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", " Dat Dich Vu That bai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            /* SqlCommand commd = new SqlCommand("SELECT * from HoaDon where MaDV=" + MaDV + "and MaPhong=" + MaPhong);
             commd.Connection = mydb.getConnection;
             SqlDataAdapter adapter = new SqlDataAdapter(commd);
             DataTable table = new DataTable();
             thanhtientb.Text = table.Rows[0]["ThanhTien"].ToString();
             Console.WriteLine(table.Rows[0]["ThanhTien"].ToString());
 */
        }
        bool verif()
        {
            if ((label1.Text.Trim() == "")|| (label2.Text.Trim() == "")|| (label3.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void chonDSDichVuBt_Click(object sender, EventArgs e)
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

        private void chonDSPhongBt_Click(object sender, EventArgs e)
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            maPhongTb.Text= DanhSachPhongDGV.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            maDvTb.Text= DanhSachDichVuDGV.CurrentRow.Cells[0].Value.ToString();
        }

        private void DanhSachPhongDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void huyBt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
