﻿namespace Tyuiu.RubanovEO.Sprint6.Task6.V12
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 249);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 12);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 1;
            label1.Text = "Разработчик: Рубанов Е.О.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 27);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 2;
            label2.Text = "Группа: ПКТб-24-1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 85);
            label3.Name = "label3";
            label3.Size = new Size(303, 15);
            label3.TabIndex = 3;
            label3.Text = "Программа разработана в рамках изучения языка C#";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 133);
            label4.Name = "label4";
            label4.Size = new Size(282, 15);
            label4.TabIndex = 4;
            label4.Text = "Тюменский индустриальный университет (с) 2024";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 148);
            label5.Name = "label5";
            label5.Size = new Size(264, 15);
            label5.TabIndex = 5;
            label5.Text = "Высшая школа цифровых технологий (с) 2025";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(207, 202);
            label6.Name = "label6";
            label6.Size = new Size(288, 15);
            label6.TabIndex = 6;
            label6.Text = "Внутреннее имя: Tyuiu.RubanovEO.Sprint6.Task6.V12";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(426, 236);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(101, 25);
            buttonOk.TabIndex = 7;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 274);
            Controls.Add(buttonOk);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonOk;
    }
}