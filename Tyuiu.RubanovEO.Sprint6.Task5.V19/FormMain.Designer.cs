namespace Tyuiu.RubanovEO.Sprint6.Task5.V19
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            buttonHelp = new Button();
            buttonOpen = new Button();
            buttonDone = new Button();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            dataGridViewMain = new DataGridView();
            panel3 = new Panel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonOpen);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 100);
            panel1.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.FromArgb(128, 128, 255);
            buttonHelp.Location = new Point(706, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(88, 75);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.BackColor = Color.Blue;
            buttonOpen.Location = new Point(612, 12);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(88, 75);
            buttonOpen.TabIndex = 2;
            buttonOpen.Text = "Открыть файл";
            buttonOpen.UseVisualStyleBackColor = false;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone.Location = new Point(518, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(88, 75);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(512, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(506, 78);
            textBox1.TabIndex = 0;
            textBox1.Text = "Прочитать данные из файла InPutFileTask5.txt. Вывести в dataGridView \r\nположительные значения и построить диаграмму по этим значениям.";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 350);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewMain);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 350);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод данных:";
            // 
            // dataGridViewMain
            // 
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain.ColumnHeadersVisible = false;
            dataGridViewMain.Dock = DockStyle.Fill;
            dataGridViewMain.Location = new Point(3, 19);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.RowHeadersVisible = false;
            dataGridViewMain.Size = new Size(194, 328);
            dataGridViewMain.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(chart1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(608, 350);
            panel3.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 0);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(608, 350);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Form1";
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Panel panel2;
        private GroupBox groupBox1;
        private DataGridView dataGridViewMain;
        private Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button buttonHelp;
        private Button buttonOpen;
        private Button buttonDone;
    }
}
