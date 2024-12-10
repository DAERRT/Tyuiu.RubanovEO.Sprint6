using Tyuiu.RubanovEO.Sprint6.Task6.V12;
using Tyuiu.RubanovEO.Sprint6.Task7.V15.Lib;

namespace Tyuiu.RubanovEO.Sprint6.Task7.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialog.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public int[,] LoadFromFileData(string path)
        {
            string fileData = File.ReadAllText(path);


            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_i = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_i[j]);
                }
            }
            return arrayValues;

        }


        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            openFilePath = openFileDialog.FileName;

            int[,] arrayValues = new int[rows, columns];
            
            arrayValues = LoadFromFileData(openFilePath);


            dataGridViewIn.ColumnCount = columns;
            dataGridViewIn.RowCount = rows;
            dataGridViewOut.ColumnCount = columns;
            dataGridViewOut.RowCount = rows;


            for (int i = 0;i < columns;i++)
            {
                dataGridViewOut.Columns[i].Width = 25;
                dataGridViewIn.Columns[i].Width = 25;
            }


            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone.Enabled = true;

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOut.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "OutPutFileTask7V12.csv";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.ShowDialog();

            string path = saveFileDialog.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut.RowCount;
            int columns = dataGridViewOut.ColumnCount;

            string str = "";

            for (int i = 0;i < rows;i++)
            {
                for (int j = 0;j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
