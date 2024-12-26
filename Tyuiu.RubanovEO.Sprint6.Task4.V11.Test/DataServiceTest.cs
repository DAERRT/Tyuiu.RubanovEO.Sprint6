using Tyuiu.RubanovEO.Sprint6.Task4.V11.Lib;

namespace Tyuiu.RubanovEO.Sprint6.Task4.V11.Test
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
            Assert.AreEqual(new double[] { 20.36, 15.42, 10.99, 7.43,4.33,1,0,-8.87,-13.03,-16.53,-19.6}, ds.GetMassFunction(-5,5));
        }
    }
}