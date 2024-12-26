using Tyuiu.RubanovEO.Sprint6.Task6.V12.Lib;

namespace Tyuiu.RubanovEO.Sprint6.Task6.V12.Test
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
            Assert.AreEqual("walk", ds.CollectTextFromFile(@"C:\Users\Egor\Desktop\for test\task6_test.txt"));
        }
    }
}