namespace Tyuiu.RubanovEO.Sprint6.Task4.V11
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelTop = new Panel();
            groupBox3 = new GroupBox();
            buttonHelp = new Button();
            buttonSave = new Button();
            buttonDone = new Button();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            panel2 = new Panel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelLeft = new Panel();
            groupBox1 = new GroupBox();
            textBoxRes = new TextBox();
            splitter1 = new Splitter();
            panelTop.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panelLeft.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(224, 224, 224);
            panelTop.Controls.Add(groupBox3);
            panelTop.Controls.Add(groupBox2);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(5);
            panelTop.Size = new Size(969, 100);
            panelTop.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonHelp);
            groupBox3.Controls.Add(buttonSave);
            groupBox3.Controls.Add(buttonDone);
            groupBox3.Controls.Add(textBoxEnd);
            groupBox3.Controls.Add(textBoxStart);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(465, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(542, 90);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(426, 19);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 65);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(314, 19);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(106, 65);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(222, 19);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(86, 65);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(116, 47);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(100, 23);
            textBoxEnd.TabIndex = 3;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(10, 47);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(100, 23);
            textBoxStart.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 29);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Конец шага:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 29);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Старт шага:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(5, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 90);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Условие";
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(3, 19);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(454, 68);
            textBox2.TabIndex = 0;
            textBox2.Text = "Протабулировать функцию на диапазоне от -5 до 5\r\nРезультат вывести в textbox, построить график функции и сохранить в файл\r\nOutPutFileTask4.txt по нажатию на кнопку.\r\n";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(chart1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(969, 371);
            panel2.TabIndex = 1;
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.AxisX.Maximum = 10D;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(201, 1);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(768, 370);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            title1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            title1.Name = "Title1";
            title1.Text = "График функции ";
            chart1.Titles.Add(title1);
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Blue;
            panelLeft.Controls.Add(groupBox1);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 100);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(200, 371);
            panelLeft.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(textBoxRes);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(200, 371);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод";
            // 
            // textBoxRes
            // 
            textBoxRes.BackColor = Color.White;
            textBoxRes.Dock = DockStyle.Fill;
            textBoxRes.Location = new Point(5, 21);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.ScrollBars = ScrollBars.Vertical;
            textBoxRes.Size = new Size(190, 345);
            textBoxRes.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(200, 100);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 371);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 471);
            Controls.Add(splitter1);
            Controls.Add(panelLeft);
            Controls.Add(panel2);
            Controls.Add(panelTop);
            MaximumSize = new Size(1920, 1280);
            Name = "FormMain";
            Text = "Form1";
            panelTop.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panelLeft.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panel2;
        private Panel panelLeft;
        private Splitter splitter1;
        private GroupBox groupBox1;
        private TextBox textBoxRes;
        private GroupBox groupBox3;
        private TextBox textBoxEnd;
        private TextBox textBoxStart;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private Button buttonHelp;
        private Button buttonSave;
        private Button buttonDone;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
