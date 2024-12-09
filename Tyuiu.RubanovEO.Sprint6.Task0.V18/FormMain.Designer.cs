namespace Tyuiu.RubanovEO.Sprint6.Task0.V18
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBoxVariable = new TextBox();
            labelVariable = new Label();
            groupBox3 = new GroupBox();
            textBoxResult = new TextBox();
            label4 = new Label();
            button_Done = new Button();
            buttonQuestion = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 190);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.Снимок_экрана_2024_12_03_225519;
            pictureBox1.Location = new Point(393, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 64);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(381, 150);
            textBox1.TabIndex = 0;
            textBox1.Text = "Вычислить выражение по формуле";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxVariable);
            groupBox2.Controls.Add(labelVariable);
            groupBox2.Location = new Point(18, 208);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(310, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // textBoxVariable
            // 
            textBoxVariable.Location = new Point(99, 53);
            textBoxVariable.Name = "textBoxVariable";
            textBoxVariable.Size = new Size(96, 23);
            textBoxVariable.TabIndex = 1;
            textBoxVariable.TextChanged += textBoxVariable_TextChanged;
            textBoxVariable.KeyPress += textBoxVariable_KeyPress;
            // 
            // labelVariable
            // 
            labelVariable.AutoSize = true;
            labelVariable.Location = new Point(99, 33);
            labelVariable.Name = "labelVariable";
            labelVariable.Size = new Size(89, 15);
            labelVariable.TabIndex = 0;
            labelVariable.Text = "Переменная X:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxResult);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(334, 208);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(189, 100);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(12, 53);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(171, 23);
            textBoxResult.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 33);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 0;
            label4.Text = "Результат:";
            // 
            // button_Done
            // 
            button_Done.FlatStyle = FlatStyle.Popup;
            button_Done.Location = new Point(391, 314);
            button_Done.Name = "button_Done";
            button_Done.Size = new Size(132, 41);
            button_Done.TabIndex = 3;
            button_Done.Text = "Выполнить";
            button_Done.UseVisualStyleBackColor = true;
            button_Done.Click += buttonDone_Click;
            // 
            // buttonQuestion
            // 
            buttonQuestion.FlatStyle = FlatStyle.Flat;
            buttonQuestion.Location = new Point(334, 314);
            buttonQuestion.Name = "buttonQuestion";
            buttonQuestion.Size = new Size(51, 41);
            buttonQuestion.TabIndex = 4;
            buttonQuestion.Text = "?";
            buttonQuestion.UseVisualStyleBackColor = true;
            buttonQuestion.Click += buttonQuestion_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 367);
            Controls.Add(buttonQuestion);
            Controls.Add(button_Done);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 18 | Рубанов Е. О.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox textBoxVariable;
        private Label labelVariable;
        private GroupBox groupBox3;
        private Button button_Done;
        private Button buttonQuestion;
        private TextBox textBoxResult;
        private Label label4;
    }
}
