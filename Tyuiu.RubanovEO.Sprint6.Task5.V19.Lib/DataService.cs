﻿
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RubanovEO.Sprint6.Task5.V19.Lib
{
    public class DataService : ISprint6Task5V19
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] d = File.ReadAllLines(path);
            double[] doubles = new double[d.Length];
            for (int i = 0; i < d.Length; i++)
            {
                doubles[i] = Convert.ToDouble(d[i].Trim());
            }
            return doubles;
        }       
    }
}
