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
    public partial class DoanhThuDichVuForm : Form
    {
        public DoanhThuDichVuForm()
        {
            InitializeComponent();
        }

        MyDB mydb = new MyDB();

        private void xembt_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
            if(radioButtonNgay.Checked == true)
            {
                label1.Text = "Đang chọn ngày:";
                labelNgay.Text = dateTimePicker1.Value.ToString();
                SqlCommand command = new SqlCommand("select dbo.TongTienDVNgay(@Ngay,@Thang,@Nam)", mydb.GetConnection);
                command.Parameters.Add("@Ngay", SqlDbType.Int).Value = dateTimePicker1.Value.Day;
                command.Parameters.Add("@Thang", SqlDbType.Int).Value = dateTimePicker1.Value.Month;
                command.Parameters.Add("@Nam", SqlDbType.Int).Value = dateTimePicker1.Value.Year;
                SqlDataAdapter dap = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dap.Fill(table);
                if(table.Rows[0][0].ToString().Trim()=="")
                {
                    table.Rows[0][0] = 0;
                }
                labelDichVu.Text = table.Rows[0][0].ToString();
                labelTongDoanhThu.Text = DoanhThuNgay(dateTimePicker1.Value.Date).Rows[0][0].ToString();
                for (int i = 1; i <= dateTimePicker1.Value.Day; i++)
                {
                    int thang = dateTimePicker1.Value.Month;
                    int nam = dateTimePicker1.Value.Year;
                    DateTime date = new DateTime(nam, thang, i);
                    chart1.Series["Series1"].Points.AddXY(i.ToString(), DoanhThuNgay(date).Rows[0][0].ToString());
                }
            }
            if (radioButtonThang.Checked == true)
            {
                label1.Text = "Đang chọn tháng:";
                labelNgay.Text = dateTimePicker1.Value.Month.ToString();
                int Thang = dateTimePicker1.Value.Month;
                int Nam = dateTimePicker1.Value.Year;
                SqlCommand command = new SqlCommand("select dbo.TongTienDVThang(@Thang,@Nam)", mydb.GetConnection);
                command.Parameters.Add("@Thang", SqlDbType.Int).Value = Thang;
                command.Parameters.Add("@Nam", SqlDbType.Int).Value = Nam;
                SqlDataAdapter dap = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                dap.Fill(table);
                if (table.Rows[0][0].ToString().Trim() == "")
                {
                    table.Rows[0][0] = 0;
                }
                labelDichVu.Text = table.Rows[0][0].ToString();
                table.Clear();
                table = DoanhThuThang(Thang, Nam);
                if (table.Rows[0][0].ToString().Trim() == "")
                    table.Rows[0][0] = 0;
                labelTongDoanhThu.Text = table.Rows[0][0].ToString();
                for(int i = 1;i<=12;i++)
                {
                    chart1.Series["Series1"].Points.AddXY(i.ToString(), DoanhThuThang(i,Nam).Rows[0][0].ToString());
                }
            }
        }
        public DataTable DoanhThuNgay(DateTime date)
        {
            SqlCommand command = new SqlCommand("select dbo.TinhDoanhThuNgay(@Ngay)", mydb.GetConnection);
            command.Parameters.Add("@Ngay", SqlDbType.Date).Value = date;
            SqlDataAdapter dap = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }
        public DataTable DoanhThuThang(int Thang, int Nam)
        {
            SqlCommand command = new SqlCommand("select dbo.TongDoanhThuTheoThang(@Thang,@Nam)", mydb.GetConnection);
            command.Parameters.Add("@Thang", SqlDbType.Int).Value = Thang;
            command.Parameters.Add("@Nam", SqlDbType.Int).Value = Nam;
            SqlDataAdapter dap = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }
    }
}
