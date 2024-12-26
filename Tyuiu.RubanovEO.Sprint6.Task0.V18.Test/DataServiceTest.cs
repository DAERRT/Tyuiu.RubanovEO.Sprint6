
using Tyuiu.RubanovEO.Sprint6.Task0.V18.Lib;

namespace Tyuiu.RubanovEO.Sprint6.Task0.V18.Test
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
            Assert.AreEqual(1.056,ds.Calculate(3));
        }
    }
}