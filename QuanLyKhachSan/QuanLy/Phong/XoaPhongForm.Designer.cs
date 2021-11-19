
namespace QuanLyKhachSan
{
    partial class XoaPhongForm
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
            this.maPhongTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DanhSachPhongDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachPhongDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // xoaPhongBt
            // 
            this.xoaPhongBt.BackColor = System.Drawing.Color.OrangeRed;
            this.xoaPhongBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xoaPhongBt.Location = new System.Drawing.Point(266, 303);
            this.xoaPhongBt.Name = "xoaPhongBt";
            this.xoaPhongBt.Size = new System.Drawing.Size(264, 48);
            this.xoaPhongBt.TabIndex = 9;
            this.xoaPhongBt.Text = "Xóa Phòng";
            this.xoaPhongBt.UseVisualStyleBackColor = false;
            this.xoaPhongBt.Click += new System.EventHandler(this.xoaPhongBt_Click);
            // 
            // maPhongTb
            // 
            this.maPhongTb.Enabled = false;
            this.maPhongTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maPhongTb.Location = new System.Drawing.Point(406, 254);
            this.maPhongTb.Name = "maPhongTb";
            this.maPhongTb.Size = new System.Drawing.Size(124, 34);
            this.maPhongTb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(261, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã phòng:";
            // 
            // DanhSachPhongDGV
            // 
            this.DanhSachPhongDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachPhongDGV.Location = new System.Drawing.Point(12, 12);
            this.DanhSachPhongDGV.Name = "DanhSachPhongDGV";
            this.DanhSachPhongDGV.RowHeadersWidth = 51;
            this.DanhSachPhongDGV.RowTemplate.Height = 24;
            this.DanhSachPhongDGV.Size = new System.Drawing.Size(776, 236);
            this.DanhSachPhongDGV.TabIndex = 6;
            this.DanhSachPhongDGV.Click += new System.EventHandler(this.DanhSachPhongDGV_Click);
            // 
            // XoaPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.xoaPhongBt);
            this.Controls.Add(this.maPhongTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DanhSachPhongDGV);
            this.Name = "XoaPhongForm";
            this.Text = "XoaPhongForm";
            this.Load += new System.EventHandler(this.XoaPhongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachPhongDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button xoaPhongBt;
        private System.Windows.Forms.TextBox maPhongTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DanhSachPhongDGV;
    }
}