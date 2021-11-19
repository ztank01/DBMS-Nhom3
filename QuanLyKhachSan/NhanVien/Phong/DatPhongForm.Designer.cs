
namespace QuanLyKhachSan
{
    partial class DatPhongForm
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
            this.maKhachTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chonDSKhachBt = new System.Windows.Forms.Button();
            this.DanhSachKhachDGV = new System.Windows.Forms.DataGridView();
            this.DanhSachPhongDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maPhongTb = new System.Windows.Forms.TextBox();
            this.xacNhanBt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.huyBt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.daTraTb = new System.Windows.Forms.TextBox();
            this.chonDSPhongBt = new System.Windows.Forms.Button();
            this.NgayThueDTP = new System.Windows.Forms.DateTimePicker();
            this.NgayTraDTP = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachKhachDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachPhongDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maKhachTb
            // 
            this.maKhachTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maKhachTb.Location = new System.Drawing.Point(160, 11);
            this.maKhachTb.Name = "maKhachTb";
            this.maKhachTb.Size = new System.Drawing.Size(169, 34);
            this.maKhachTb.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mã Khách:";
            // 
            // chonDSKhachBt
            // 
            this.chonDSKhachBt.BackColor = System.Drawing.SystemColors.Info;
            this.chonDSKhachBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chonDSKhachBt.Location = new System.Drawing.Point(370, 11);
            this.chonDSKhachBt.Name = "chonDSKhachBt";
            this.chonDSKhachBt.Size = new System.Drawing.Size(76, 34);
            this.chonDSKhachBt.TabIndex = 46;
            this.chonDSKhachBt.Text = "Chọn";
            this.chonDSKhachBt.UseVisualStyleBackColor = false;
            this.chonDSKhachBt.Click += new System.EventHandler(this.chonDSKhachBt_Click);
            // 
            // DanhSachKhachDGV
            // 
            this.DanhSachKhachDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachKhachDGV.Location = new System.Drawing.Point(517, 60);
            this.DanhSachKhachDGV.Name = "DanhSachKhachDGV";
            this.DanhSachKhachDGV.RowHeadersWidth = 51;
            this.DanhSachKhachDGV.RowTemplate.Height = 24;
            this.DanhSachKhachDGV.Size = new System.Drawing.Size(741, 264);
            this.DanhSachKhachDGV.TabIndex = 50;
            this.DanhSachKhachDGV.Click += new System.EventHandler(this.DanhSachKhachDGV_Click);
            // 
            // DanhSachPhongDGV
            // 
            this.DanhSachPhongDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachPhongDGV.Location = new System.Drawing.Point(517, 383);
            this.DanhSachPhongDGV.Name = "DanhSachPhongDGV";
            this.DanhSachPhongDGV.RowHeadersWidth = 51;
            this.DanhSachPhongDGV.RowTemplate.Height = 24;
            this.DanhSachPhongDGV.Size = new System.Drawing.Size(741, 260);
            this.DanhSachPhongDGV.TabIndex = 51;
            this.DanhSachPhongDGV.Click += new System.EventHandler(this.DanhSachPhongDGV_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Danh Sách Khách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(516, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Danh sách phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã Phòng:";
            // 
            // maPhongTb
            // 
            this.maPhongTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maPhongTb.Location = new System.Drawing.Point(160, 73);
            this.maPhongTb.Name = "maPhongTb";
            this.maPhongTb.Size = new System.Drawing.Size(169, 34);
            this.maPhongTb.TabIndex = 30;
            // 
            // xacNhanBt
            // 
            this.xacNhanBt.BackColor = System.Drawing.Color.Lime;
            this.xacNhanBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xacNhanBt.Location = new System.Drawing.Point(2, 384);
            this.xacNhanBt.Name = "xacNhanBt";
            this.xacNhanBt.Size = new System.Drawing.Size(197, 61);
            this.xacNhanBt.TabIndex = 37;
            this.xacNhanBt.Text = "Xác nhận";
            this.xacNhanBt.UseVisualStyleBackColor = false;
            this.xacNhanBt.Click += new System.EventHandler(this.xacNhanBt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 41;
            this.label3.Text = "Ngày đến:";
            // 
            // huyBt
            // 
            this.huyBt.BackColor = System.Drawing.Color.OrangeRed;
            this.huyBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.huyBt.Location = new System.Drawing.Point(249, 384);
            this.huyBt.Name = "huyBt";
            this.huyBt.Size = new System.Drawing.Size(197, 61);
            this.huyBt.TabIndex = 38;
            this.huyBt.Text = "Hủy";
            this.huyBt.UseVisualStyleBackColor = false;
            this.huyBt.Click += new System.EventHandler(this.huyBt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 42;
            this.label4.Text = "Ngày Trả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(12, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 43;
            this.label5.Text = "Đã Trả:";
            // 
            // daTraTb
            // 
            this.daTraTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.daTraTb.Location = new System.Drawing.Point(160, 249);
            this.daTraTb.Name = "daTraTb";
            this.daTraTb.Size = new System.Drawing.Size(169, 34);
            this.daTraTb.TabIndex = 45;
            // 
            // chonDSPhongBt
            // 
            this.chonDSPhongBt.BackColor = System.Drawing.SystemColors.Info;
            this.chonDSPhongBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chonDSPhongBt.Location = new System.Drawing.Point(370, 73);
            this.chonDSPhongBt.Name = "chonDSPhongBt";
            this.chonDSPhongBt.Size = new System.Drawing.Size(76, 34);
            this.chonDSPhongBt.TabIndex = 47;
            this.chonDSPhongBt.Text = "Chọn";
            this.chonDSPhongBt.UseVisualStyleBackColor = false;
            this.chonDSPhongBt.Click += new System.EventHandler(this.chonDSPhongBt_Click);
            // 
            // NgayThueDTP
            // 
            this.NgayThueDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayThueDTP.Location = new System.Drawing.Point(160, 137);
            this.NgayThueDTP.Name = "NgayThueDTP";
            this.NgayThueDTP.Size = new System.Drawing.Size(169, 22);
            this.NgayThueDTP.TabIndex = 48;
            // 
            // NgayTraDTP
            // 
            this.NgayTraDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayTraDTP.Location = new System.Drawing.Point(160, 195);
            this.NgayTraDTP.Name = "NgayTraDTP";
            this.NgayTraDTP.Size = new System.Drawing.Size(169, 22);
            this.NgayTraDTP.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NgayTraDTP);
            this.groupBox1.Controls.Add(this.NgayThueDTP);
            this.groupBox1.Controls.Add(this.chonDSPhongBt);
            this.groupBox1.Controls.Add(this.chonDSKhachBt);
            this.groupBox1.Controls.Add(this.daTraTb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.huyBt);
            this.groupBox1.Controls.Add(this.xacNhanBt);
            this.groupBox1.Controls.Add(this.maKhachTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maPhongTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 488);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // DatPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1270, 678);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DanhSachPhongDGV);
            this.Controls.Add(this.DanhSachKhachDGV);
            this.Name = "DatPhongForm";
            this.Text = "DatPhongForm";
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachKhachDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachPhongDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox maKhachTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button chonDSKhachBt;
        private System.Windows.Forms.DataGridView DanhSachKhachDGV;
        private System.Windows.Forms.DataGridView DanhSachPhongDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maPhongTb;
        private System.Windows.Forms.Button xacNhanBt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button huyBt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox daTraTb;
        private System.Windows.Forms.Button chonDSPhongBt;
        private System.Windows.Forms.DateTimePicker NgayThueDTP;
        private System.Windows.Forms.DateTimePicker NgayTraDTP;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}