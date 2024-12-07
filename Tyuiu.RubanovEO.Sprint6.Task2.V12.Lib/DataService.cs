
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RubanovEO.Sprint6.Task2.V12.Lib
{
    public class DataService : ISprint6Task2V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            List<double> ans = new List<double>();
            for (double i = startValue; i <= stopValue; i++)
            {
                ans.Add(Math.Round(((2d * i + 6d)/(Math.Cos(i) + i)) - 3d, 2));
            }
            double[] ans_ = ans.ToArray();
            return ans_;
        }
    }
}
