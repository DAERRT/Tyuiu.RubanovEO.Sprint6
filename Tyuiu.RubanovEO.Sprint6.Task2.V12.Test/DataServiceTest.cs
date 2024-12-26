using Tyuiu.RubanovEO.Sprint6.Task2.V12.Lib;

namespace Tyuiu.RubanovEO.Sprint6.Task2.V12.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(new double[] { 2.19, 3.31, 2.97, 1.18, 0.03}, ds.GetMassFunction(1, 5));
        }
    }
}