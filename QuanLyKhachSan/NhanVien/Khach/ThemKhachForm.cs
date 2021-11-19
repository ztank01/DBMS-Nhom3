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
    public partial class ThemKhachForm : Form
    {
        public ThemKhachForm()
        {
            InitializeComponent();
        }

        private void ThemKhachForm_Load(object sender, EventArgs e)
        {

        }
        MyDB mydb = new MyDB();
        
        private void xacNhanBt_Click(object sender, EventArgs e)
        {
  
            int cmnd = Int32.Parse(cmndtb.Text);
            string hoten = userNameTb.Text;
            string phai = "Nam";
            if (radioButton2.Checked)
            {
                phai = "Nu";
            }
            string diachi = diachiTb.Text;
            string quoctich = Quoctichtbox.Text;
            int phong = Convert.ToInt32(phongtb.Text);
            int ngdaidien = Int32.Parse(ngdaidientb.Text);
            int idnv = Globals.GlobalsUserID;
            if (verif())
            {
                try
                {

                    SqlCommand command = new SqlCommand("dbo.ThemKhach", mydb.GetConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@cmnd", SqlDbType.Int).Value = cmnd;
                    command.Parameters.Add("@hoten ", SqlDbType.NVarChar).Value = hoten;
                    command.Parameters.Add("@phai", SqlDbType.NVarChar).Value = phai;
                    command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
                    command.Parameters.Add("@Quoctich", SqlDbType.NVarChar).Value = quoctich;
                    command.Parameters.Add("@phong", SqlDbType.Int).Value = phong;
                    command.Parameters.Add("@ngdd", SqlDbType.Int).Value = ngdaidien;
                    command.Parameters.Add("@Idnv", SqlDbType.Int).Value = idnv;
                    mydb.OpenConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        mydb.CloseConnection();

                    }
                    else
                    {
                        mydb.CloseConnection();

                    }
                    MessageBox.Show("New Customer Added", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", " Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
           

        }
        bool verif()
        {
            if ((label2.Text.Trim() == "") || (label4.Text.Trim() == "") || (quoctichtb.Text.Trim() == "") )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*DanhSachPhongForm phong = new DanhSachPhongForm();
            Close();
            phong.Show();*/

            SqlCommand command = new SqlCommand("dbo.XemDanhSachPhong");
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable tab = new DataTable();
            adap.Fill(tab);
            DanhSachDGV.ReadOnly = true;
            DanhSachDGV.RowTemplate.Height = 80;
            DanhSachDGV.DataSource = tab;
            DanhSachDGV.AllowUserToAddRows = false;
        }

        private void idTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void huyBt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chonDSNhanVienBt_Click(object sender, EventArgs e)
        {
            /*DanhSachKhachForm khach = new DanhSachKhachForm();
            
            khach.Show();*/

            SqlCommand commd = new SqlCommand("dbo.XemThongTinKhach");
            commd.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(commd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DanhSachKhachDVG.ReadOnly = true;
            DanhSachKhachDVG.RowTemplate.Height = 80;
            DanhSachKhachDVG.DataSource = table;
            DanhSachKhachDVG.AllowUserToAddRows = false;
        }

        private void DanhSachKhachDVG_Click(object sender, EventArgs e)
        {
            ngdaidientb.Text = DanhSachKhachDVG.CurrentRow.Cells[0].Value.ToString();
        }

        private void DanhSachDGV_Click(object sender, EventArgs e)
        {
            phongtb.Text = DanhSachDGV.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
