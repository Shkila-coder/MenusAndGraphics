﻿namespace RandomFigures
{
    partial class Form1
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
            this.graphWind = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graphWind)).BeginInit();
            this.SuspendLayout();
            // 
            // graphWind
            // 
            this.graphWind.BackColor = System.Drawing.Color.White;
            this.graphWind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graphWind.Location = new System.Drawing.Point(28, 26);
            this.graphWind.Name = "graphWind";
            this.graphWind.Size = new System.Drawing.Size(731, 299);
            this.graphWind.TabIndex = 0;
            this.graphWind.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.graphWind);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graphWind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox graphWind;
        private System.Windows.Forms.Button button1;
    }
}

