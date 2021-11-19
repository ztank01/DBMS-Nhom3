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
    public partial class DanhGiaForm : Form
    {
        public DanhGiaForm()
        {
            InitializeComponent();
        }
        MyDB mydb = new MyDB();
       
        private void soSaoCbB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void xacNhanBt_Click(object sender, EventArgs e)
        {
            int MaKhach = Int32.Parse(maKhachTb.Text);
            int SoSao = Int32.Parse(soSaoCbB.Text);
            string Nhanxet = nhanXetTb.Text;

            int NvNhan = Globals.GlobalsUserID;
            Console.WriteLine(NvNhan);
            if (verif())
            {
                try
                {

                    SqlCommand command = new SqlCommand("dbo.DanhGia", mydb.GetConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@maKhach", SqlDbType.Int).Value = MaKhach;
                    command.Parameters.Add("@sosao", SqlDbType.Int).Value = SoSao;
                    command.Parameters.Add("@Nhanxet", SqlDbType.NVarChar).Value = Nhanxet;
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
                    MessageBox.Show("Success", "Danh Gia Thanh Cong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error", "Danh Gia that bai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", " Danh Gia That bai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((label1.Text.Trim() == "") || (label3.Text.Trim() == ""))
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
            SqlCommand commd = new SqlCommand("dbo.XemDanhSachKhach");
            commd.CommandType = CommandType.StoredProcedure;
            commd.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(commd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DanhSachKhachDGV.ReadOnly = true;
            DanhSachKhachDGV.RowTemplate.Height = 80;
            DanhSachKhachDGV.DataSource = table;
            DanhSachKhachDGV.AllowUserToAddRows = false;
        }

        private void DanhSachKhachDGV_Click(object sender, EventArgs e)
        {
            maKhachTb.Text = DanhSachKhachDGV.CurrentRow.Cells[0].Value.ToString();
        }

        private void huyBt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
