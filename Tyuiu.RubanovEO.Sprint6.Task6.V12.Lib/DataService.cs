
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RubanovEO.Sprint6.Task6.V12.Lib
{
    public class DataService : ISprint6Task6V12
    {
        public string CollectTextFromFile(string str, string path)
        {
            string[] quest = File.ReadAllText(path).Split(' ');
            string res = "";
            for (int i = 0; i < quest.Length; i++)
            {
                if (quest[i].Contains('w'))
                {
                    res += quest[i] + " ";
                }
            }
            return res.Trim();
        }
    }
}
