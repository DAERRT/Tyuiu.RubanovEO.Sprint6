
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RubanovEO.Sprint6.Task7.V15.Lib
{
    public class DataService : ISprint6Task7V15
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);


            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_i = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i,j] = Convert.ToInt32(line_i[j]);
                }
            }
            
            for (int i = 0;i < arrayValues.GetLength(0); i++)
            {
                for (int j = 0;j < arrayValues.GetLength(1); j++)
                {
                    if (j == 6 && arrayValues[i,j] < 10 && arrayValues[i,j] % 3 == 0)
                    {
                        arrayValues[i, j] = 3;
                    }
                }
            }
            return arrayValues;
        }
    }
}
