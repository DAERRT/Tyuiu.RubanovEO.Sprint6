using Tyuiu.RubanovEO.Sprint6.Task4.V11.Lib;

namespace Tyuiu.RubanovEO.Sprint6.Task4.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        DataService ds = new DataService();


        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Path.GetTempPath()}OutPutFileTask4.bin";
                File.WriteAllText(path, textBoxRes.Text);

                DialogResult dialogResult = MessageBox.Show("����" + path + "�������� �������!\n ������� ��� � ��������?", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            
            }
            catch
            {
                MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                double[] res = ds.GetMassFunction(Convert.ToInt32(textBoxStart.Text), Convert.ToInt32(textBoxEnd.Text));

                int startstep = Convert.ToInt32(textBoxStart.Text);

                this.chart1.ChartAreas[0].AxisX.Title = "��� X";
                this.chart1.ChartAreas[0].AxisY.Title = "��� Y";

                textBoxRes.Text = "";

                chart1.Series[0].Points.Clear();

                for (int i = 0; i < res.Length; i++)
                {
                    this.chart1.Series[0].Points.AddXY(startstep, res[i]);
                    textBoxRes.AppendText(res[i] + Environment.NewLine);
                    startstep++;
                }


            }
            catch
            {
                MessageBox.Show($"������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 4 �������� ������� ������ ����-24-1 ������� ���� ��������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
