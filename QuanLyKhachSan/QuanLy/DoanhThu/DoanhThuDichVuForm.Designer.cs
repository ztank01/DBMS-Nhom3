
namespace QuanLyKhachSan
{
    partial class DoanhThuDichVuForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.xembt = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radioButtonNgay = new System.Windows.Forms.RadioButton();
            this.radioButtonThang = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelNgay = new System.Windows.Forms.Label();
            this.labelDichVu = new System.Windows.Forms.Label();
            this.labelTongDoanhThu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đang chọn ngày: ";
            // 
            // xembt
            // 
            this.xembt.BackColor = System.Drawing.Color.Lime;
            this.xembt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xembt.Location = new System.Drawing.Point(161, 276);
            this.xembt.Name = "xembt";
            this.xembt.Size = new System.Drawing.Size(174, 46);
            this.xembt.TabIndex = 3;
            this.xembt.Text = "Xem";
            this.xembt.UseVisualStyleBackColor = false;
            this.xembt.Click += new System.EventHandler(this.xembt_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 344);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(551, 343);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // radioButtonNgay
            // 
            this.radioButtonNgay.AutoSize = true;
            this.radioButtonNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButtonNgay.Location = new System.Drawing.Point(76, 237);
            this.radioButtonNgay.Name = "radioButtonNgay";
            this.radioButtonNgay.Size = new System.Drawing.Size(148, 33);
            this.radioButtonNgay.TabIndex = 5;
            this.radioButtonNgay.TabStop = true;
            this.radioButtonNgay.Text = "Theo ngày";
            this.radioButtonNgay.UseVisualStyleBackColor = true;
            // 
            // radioButtonThang
            // 
            this.radioButtonThang.AutoSize = true;
            this.radioButtonThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButtonThang.Location = new System.Drawing.Point(273, 237);
            this.radioButtonThang.Name = "radioButtonThang";
            this.radioButtonThang.Size = new System.Drawing.Size(156, 33);
            this.radioButtonThang.TabIndex = 6;
            this.radioButtonThang.TabStop = true;
            this.radioButtonThang.Text = "Theo tháng";
            this.radioButtonThang.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(27, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng doanh thu là: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(27, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doanh thu dịch vụ là: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 183);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(283, 34);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(595, 510);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 164);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Người thực hiện:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "GVHD: TS. Nguyễn Thành Sơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Võ Trường Duy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Trịnh Công Trưởng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Hồ Huy Luật";
            // 
            // labelNgay
            // 
            this.labelNgay.AutoSize = true;
            this.labelNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgay.Location = new System.Drawing.Point(300, 24);
            this.labelNgay.Name = "labelNgay";
            this.labelNgay.Size = new System.Drawing.Size(0, 25);
            this.labelNgay.TabIndex = 11;
            // 
            // labelDichVu
            // 
            this.labelDichVu.AutoSize = true;
            this.labelDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDichVu.Location = new System.Drawing.Point(300, 78);
            this.labelDichVu.Name = "labelDichVu";
            this.labelDichVu.Size = new System.Drawing.Size(0, 25);
            this.labelDichVu.TabIndex = 12;
            // 
            // labelTongDoanhThu
            // 
            this.labelTongDoanhThu.AutoSize = true;
            this.labelTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongDoanhThu.Location = new System.Drawing.Point(300, 131);
            this.labelTongDoanhThu.Name = "labelTongDoanhThu";
            this.labelTongDoanhThu.Size = new System.Drawing.Size(0, 25);
            this.labelTongDoanhThu.TabIndex = 13;
            // 
            // DoanhThuDichVuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 686);
            this.Controls.Add(this.labelTongDoanhThu);
            this.Controls.Add(this.labelDichVu);
            this.Controls.Add(this.labelNgay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButtonThang);
            this.Controls.Add(this.radioButtonNgay);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.xembt);
            this.Controls.Add(this.label1);
            this.Name = "DoanhThuDichVuForm";
            this.Text = "DoanhThuDichVuForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button xembt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton radioButtonNgay;
        private System.Windows.Forms.RadioButton radioButtonThang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelNgay;
        private System.Windows.Forms.Label labelDichVu;
        private System.Windows.Forms.Label labelTongDoanhThu;
    }
}