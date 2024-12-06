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
                MessageBox.Show("������� ������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            MessageBox.Show("���� 1 �������� ������� ������ ����-24-1 ������� ���� ��������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
