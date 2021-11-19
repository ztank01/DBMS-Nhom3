
namespace QuanLyKhachSan
{
    partial class DatDichVuForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.maDvTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maPhongTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.soLuongNUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.huyBt = new System.Windows.Forms.Button();
            this.xacNhanBt = new System.Windows.Forms.Button();
            this.chonDSDichVuBt = new System.Windows.Forms.Button();
            this.chonDSPhongBt = new System.Windows.Forms.Button();
            this.thanhtientb = new System.Windows.Forms.TextBox();
            this.DanhSachPhongDGV = new System.Windows.Forms.DataGridView();
            this.DanhSachDichVuDGV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.soLuongNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachPhongDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachDichVuDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(13, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Số lượng:";
            // 
            // maDvTb
            // 
            this.maDvTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maDvTb.Location = new System.Drawing.Point(159, 75);
            this.maDvTb.Name = "maDvTb";
            this.maDvTb.Size = new System.Drawing.Size(169, 34);
            this.maDvTb.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã Dịch Vụ:";
            // 
            // maPhongTb
            // 
            this.maPhongTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maPhongTb.Location = new System.Drawing.Point(161, 8);
            this.maPhongTb.Name = "maPhongTb";
            this.maPhongTb.Size = new System.Drawing.Size(169, 34);
            this.maPhongTb.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã Phòng:";
            // 
            // soLuongNUD
            // 
            this.soLuongNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.soLuongNUD.Location = new System.Drawing.Point(161, 131);
            this.soLuongNUD.Name = "soLuongNUD";
            this.soLuongNUD.Size = new System.Drawing.Size(54, 34);
            this.soLuongNUD.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(13, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Thành tiền: ";
            // 
            // huyBt
            // 
            this.huyBt.BackColor = System.Drawing.Color.OrangeRed;
            this.huyBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.huyBt.Location = new System.Drawing.Point(266, 331);
            this.huyBt.Name = "huyBt";
            this.huyBt.Size = new System.Drawing.Size(197, 61);
            this.huyBt.TabIndex = 27;
            this.huyBt.Text = "Hủy";
            this.huyBt.UseVisualStyleBackColor = false;
            this.huyBt.Click += new System.EventHandler(this.huyBt_Click);
            // 
            // xacNhanBt
            // 
            this.xacNhanBt.BackColor = System.Drawing.Color.Lime;
            this.xacNhanBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xacNhanBt.Location = new System.Drawing.Point(18, 331);
            this.xacNhanBt.Name = "xacNhanBt";
            this.xacNhanBt.Size = new System.Drawing.Size(197, 61);
            this.xacNhanBt.TabIndex = 26;
            this.xacNhanBt.Text = "Xác nhận";
            this.xacNhanBt.UseVisualStyleBackColor = false;
            this.xacNhanBt.Click += new System.EventHandler(this.xacNhanBt_Click);
            // 
            // chonDSDichVuBt
            // 
            this.chonDSDichVuBt.BackColor = System.Drawing.SystemColors.Info;
            this.chonDSDichVuBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chonDSDichVuBt.Location = new System.Drawing.Point(336, 70);
            this.chonDSDichVuBt.Name = "chonDSDichVuBt";
            this.chonDSDichVuBt.Size = new System.Drawing.Size(76, 34);
            this.chonDSDichVuBt.TabIndex = 28;
            this.chonDSDichVuBt.Text = "Chọn";
            this.chonDSDichVuBt.UseVisualStyleBackColor = false;
            this.chonDSDichVuBt.Click += new System.EventHandler(this.chonDSDichVuBt_Click);
            // 
            // chonDSPhongBt
            // 
            this.chonDSPhongBt.BackColor = System.Drawing.SystemColors.Info;
            this.chonDSPhongBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chonDSPhongBt.Location = new System.Drawing.Point(336, 4);
            this.chonDSPhongBt.Name = "chonDSPhongBt";
            this.chonDSPhongBt.Size = new System.Drawing.Size(76, 34);
            this.chonDSPhongBt.TabIndex = 29;
            this.chonDSPhongBt.Text = "Chọn";
            this.chonDSPhongBt.UseVisualStyleBackColor = false;
            this.chonDSPhongBt.Click += new System.EventHandler(this.chonDSPhongBt_Click);
            // 
            // thanhtientb
            // 
            this.thanhtientb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thanhtientb.Location = new System.Drawing.Point(161, 197);
            this.thanhtientb.Name = "thanhtientb";
            this.thanhtientb.Size = new System.Drawing.Size(169, 34);
            this.thanhtientb.TabIndex = 30;
            // 
            // DanhSachPhongDGV
            // 
            this.DanhSachPhongDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachPhongDGV.Location = new System.Drawing.Point(572, 44);
            this.DanhSachPhongDGV.Name = "DanhSachPhongDGV";
            this.DanhSachPhongDGV.RowHeadersWidth = 51;
            this.DanhSachPhongDGV.RowTemplate.Height = 24;
            this.DanhSachPhongDGV.Size = new System.Drawing.Size(694, 240);
            this.DanhSachPhongDGV.TabIndex = 31;
            this.DanhSachPhongDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DanhSachPhongDGV_CellContentClick);
            this.DanhSachPhongDGV.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // DanhSachDichVuDGV
            // 
            this.DanhSachDichVuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachDichVuDGV.Location = new System.Drawing.Point(572, 327);
            this.DanhSachDichVuDGV.Name = "DanhSachDichVuDGV";
            this.DanhSachDichVuDGV.RowHeadersWidth = 51;
            this.DanhSachDichVuDGV.RowTemplate.Height = 24;
            this.DanhSachDichVuDGV.Size = new System.Drawing.Size(694, 257);
            this.DanhSachDichVuDGV.TabIndex = 32;
            this.DanhSachDichVuDGV.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Danh Sách Phòng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Danh Sách Dịch Vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.thanhtientb);
            this.groupBox1.Controls.Add(this.chonDSPhongBt);
            this.groupBox1.Controls.Add(this.chonDSDichVuBt);
            this.groupBox1.Controls.Add(this.huyBt);
            this.groupBox1.Controls.Add(this.xacNhanBt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.soLuongNUD);
            this.groupBox1.Controls.Add(this.maPhongTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.maDvTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 486);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // DatDichVuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1371, 636);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DanhSachDichVuDGV);
            this.Controls.Add(this.DanhSachPhongDGV);
            this.Name = "DatDichVuForm";
            ((System.ComponentModel.ISupportInitialize)(this.soLuongNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachPhongDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachDichVuDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown soLuongNUD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button huyBt;
        private System.Windows.Forms.Button xacNhanBt;
        private System.Windows.Forms.Button chonDSDichVuBt;
        private System.Windows.Forms.Button chonDSPhongBt;
        private System.Windows.Forms.TextBox thanhtientb;
        private System.Windows.Forms.DataGridView DanhSachPhongDGV;
        private System.Windows.Forms.DataGridView DanhSachDichVuDGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox maPhongTb;
        public System.Windows.Forms.TextBox maDvTb;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}