using Tyuiu.RubanovEO.Sprint6.Task7.V15.Lib;

namespace Tyuiu.RubanovEO.Sprint6.Task7.V15.Test
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
            Assert.That(ds.GetMatrix(@"C:\Users\olego\Desktop\lol.csv"), Is.EqualTo(new int[,]{{1,2,3}, {1,2,3 }}));
        }
    }
}