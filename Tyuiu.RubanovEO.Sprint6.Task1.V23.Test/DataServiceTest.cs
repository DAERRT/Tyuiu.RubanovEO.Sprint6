using Tyuiu.RubanovEO.Sprint6.Task1.V23.Lib;

namespace Tyuiu.RubanovEO.Sprint6.Task1.V23.Test
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
            Assert.AreEqual(new double[] { -0.65, 5.57, 14.02, 12.37, -3.3 }, ds.GetMassFunction(1, 5));
        }
    }
}