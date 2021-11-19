
namespace QuanLyKhachSan
{
    partial class ThanhToanTienPhongForm
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
            this.soTienTraTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.huyBt = new System.Windows.Forms.Button();
            this.xacNhanBt = new System.Windows.Forms.Button();
            this.maKhachTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maPhongTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chonDSKhachBt = new System.Windows.Forms.Button();
            this.DanhSachKhachDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachKhachDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // soTienTraTb
            // 
            this.soTienTraTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.soTienTraTb.Location = new System.Drawing.Point(161, 139);
            this.soTienTraTb.Name = "soTienTraTb";
            this.soTienTraTb.Size = new System.Drawing.Size(169, 34);
            this.soTienTraTb.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(13, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 29);
            this.label5.TabIndex = 56;
            this.label5.Text = "Số Tiền Trả:";
            // 
            // huyBt
            // 
            this.huyBt.BackColor = System.Drawing.Color.OrangeRed;
            this.huyBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.huyBt.Location = new System.Drawing.Point(244, 243);
            this.huyBt.Name = "huyBt";
            this.huyBt.Size = new System.Drawing.Size(197, 61);
            this.huyBt.TabIndex = 51;
            this.huyBt.Text = "Hủy";
            this.huyBt.UseVisualStyleBackColor = false;
            this.huyBt.Click += new System.EventHandler(this.huyBt_Click);
            // 
            // xacNhanBt
            // 
            this.xacNhanBt.BackColor = System.Drawing.Color.Lime;
            this.xacNhanBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xacNhanBt.Location = new System.Drawing.Point(18, 243);
            this.xacNhanBt.Name = "xacNhanBt";
            this.xacNhanBt.Size = new System.Drawing.Size(197, 61);
            this.xacNhanBt.TabIndex = 50;
            this.xacNhanBt.Text = "Xác nhận";
            this.xacNhanBt.UseVisualStyleBackColor = false;
            this.xacNhanBt.Click += new System.EventHandler(this.xacNhanBt_Click);
            // 
            // maKhachTb
            // 
            this.maKhachTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maKhachTb.Location = new System.Drawing.Point(161, 9);
            this.maKhachTb.Name = "maKhachTb";
            this.maKhachTb.Size = new System.Drawing.Size(169, 34);
            this.maKhachTb.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 48;
            this.label2.Text = "Mã Khách:";
            // 
            // maPhongTb
            // 
            this.maPhongTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maPhongTb.Location = new System.Drawing.Point(161, 71);
            this.maPhongTb.Name = "maPhongTb";
            this.maPhongTb.Size = new System.Drawing.Size(169, 34);
            this.maPhongTb.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(13, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mã Phòng:";
            // 
            // chonDSKhachBt
            // 
            this.chonDSKhachBt.BackColor = System.Drawing.SystemColors.Info;
            this.chonDSKhachBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chonDSKhachBt.Location = new System.Drawing.Point(336, 9);
            this.chonDSKhachBt.Name = "chonDSKhachBt";
            this.chonDSKhachBt.Size = new System.Drawing.Size(76, 34);
            this.chonDSKhachBt.TabIndex = 59;
            this.chonDSKhachBt.Text = "Chọn";
            this.chonDSKhachBt.UseVisualStyleBackColor = false;
            this.chonDSKhachBt.Click += new System.EventHandler(this.chonDSKhachBt_Click);
            // 
            // DanhSachKhachDGV
            // 
            this.DanhSachKhachDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachKhachDGV.Location = new System.Drawing.Point(597, 37);
            this.DanhSachKhachDGV.Name = "DanhSachKhachDGV";
            this.DanhSachKhachDGV.RowHeadersWidth = 51;
            this.DanhSachKhachDGV.RowTemplate.Height = 24;
            this.DanhSachKhachDGV.Size = new System.Drawing.Size(711, 424);
            this.DanhSachKhachDGV.TabIndex = 61;
            this.DanhSachKhachDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DanhSachKhachDGV_CellContentClick);
            this.DanhSachKhachDGV.Click += new System.EventHandler(this.DanhSachKhachDGV_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(605, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 17);
            this.label6.TabIndex = 63;
            this.label6.Text = "Danh Sách Khách Thuê Phòng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chonDSKhachBt);
            this.groupBox1.Controls.Add(this.soTienTraTb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.huyBt);
            this.groupBox1.Controls.Add(this.xacNhanBt);
            this.groupBox1.Controls.Add(this.maKhachTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maPhongTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 465);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            // 
            // ThanhToanTienPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1401, 620);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DanhSachKhachDGV);
            this.Name = "ThanhToanTienPhongForm";
            this.Text = "ThanhToanTienPhongForm";
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachKhachDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox soTienTraTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button huyBt;
        private System.Windows.Forms.Button xacNhanBt;
        private System.Windows.Forms.TextBox maKhachTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maPhongTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chonDSKhachBt;
        private System.Windows.Forms.DataGridView DanhSachKhachDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}