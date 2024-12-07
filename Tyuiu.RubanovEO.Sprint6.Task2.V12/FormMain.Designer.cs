namespace Tyuiu.RubanovEO.Sprint6.Task2.V12
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            groupBox2 = new GroupBox();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            label3 = new Label();
            label2 = new Label();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBox3 = new GroupBox();
            chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunc = new DataGridView();
            label1 = new Label();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunc).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 287);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 22);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(509, 259);
            textBox3.TabIndex = 0;
            textBox3.Text = "Протабулировать функцию sin(x) на заданном диапазоне.\r\nРезультат вывести DataGridView и построить график функции.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxStop);
            groupBox2.Controls.Add(textBoxStart);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 305);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(295, 80);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(147, 42);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(142, 23);
            textBoxStop.TabIndex = 3;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 42);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(135, 23);
            textBoxStart.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 24);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 1;
            label3.Text = "Конец шага:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 24);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 0;
            label2.Text = "Старт шага:";
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.Highlight;
            buttonHelp.Location = new Point(313, 313);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(80, 72);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.LimeGreen;
            buttonDone.Location = new Point(399, 313);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(134, 72);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chartMain);
            groupBox3.Controls.Add(dataGridViewFunc);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(539, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(596, 373);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // chartMain
            // 
            chartArea4.Name = "ChartArea1";
            chartMain.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartMain.Legends.Add(legend4);
            chartMain.Location = new Point(158, 37);
            chartMain.Name = "chartMain";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartMain.Series.Add(series4);
            chartMain.Size = new Size(432, 327);
            chartMain.TabIndex = 2;
            chartMain.Text = "chart1";
            // 
            // dataGridViewFunc
            // 
            dataGridViewFunc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunc.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunc.Location = new Point(6, 37);
            dataGridViewFunc.Name = "dataGridViewFunc";
            dataGridViewFunc.RowHeadersVisible = false;
            dataGridViewFunc.Size = new Size(146, 327);
            dataGridViewFunc.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Результат:";
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 70;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.Name = "Y";
            Y.Width = 70;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 397);
            Controls.Add(groupBox3);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private Label label3;
        private Label label2;
        private Button buttonHelp;
        private Button buttonDone;
        private GroupBox groupBox3;
        private DataGridView dataGridViewFunc;
        private Label label1;
        private TextBox textBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
    }
}
