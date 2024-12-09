namespace Tyuiu.RubanovEO.Sprint6.Task3.V21
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
            dataGridViewtable = new DataGridView();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            textBoxResult = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewtable).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewtable);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(555, 299);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // dataGridViewtable
            // 
            dataGridViewtable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewtable.ColumnHeadersVisible = false;
            dataGridViewtable.Location = new Point(308, 22);
            dataGridViewtable.Name = "dataGridViewtable";
            dataGridViewtable.RowHeadersVisible = false;
            dataGridViewtable.Size = new Size(240, 271);
            dataGridViewtable.TabIndex = 1;
            dataGridViewtable.KeyPress += dataGridViewtable_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(296, 271);
            textBox1.TabIndex = 0;
            textBox1.Text = "Дана матрица 5 на 5\r\n  26  -15   7    1   -4\r\n  14   26   22  17  27\r\n  -8   31   22  34   4\r\n -18  16   -2  16   27\r\n    5     2   -4  16  15  \r\nотсортировать первый столбик по возрастанию";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonHelp);
            groupBox2.Controls.Add(buttonDone);
            groupBox2.Controls.Add(textBoxResult);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(573, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(138, 299);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(6, 270);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(23, 23);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(46, 270);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(75, 23);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 55);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(126, 134);
            textBoxResult.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 323);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 21 | Рубанов Е. О.";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewtable).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridViewtable;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button buttonHelp;
        private Button buttonDone;
        private TextBox textBoxResult;
        private Label label1;
    }
}
