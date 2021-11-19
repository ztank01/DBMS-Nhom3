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
    public partial class QuanLyMainForm : Form
    {
        public QuanLyMainForm()
        {
            InitializeComponent();
        }

        private void themPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemPhongForm form = new ThemPhongForm();
            form.Show();
        }

        private void xoaPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaPhongForm form = new XoaPhongForm();
            form.Show();
        }

        private void chinhSuaPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChinhSuaThongTinPhongForm form = new ChinhSuaThongTinPhongForm();
            form.Show();
        }

        private void themDichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemDichVuForm form = new ThemDichVuForm();
            form.Show();
        }

        private void xoaDichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaDichVu form = new XoaDichVu();
            form.Show();
        }

        private void suaThongTinDichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChinhSuaThongTinDichVu form = new ChinhSuaThongTinDichVu();
            form.Show();
        }

        private void themNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemNhanVienForm form = new ThemNhanVienForm();
            form.Show();
        }

        private void duoiViecNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DuoiViecNhanVienForm form = new DuoiViecNhanVienForm();
            form.Show();
        }

        private void chinhSuaThongTinNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChinhSuaThongTinNhanVienForm form = new ChinhSuaThongTinNhanVienForm();
            form.Show();
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhauForm form = new DoiMatKhauForm();
            form.Show();
        }

        private void doiThongTinTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiThongTinTaiKhoanForm form = new DoiThongTinTaiKhoanForm();
            form.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoanhThuDichVuForm form = new DoanhThuDichVuForm();
            form.Show();
        }

        private void QuanLyMainForm_Load(object sender, EventArgs e)
        {
            ChaoMungLb.Text = "Chào mừng " + Globals.GlobalsUser.HoTen;
        }
    }
}
