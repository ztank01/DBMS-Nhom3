
namespace QuanLyKhachSan
{
    partial class DuoiViecNhanVienForm
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
            this.DanhSachNhanVienDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.idTb = new System.Windows.Forms.TextBox();
            this.duoiViecBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachNhanVienDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DanhSachNhanVienDGV
            // 
            this.DanhSachNhanVienDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachNhanVienDGV.Location = new System.Drawing.Point(12, 12);
            this.DanhSachNhanVienDGV.Name = "DanhSachNhanVienDGV";
            this.DanhSachNhanVienDGV.RowHeadersWidth = 51;
            this.DanhSachNhanVienDGV.RowTemplate.Height = 24;
            this.DanhSachNhanVienDGV.Size = new System.Drawing.Size(776, 236);
            this.DanhSachNhanVienDGV.TabIndex = 0;
            this.DanhSachNhanVienDGV.Click += new System.EventHandler(this.DanhSachNhanVienDGV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(309, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID: ";
            // 
            // idTb
            // 
            this.idTb.Enabled = false;
            this.idTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.idTb.Location = new System.Drawing.Point(363, 254);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(124, 34);
            this.idTb.TabIndex = 4;
            // 
            // duoiViecBt
            // 
            this.duoiViecBt.BackColor = System.Drawing.Color.OrangeRed;
            this.duoiViecBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.duoiViecBt.Location = new System.Drawing.Point(266, 303);
            this.duoiViecBt.Name = "duoiViecBt";
            this.duoiViecBt.Size = new System.Drawing.Size(264, 48);
            this.duoiViecBt.TabIndex = 5;
            this.duoiViecBt.Text = "Đuổi việc";
            this.duoiViecBt.UseVisualStyleBackColor = false;
            this.duoiViecBt.Click += new System.EventHandler(this.duoiViecBt_Click);
            // 
            // DuoiViecNhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.duoiViecBt);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DanhSachNhanVienDGV);
            this.Name = "DuoiViecNhanVienForm";
            this.Text = "DuoiViecNhanVien";
            this.Load += new System.EventHandler(this.DuoiViecNhanVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachNhanVienDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DanhSachNhanVienDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Button duoiViecBt;
    }
}