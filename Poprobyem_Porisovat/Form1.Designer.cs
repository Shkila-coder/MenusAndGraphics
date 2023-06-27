namespace Poprobyem_Porisovat
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.graphWind = new System.Windows.Forms.PictureBox();
            this.ch1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.graphWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 631);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Нарисовать график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // graphWind
            // 
            this.graphWind.BackColor = System.Drawing.Color.White;
            this.graphWind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graphWind.Location = new System.Drawing.Point(12, 12);
            this.graphWind.Name = "graphWind";
            this.graphWind.Size = new System.Drawing.Size(642, 613);
            this.graphWind.TabIndex = 2;
            this.graphWind.TabStop = false;
            // 
            // ch1
            // 
            chartArea1.Name = "ChartArea1";
            this.ch1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch1.Legends.Add(legend1);
            this.ch1.Location = new System.Drawing.Point(734, 19);
            this.ch1.Name = "ch1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ch1.Series.Add(series1);
            this.ch1.Size = new System.Drawing.Size(642, 606);
            this.ch1.TabIndex = 3;
            this.ch1.Text = "chart1";
            this.ch1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 679);
            this.Controls.Add(this.ch1);
            this.Controls.Add(this.graphWind);
            this.Controls.Add(this.button1);
            this.Name = "frmMain";
            this.Text = "График";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graphWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox graphWind;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch1;
    }
}

