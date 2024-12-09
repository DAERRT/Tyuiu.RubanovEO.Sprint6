
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RubanovEO.Sprint6.Task4.V11.Lib
{
    public class DataService : ISprint6Task4V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue-startValue];
            double j = startValue;
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = Math.Round(Math.Cos(j) + (Math.Sin(j)/(2d-(2d*j))) - 4d*j, 3);
                j++;
            }
            return res;
        }
    }
}
