
namespace QuanLyKhachSan
{
    partial class DoiMatKhauForm
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
            this.huyBt = new System.Windows.Forms.Button();
            this.doiMatKhauBt = new System.Windows.Forms.Button();
            this.repassTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PassTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // huyBt
            // 
            this.huyBt.BackColor = System.Drawing.Color.OrangeRed;
            this.huyBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.huyBt.Location = new System.Drawing.Point(252, 121);
            this.huyBt.Name = "huyBt";
            this.huyBt.Size = new System.Drawing.Size(175, 42);
            this.huyBt.TabIndex = 47;
            this.huyBt.Text = "Hủy";
            this.huyBt.UseVisualStyleBackColor = false;
            // 
            // doiMatKhauBt
            // 
            this.doiMatKhauBt.BackColor = System.Drawing.Color.Lime;
            this.doiMatKhauBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.doiMatKhauBt.Location = new System.Drawing.Point(55, 121);
            this.doiMatKhauBt.Name = "doiMatKhauBt";
            this.doiMatKhauBt.Size = new System.Drawing.Size(175, 42);
            this.doiMatKhauBt.TabIndex = 46;
            this.doiMatKhauBt.Text = "Đổi mật khẩu";
            this.doiMatKhauBt.UseVisualStyleBackColor = false;
            this.doiMatKhauBt.Click += new System.EventHandler(this.doiMatKhauBt_Click);
            // 
            // repassTb
            // 
            this.repassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.repassTb.Location = new System.Drawing.Point(233, 66);
            this.repassTb.Name = "repassTb";
            this.repassTb.PasswordChar = '*';
            this.repassTb.Size = new System.Drawing.Size(220, 28);
            this.repassTb.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(42, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 24);
            this.label9.TabIndex = 44;
            this.label9.Text = "Password:";
            // 
            // PassTb
            // 
            this.PassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PassTb.Location = new System.Drawing.Point(233, 20);
            this.PassTb.Name = "PassTb";
            this.PassTb.PasswordChar = '*';
            this.PassTb.Size = new System.Drawing.Size(220, 28);
            this.PassTb.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(42, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "Re-enter Password:";
            // 
            // DoiMatKhauForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(485, 191);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.huyBt);
            this.Controls.Add(this.doiMatKhauBt);
            this.Controls.Add(this.repassTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PassTb);
            this.Name = "DoiMatKhauForm";
            this.Text = "DoiMatKhauForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button huyBt;
        private System.Windows.Forms.Button doiMatKhauBt;
        private System.Windows.Forms.TextBox repassTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PassTb;
        private System.Windows.Forms.Label label1;
    }
}