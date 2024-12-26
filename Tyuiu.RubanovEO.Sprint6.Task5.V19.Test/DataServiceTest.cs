using Tyuiu.RubanovEO.Sprint6.Task5.V19.Lib;

namespace Tyuiu.RubanovEO.Sprint6.Task5.V19.Test
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
            Assert.AreEqual(new double[]{2.9,1.92,5.6,6.5,7.2,7.45},ds.LoadFromDataFile(@"C:\Users\Egor\Desktop\for test\task5_test.txt"));
        }
    }
}