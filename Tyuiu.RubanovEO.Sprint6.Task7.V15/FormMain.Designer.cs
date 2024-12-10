namespace Tyuiu.RubanovEO.Sprint6.Task7.V15
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
            panelTop = new Panel();
            buttonHelp = new Button();
            buttonSave = new Button();
            buttonDone = new Button();
            buttonOpen = new Button();
            panelUslovie = new Panel();
            groupBoxUslovie = new GroupBox();
            textBoxUslovie = new TextBox();
            panelLeft = new Panel();
            groupBoxIn = new GroupBox();
            dataGridViewIn = new DataGridView();
            panelRight = new Panel();
            groupBoxOut = new GroupBox();
            dataGridViewOut = new DataGridView();
            splitter1 = new Splitter();
            openFileDialog = new OpenFileDialog();
            toolTip = new ToolTip(components);
            saveFileDialog = new SaveFileDialog();
            panelTop.SuspendLayout();
            panelUslovie.SuspendLayout();
            groupBoxUslovie.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBoxIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            panelRight.SuspendLayout();
            groupBoxOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonHelp);
            panelTop.Controls.Add(buttonSave);
            panelTop.Controls.Add(buttonDone);
            panelTop.Controls.Add(buttonOpen);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(800, 74);
            panelTop.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Dock = DockStyle.Right;
            buttonHelp.Location = new Point(707, 0);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(93, 74);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Информация";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSave
            // 
            buttonSave.Dock = DockStyle.Left;
            buttonSave.Enabled = false;
            buttonSave.Location = new Point(186, 0);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(93, 74);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить в файл";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.Dock = DockStyle.Left;
            buttonDone.Enabled = false;
            buttonDone.Location = new Point(93, 0);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(93, 74);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Dock = DockStyle.Left;
            buttonOpen.Location = new Point(0, 0);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(93, 74);
            buttonOpen.TabIndex = 0;
            buttonOpen.Text = "Открыть файл";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // panelUslovie
            // 
            panelUslovie.Controls.Add(groupBoxUslovie);
            panelUslovie.Dock = DockStyle.Top;
            panelUslovie.Location = new Point(0, 74);
            panelUslovie.Name = "panelUslovie";
            panelUslovie.Size = new Size(800, 77);
            panelUslovie.TabIndex = 1;
            // 
            // groupBoxUslovie
            // 
            groupBoxUslovie.Controls.Add(textBoxUslovie);
            groupBoxUslovie.Dock = DockStyle.Fill;
            groupBoxUslovie.Location = new Point(0, 0);
            groupBoxUslovie.Name = "groupBoxUslovie";
            groupBoxUslovie.Size = new Size(800, 77);
            groupBoxUslovie.TabIndex = 0;
            groupBoxUslovie.TabStop = false;
            groupBoxUslovie.Text = "Условие:";
            // 
            // textBoxUslovie
            // 
            textBoxUslovie.Dock = DockStyle.Fill;
            textBoxUslovie.Location = new Point(3, 19);
            textBoxUslovie.Multiline = true;
            textBoxUslovie.Name = "textBoxUslovie";
            textBoxUslovie.ReadOnly = true;
            textBoxUslovie.Size = new Size(794, 55);
            textBoxUslovie.TabIndex = 0;
            textBoxUslovie.Text = resources.GetString("textBoxUslovie.Text");
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(groupBoxIn);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 151);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(403, 459);
            panelLeft.TabIndex = 2;
            // 
            // groupBoxIn
            // 
            groupBoxIn.Controls.Add(dataGridViewIn);
            groupBoxIn.Dock = DockStyle.Fill;
            groupBoxIn.Location = new Point(0, 0);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Size = new Size(403, 459);
            groupBoxIn.TabIndex = 0;
            groupBoxIn.TabStop = false;
            groupBoxIn.Text = "Ввод:";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.ColumnHeadersVisible = false;
            dataGridViewIn.Dock = DockStyle.Fill;
            dataGridViewIn.Location = new Point(3, 19);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersVisible = false;
            dataGridViewIn.Size = new Size(397, 437);
            dataGridViewIn.TabIndex = 0;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(groupBoxOut);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(403, 151);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(397, 459);
            panelRight.TabIndex = 3;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(dataGridViewOut);
            groupBoxOut.Dock = DockStyle.Fill;
            groupBoxOut.Location = new Point(0, 0);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(397, 459);
            groupBoxOut.TabIndex = 0;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод:";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.ColumnHeadersVisible = false;
            dataGridViewOut.Dock = DockStyle.Fill;
            dataGridViewOut.Location = new Point(3, 19);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersVisible = false;
            dataGridViewOut.Size = new Size(391, 437);
            dataGridViewOut.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(403, 151);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 459);
            splitter1.TabIndex = 4;
            splitter1.TabStop = false;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 610);
            Controls.Add(splitter1);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelUslovie);
            Controls.Add(panelTop);
            Name = "FormMain";
            Text = "Form1";
            panelTop.ResumeLayout(false);
            panelUslovie.ResumeLayout(false);
            groupBoxUslovie.ResumeLayout(false);
            groupBoxUslovie.PerformLayout();
            panelLeft.ResumeLayout(false);
            groupBoxIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            panelRight.ResumeLayout(false);
            groupBoxOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button buttonHelp;
        private Button buttonSave;
        private Button buttonDone;
        private Button buttonOpen;
        private Panel panelUslovie;
        private GroupBox groupBoxUslovie;
        private TextBox textBoxUslovie;
        private Panel panelLeft;
        private GroupBox groupBoxIn;
        private DataGridView dataGridViewIn;
        private Panel panelRight;
        private GroupBox groupBoxOut;
        private DataGridView dataGridViewOut;
        private Splitter splitter1;
        private OpenFileDialog openFileDialog;
        private ToolTip toolTip;
        private SaveFileDialog saveFileDialog;
    }
}
