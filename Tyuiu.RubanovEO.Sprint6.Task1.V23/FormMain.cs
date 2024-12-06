using Tyuiu.RubanovEO.Sprint6.Task1.V23.Lib;

namespace Tyuiu.RubanovEO.Sprint6.Task1.V23
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
                double[] ans = ds.GetMassFunction(Convert.ToInt32(startStep.Text), Convert.ToInt32(stopStep.Text));

                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("|     X    |   f(x)   |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);

                int j = Convert.ToInt32(startStep.Text);
                for (int i = 0; i < ans.Length; i++)
                {
                    textBoxResult.AppendText($"|    {j}     |    {ans[i]}    |" + Environment.NewLine);
                    j++;
                }
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
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
