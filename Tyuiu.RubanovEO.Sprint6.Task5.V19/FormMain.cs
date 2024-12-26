using Tyuiu.RubanovEO.Sprint6.Task5.V19.Lib;

namespace Tyuiu.RubanovEO.Sprint6.Task5.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = $@"C:\Users\Egor\source\repos\Tyuiu.RubanovEO.Sprint6\InPutFileTask5V19.txt";
       
        private void buttonDone_Click(object sender, EventArgs e)
        {

            dataGridViewMain.ColumnCount = 2;
            dataGridViewMain.Columns[0].Width = 20;
            dataGridViewMain.Columns[1].Width = 50;

            this.chart1.ChartAreas[0].AxisX.Title = "Ось X";
            this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";

            chart1.Series[0].Points.Clear();

            double[] doubles = ds.LoadFromDataFile(path);

            for (int i = 0; i < doubles.Length; i++)
            {
                dataGridViewMain.Rows.Add(Convert.ToString(i), Convert.ToString(doubles[i]));
                chart1.Series[0].Points.AddXY(i, doubles[i]);
            }
            buttonOpen.Enabled = true;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТБ-24-1 Рубанов Егор Олегович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
