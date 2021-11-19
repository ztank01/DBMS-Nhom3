using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class NhanVienMainForm : Form
    {
        public NhanVienMainForm()
        {
            InitializeComponent();
        }
        
        private void NhanVienMainForm_Load(object sender, EventArgs e)
        {
            ChaoMungLb.Text = "Chào mừng " + Globals.GlobalsUser.HoTen;
        }

        private void themKhachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemKhachForm themkhach = new ThemKhachForm();
           
            themkhach.Show();
        }

        private void chinhSuaThongTinKhachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChinhSuaThongTinKhachForm chinhsua = new ChinhSuaThongTinKhachForm();
            
            chinhsua.Show();
        }

        private void themPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatPhongForm datP = new DatPhongForm();
           
            datP.Show();
        }

        private void xoaPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemSoTienPhongConNoForm xem = new XemSoTienPhongConNoForm();
            xem.Show();
        }

        private void chinhSuaPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhToanTienPhongForm thanhtoan = new ThanhToanTienPhongForm();
            thanhtoan.Show();
        }

        private void themDichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatDichVuForm dv = new DatDichVuForm();
            dv.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhGiaForm danhgia = new DanhGiaForm();
           
            danhgia.Show();
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhauForm mk = new DoiMatKhauForm();
            mk.Show();
        }

        private void doiThongTinTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiThongTinTaiKhoanForm tk = new DoiThongTinTaiKhoanForm();
            tk.Show();
        }

        private void khachToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
      
    }
}
