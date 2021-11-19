
namespace QuanLyKhachSan
{
    partial class DanhGiaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.maKhachTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xacNhanBt = new System.Windows.Forms.Button();
            this.huyBt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nhanXetTb = new System.Windows.Forms.TextBox();
            this.soSaoCbB = new System.Windows.Forms.ComboBox();
            this.chonDSKhachBt = new System.Windows.Forms.Button();
            this.DanhSachKhachDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachKhachDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách:";
            // 
            // maKhachTb
            // 
            this.maKhachTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maKhachTb.Location = new System.Drawing.Point(154, 11);
            this.maKhachTb.Name = "maKhachTb";
            this.maKhachTb.Size = new System.Drawing.Size(169, 34);
            this.maKhachTb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số sao:";
            // 
            // xacNhanBt
            // 
            this.xacNhanBt.BackColor = System.Drawing.Color.Lime;
            this.xacNhanBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xacNhanBt.Location = new System.Drawing.Point(11, 389);
            this.xacNhanBt.Name = "xacNhanBt";
            this.xacNhanBt.Size = new System.Drawing.Size(197, 61);
            this.xacNhanBt.TabIndex = 5;
            this.xacNhanBt.Text = "Xác nhận";
            this.xacNhanBt.UseVisualStyleBackColor = false;
            this.xacNhanBt.Click += new System.EventHandler(this.xacNhanBt_Click);
            // 
            // huyBt
            // 
            this.huyBt.BackColor = System.Drawing.Color.OrangeRed;
            this.huyBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.huyBt.Location = new System.Drawing.Point(283, 389);
            this.huyBt.Name = "huyBt";
            this.huyBt.Size = new System.Drawing.Size(197, 61);
            this.huyBt.TabIndex = 6;
            this.huyBt.Text = "Hủy";
            this.huyBt.UseVisualStyleBackColor = false;
            this.huyBt.Click += new System.EventHandler(this.huyBt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(6, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nhận xét: ";
            // 
            // nhanXetTb
            // 
            this.nhanXetTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nhanXetTb.Location = new System.Drawing.Point(154, 164);
            this.nhanXetTb.Multiline = true;
            this.nhanXetTb.Name = "nhanXetTb";
            this.nhanXetTb.Size = new System.Drawing.Size(326, 127);
            this.nhanXetTb.TabIndex = 12;
            // 
            // soSaoCbB
            // 
            this.soSaoCbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.soSaoCbB.FormattingEnabled = true;
            this.soSaoCbB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.soSaoCbB.Location = new System.Drawing.Point(154, 86);
            this.soSaoCbB.Name = "soSaoCbB";
            this.soSaoCbB.Size = new System.Drawing.Size(67, 37);
            this.soSaoCbB.TabIndex = 13;
            this.soSaoCbB.SelectedIndexChanged += new System.EventHandler(this.soSaoCbB_SelectedIndexChanged);
            // 
            // chonDSKhachBt
            // 
            this.chonDSKhachBt.BackColor = System.Drawing.SystemColors.Info;
            this.chonDSKhachBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chonDSKhachBt.Location = new System.Drawing.Point(360, 11);
            this.chonDSKhachBt.Name = "chonDSKhachBt";
            this.chonDSKhachBt.Size = new System.Drawing.Size(76, 34);
            this.chonDSKhachBt.TabIndex = 47;
            this.chonDSKhachBt.Text = "Chọn";
            this.chonDSKhachBt.UseVisualStyleBackColor = false;
            this.chonDSKhachBt.Click += new System.EventHandler(this.chonDSKhachBt_Click);
            // 
            // DanhSachKhachDGV
            // 
            this.DanhSachKhachDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachKhachDGV.Location = new System.Drawing.Point(522, 61);
            this.DanhSachKhachDGV.Name = "DanhSachKhachDGV";
            this.DanhSachKhachDGV.RowHeadersWidth = 51;
            this.DanhSachKhachDGV.RowTemplate.Height = 24;
            this.DanhSachKhachDGV.Size = new System.Drawing.Size(752, 322);
            this.DanhSachKhachDGV.TabIndex = 51;
            this.DanhSachKhachDGV.Click += new System.EventHandler(this.DanhSachKhachDGV_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Danh Sách Khách:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox1.Controls.Add(this.chonDSKhachBt);
            this.groupBox1.Controls.Add(this.soSaoCbB);
            this.groupBox1.Controls.Add(this.nhanXetTb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.huyBt);
            this.groupBox1.Controls.Add(this.xacNhanBt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maKhachTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(20, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 485);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // DanhGiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1304, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DanhSachKhachDGV);
            this.Name = "DanhGiaForm";
            this.Text = "DanhGiaForm";
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachKhachDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button xacNhanBt;
        private System.Windows.Forms.Button huyBt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nhanXetTb;
        private System.Windows.Forms.ComboBox soSaoCbB;
        private System.Windows.Forms.Button chonDSKhachBt;
        public System.Windows.Forms.TextBox maKhachTb;
        private System.Windows.Forms.DataGridView DanhSachKhachDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}