
namespace QuanLyKhachSan
{
    partial class XemSoTienPhongConNoForm
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
            this.danhSachPhongBt = new System.Windows.Forms.Button();
            this.maPhongTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DanhSachPhongDGV = new System.Windows.Forms.DataGridView();
            this.sonotb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachPhongDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // danhSachPhongBt
            // 
            this.danhSachPhongBt.BackColor = System.Drawing.SystemColors.Info;
            this.danhSachPhongBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.danhSachPhongBt.Location = new System.Drawing.Point(475, 388);
            this.danhSachPhongBt.Name = "danhSachPhongBt";
            this.danhSachPhongBt.Size = new System.Drawing.Size(76, 34);
            this.danhSachPhongBt.TabIndex = 52;
            this.danhSachPhongBt.Text = "Xem";
            this.danhSachPhongBt.UseVisualStyleBackColor = false;
            this.danhSachPhongBt.Click += new System.EventHandler(this.danhSachPhongBt_Click);
            // 
            // maPhongTb
            // 
            this.maPhongTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maPhongTb.Location = new System.Drawing.Point(300, 388);
            this.maPhongTb.Name = "maPhongTb";
            this.maPhongTb.Size = new System.Drawing.Size(169, 34);
            this.maPhongTb.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(152, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mã Phòng:";
            // 
            // DanhSachPhongDGV
            // 
            this.DanhSachPhongDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachPhongDGV.Location = new System.Drawing.Point(12, 12);
            this.DanhSachPhongDGV.Name = "DanhSachPhongDGV";
            this.DanhSachPhongDGV.RowHeadersWidth = 51;
            this.DanhSachPhongDGV.RowTemplate.Height = 24;
            this.DanhSachPhongDGV.Size = new System.Drawing.Size(693, 361);
            this.DanhSachPhongDGV.TabIndex = 53;
            this.DanhSachPhongDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DanhSachPhongDGV_CellContentClick);
            // 
            // sonotb
            // 
            this.sonotb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sonotb.Location = new System.Drawing.Point(300, 472);
            this.sonotb.Name = "sonotb";
            this.sonotb.Size = new System.Drawing.Size(169, 34);
            this.sonotb.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(95, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 55;
            this.label2.Text = "Số tiền còn nợ:";
            // 
            // XemSoTienPhongConNoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(725, 536);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sonotb);
            this.Controls.Add(this.DanhSachPhongDGV);
            this.Controls.Add(this.danhSachPhongBt);
            this.Controls.Add(this.maPhongTb);
            this.Controls.Add(this.label1);
            this.Name = "XemSoTienPhongConNoForm";
            this.Text = "XemSoTienPhongConNoForm";
            this.Load += new System.EventHandler(this.XemSoTienPhongConNoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachPhongDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button danhSachPhongBt;
        private System.Windows.Forms.TextBox maPhongTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DanhSachPhongDGV;
        private System.Windows.Forms.TextBox sonotb;
        private System.Windows.Forms.Label label2;
    }
}