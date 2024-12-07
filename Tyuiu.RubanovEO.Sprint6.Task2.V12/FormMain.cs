using Tyuiu.RubanovEO.Sprint6.Task2.V12.Lib;

namespace Tyuiu.RubanovEO.Sprint6.Task2.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();   
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            { 
                int startstep = Convert.ToInt32(textBoxStart.Text);
                double[] ans = ds.GetMassFunction(Convert.ToInt32(textBoxStart.Text), Convert.ToInt32(textBoxStop.Text));
                
                this.chartMain.Titles.Clear();
                this.chartMain.Titles.Add("График функции sin(x)");
                this.chartMain.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartMain.ChartAreas[0].AxisY.Title = "Ось Y";

                this.dataGridViewFunc.Rows.Clear();

                for (int i = 0; i < ans.Length; i++)
                {
                    this.dataGridViewFunc.Rows.Add(startstep, Convert.ToString(ans[i]));
                    this.chartMain.Series[0].Points.AddXY(startstep, ans[i]);
                    startstep++;
                }
            }
            catch
            {
                MessageBox.Show("Неверно введены данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }


        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПКТБ-24-1 Рубанов Егор Олегович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
