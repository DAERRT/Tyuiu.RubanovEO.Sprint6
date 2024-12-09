using Tyuiu.RubanovEO.Sprint6.Task3.V21.Lib;

namespace Tyuiu.RubanovEO.Sprint6.Task3.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] {
                        { 26, -15, 7, 1, -4 },
                        { 14, 26, 22, 17, 27 },
                        { -8, 31, 22, 34, 4 },
                        { -18, 16, -2, 16, 27 },
                        { 5, 2, -4, 16, 15 }};

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewtable.RowCount = matrix.GetLength(0);
            dataGridViewtable.ColumnCount = matrix.GetLength(1);

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                dataGridViewtable.Columns[i].Width = 25;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewtable.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = Convert.ToInt32(dataGridViewtable.Rows[i].Cells[j].Value);
                    }
                }

                matrix = ds.Calculate(matrix);

                for(int i = 0;i < matrix.GetLength(0); i++)
                {
                    for(int j = 0;j < matrix.GetLength(1); j++)
                    {
                        textBoxResult.AppendText(matrix[i, j].ToString() + "   ");
                    }
                    textBoxResult.AppendText(Environment.NewLine);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТБ-24-1 Рубанов Егор Олегович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewtable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
