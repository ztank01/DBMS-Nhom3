
namespace QuanLyKhachSan
{
    partial class DanhSachPhongForm
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
            this.chonBt = new System.Windows.Forms.Button();
            this.idTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DanhSachPhongDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachPhongDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // chonBt
            // 
            this.chonBt.BackColor = System.Drawing.SystemColors.Info;
            this.chonBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chonBt.Location = new System.Drawing.Point(266, 303);
            this.chonBt.Name = "chonBt";
            this.chonBt.Size = new System.Drawing.Size(264, 48);
            this.chonBt.TabIndex = 13;
            this.chonBt.Text = "Chọn";
            this.chonBt.UseVisualStyleBackColor = false;
            this.chonBt.Click += new System.EventHandler(this.chonBt_Click);
            // 
            // idTb
            // 
            this.idTb.Enabled = false;
            this.idTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.idTb.Location = new System.Drawing.Point(363, 254);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(124, 34);
            this.idTb.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(309, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID: ";
            // 
            // DanhSachPhongDGV
            // 
            this.DanhSachPhongDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachPhongDGV.Location = new System.Drawing.Point(12, 12);
            this.DanhSachPhongDGV.Name = "DanhSachPhongDGV";
            this.DanhSachPhongDGV.RowHeadersWidth = 51;
            this.DanhSachPhongDGV.RowTemplate.Height = 24;
            this.DanhSachPhongDGV.Size = new System.Drawing.Size(776, 236);
            this.DanhSachPhongDGV.TabIndex = 10;
            this.DanhSachPhongDGV.Click += new System.EventHandler(this.DanhSachDichVuDGV_Click);
            // 
            // DanhSachPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.chonBt);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DanhSachPhongDGV);
            this.Name = "DanhSachPhongForm";
            this.Text = "DanhSachPhongForm";
            this.Load += new System.EventHandler(this.DanhSachPhongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachPhongDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chonBt;
        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DanhSachPhongDGV;
    }
}