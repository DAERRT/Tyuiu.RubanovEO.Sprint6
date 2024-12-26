namespace Tyuiu.RubanovEO.Sprint6.Task6.V12
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonHelp = new Button();
            buttonDone = new Button();
            buttonOpen = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            groupBoxRes = new GroupBox();
            textBoxIn = new TextBox();
            panel4 = new Panel();
            groupBox3 = new GroupBox();
            textBoxOut = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxRes.SuspendLayout();
            panel4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(buttonOpen);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(820, 62);
            panel1.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.Location = new Point(731, 3);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(86, 56);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            toolTip1.SetToolTip(buttonHelp, "Открывает окно с информацией.");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.Location = new Point(98, 3);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(93, 56);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Обработать";
            toolTip1.SetToolTip(buttonDone, "Производит поиск слов включающих \"w\"");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(3, 3);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(89, 56);
            buttonOpen.TabIndex = 0;
            buttonOpen.Text = "Открыть файл";
            toolTip1.SetToolTip(buttonOpen, "Выберите нужный файл для обработки.");
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(820, 65);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(820, 65);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(814, 43);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxRes);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 127);
            panel3.Name = "panel3";
            panel3.Size = new Size(408, 362);
            panel3.TabIndex = 2;
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(textBoxIn);
            groupBoxRes.Dock = DockStyle.Fill;
            groupBoxRes.Location = new Point(0, 0);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(408, 362);
            groupBoxRes.TabIndex = 0;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Ввод:";
            // 
            // textBoxIn
            // 
            textBoxIn.Dock = DockStyle.Fill;
            textBoxIn.Location = new Point(3, 19);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.ScrollBars = ScrollBars.Vertical;
            textBoxIn.Size = new Size(402, 340);
            textBoxIn.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(408, 127);
            panel4.Name = "panel4";
            panel4.Size = new Size(412, 362);
            panel4.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxOut);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(412, 362);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод:";
            // 
            // textBoxOut
            // 
            textBoxOut.Dock = DockStyle.Fill;
            textBoxOut.Location = new Point(3, 19);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.ScrollBars = ScrollBars.Vertical;
            textBoxOut.Size = new Size(406, 340);
            textBoxOut.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 489);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 12 | Рубанов Е. О.";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxRes.ResumeLayout(false);
            groupBoxRes.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button buttonHelp;
        private Button buttonDone;
        private Button buttonOpen;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBoxRes;
        private TextBox textBoxIn;
        private GroupBox groupBox3;
        private TextBox textBoxOut;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
    }
}
