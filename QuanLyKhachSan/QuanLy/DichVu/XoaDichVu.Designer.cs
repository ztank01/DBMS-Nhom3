
namespace QuanLyKhachSan
{
    partial class XoaDichVu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xoaPhongBt = new System.Windows.Forms.Button();
            this.maDvTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DanhSachDichVuDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachDichVuDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // xoaPhongBt
            // 
            this.xoaPhongBt.BackColor = System.Drawing.Color.OrangeRed;
            this.xoaPhongBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xoaPhongBt.Location = new System.Drawing.Point(266, 303);
            this.xoaPhongBt.Name = "xoaPhongBt";
            this.xoaPhongBt.Size = new System.Drawing.Size(264, 48);
            this.xoaPhongBt.TabIndex = 13;
            this.xoaPhongBt.Text = "Xóa Dịch Vụ";
            this.xoaPhongBt.UseVisualStyleBackColor = false;
            this.xoaPhongBt.Click += new System.EventHandler(this.xoaPhongBt_Click);
            // 
            // maDvTb
            // 
            this.maDvTb.Enabled = false;
            this.maDvTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maDvTb.Location = new System.Drawing.Point(406, 254);
            this.maDvTb.Name = "maDvTb";
            this.maDvTb.Size = new System.Drawing.Size(124, 34);
            this.maDvTb.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(261, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Dịch Vụ:";
            // 
            // DanhSachDichVuDGV
            // 
            this.DanhSachDichVuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachDichVuDGV.Location = new System.Drawing.Point(12, 12);
            this.DanhSachDichVuDGV.Name = "DanhSachDichVuDGV";
            this.DanhSachDichVuDGV.RowHeadersWidth = 51;
            this.DanhSachDichVuDGV.RowTemplate.Height = 24;
            this.DanhSachDichVuDGV.Size = new System.Drawing.Size(776, 236);
            this.DanhSachDichVuDGV.TabIndex = 10;
            this.DanhSachDichVuDGV.Click += new System.EventHandler(this.DanhSachDichVuDGV_Click);
            // 
            // XoaDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.xoaPhongBt);
            this.Controls.Add(this.maDvTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DanhSachDichVuDGV);
            this.Name = "XoaDichVu";
            this.Text = "XoaDichVu";
            this.Load += new System.EventHandler(this.XoaDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachDichVuDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button xoaPhongBt;
        private System.Windows.Forms.TextBox maDvTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DanhSachDichVuDGV;
    }
}