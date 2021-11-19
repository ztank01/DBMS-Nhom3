
namespace QuanLyKhachSan
{
    partial class DanhSachKhachForm
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
            this.duoiViecBt = new System.Windows.Forms.Button();
            this.idTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DanhSachDichVuDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachDichVuDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // duoiViecBt
            // 
            this.duoiViecBt.BackColor = System.Drawing.SystemColors.Info;
            this.duoiViecBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.duoiViecBt.Location = new System.Drawing.Point(266, 303);
            this.duoiViecBt.Name = "duoiViecBt";
            this.duoiViecBt.Size = new System.Drawing.Size(264, 48);
            this.duoiViecBt.TabIndex = 17;
            this.duoiViecBt.Text = "Chọn";
            this.duoiViecBt.UseVisualStyleBackColor = false;
            this.duoiViecBt.Click += new System.EventHandler(this.duoiViecBt_Click);
            // 
            // idTb
            // 
            this.idTb.Enabled = false;
            this.idTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.idTb.Location = new System.Drawing.Point(363, 254);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(124, 34);
            this.idTb.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(309, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID: ";
            // 
            // DanhSachDichVuDGV
            // 
            this.DanhSachDichVuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachDichVuDGV.Location = new System.Drawing.Point(12, 12);
            this.DanhSachDichVuDGV.Name = "DanhSachDichVuDGV";
            this.DanhSachDichVuDGV.RowHeadersWidth = 51;
            this.DanhSachDichVuDGV.RowTemplate.Height = 24;
            this.DanhSachDichVuDGV.Size = new System.Drawing.Size(776, 236);
            this.DanhSachDichVuDGV.TabIndex = 14;
            this.DanhSachDichVuDGV.Click += new System.EventHandler(this.DanhSachDichVuDGV_Click);
            // 
            // DanhSachKhachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.duoiViecBt);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DanhSachDichVuDGV);
            this.Name = "DanhSachKhachForm";
            this.Text = "DanhSachKhachForm";
            this.Load += new System.EventHandler(this.DanhSachKhachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachDichVuDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button duoiViecBt;
        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DanhSachDichVuDGV;
    }
}