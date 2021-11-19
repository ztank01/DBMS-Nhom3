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
    public partial class XemSoTienPhongConNoForm : Form
    {
        public XemSoTienPhongConNoForm()
        {
            InitializeComponent();
        }
        MyDB mydb = new MyDB();
        private void XemSoTienPhongConNoForm_Load(object sender, EventArgs e)
        {
            
            SqlCommand commd = new SqlCommand("SELECT * from ChiTietThue ");
            commd.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(commd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DanhSachPhongDGV.ReadOnly = true;
            DanhSachPhongDGV.RowTemplate.Height = 80;
            DanhSachPhongDGV.DataSource = table;
            DanhSachPhongDGV.AllowUserToAddRows = false;
        }

        private void DanhSachPhongDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void danhSachPhongBt_Click(object sender, EventArgs e)
        {
            
            int MaP = Int32.Parse(maPhongTb.Text);
            SqlCommand commd = new SqlCommand("SELECT * from ChiTietThue where MaPhong= "+MaP);
            commd.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(commd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DanhSachPhongDGV.ReadOnly = true;
            DanhSachPhongDGV.RowTemplate.Height = 80;
            DanhSachPhongDGV.DataSource = table;
            DanhSachPhongDGV.AllowUserToAddRows = false;
            sonotb.Text = DanhSachPhongDGV.Rows[0].Cells[6].Value.ToString();
            /*int MaKhach= Int32.Parse(DanhSachPhongDGV.Rows[0].Cells[0].Value.ToString());
           SqlCommand command = new SqlCommand("dbo.ThongTinNoPhi", mydb.getConnection);
           command.CommandType = CommandType.StoredProcedure;
           command.Parameters.Add("@maKhach", SqlDbType.Int).Value = MaKhach;
           SqlDataAdapter adap= new SqlDataAdapter(command);
           DataTable tab = new DataTable();
           mydb.openConnection();
           sonotb.Text = tab.ToString();
           mydb.closeConnection();*/
        }
    }
}
