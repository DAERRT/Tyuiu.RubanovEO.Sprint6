namespace Tyuiu.RubanovEO.Sprint6.Task1.V23
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            textBoxResult = new TextBox();
            groupBox3 = new GroupBox();
            stopStep = new TextBox();
            startStep = new TextBox();
            label2 = new Label();
            label1 = new Label();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 229);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 22);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(410, 201);
            textBox4.TabIndex = 0;
            textBox4.Text = "Протабулировать функцию sin(x) на заданном диапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxResult);
            groupBox2.Location = new Point(440, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(261, 299);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 21);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 1;
            label3.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 39);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(249, 254);
            textBoxResult.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(stopStep);
            groupBox3.Controls.Add(startStep);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(12, 247);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(223, 64);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // stopStep
            // 
            stopStep.Location = new Point(112, 35);
            stopStep.Name = "stopStep";
            stopStep.Size = new Size(100, 23);
            stopStep.TabIndex = 3;
            stopStep.KeyPress += textBox_KeyPress;
            // 
            // startStep
            // 
            startStep.Location = new Point(6, 35);
            startStep.Name = "startStep";
            startStep.Size = new Size(100, 23);
            startStep.TabIndex = 2;
            startStep.KeyPress += textBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 19);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Конец шага:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Старт шага:";
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.Highlight;
            buttonHelp.FlatStyle = FlatStyle.Popup;
            buttonHelp.Location = new Point(241, 258);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 53);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.LimeGreen;
            buttonDone.FlatStyle = FlatStyle.Popup;
            buttonDone.Location = new Point(322, 258);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(112, 53);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 319);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 23 | Рубанов Е. О.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button buttonHelp;
        private Button buttonDone;
        private TextBox startStep;
        private Label label2;
        private Label label1;
        private TextBox stopStep;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBoxResult;
    }
}
