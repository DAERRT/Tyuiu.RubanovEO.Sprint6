using Tyuiu.RubanovEO.Sprint6.Task3.V21.Lib;

namespace Tyuiu.RubanovEO.Sprint6.Task3.V21.Test
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
            Assert.That(ds.Calculate(
                    new int[5, 5] { 
                        { 26, -15, 7, 1, -4 }, 
                        { 14, 26, 22, 17, 27 }, 
                        { -8, 31, 22, 34, 4 }, 
                        { -18, 16, -2, 16, 27 }, 
                        { 5, 2, -4, 16, 15 }}), 
                Is.EqualTo(
                    new int[5, 5] { 
                        { -18,-15,  7,  1,-4 },
                        { -8, 26, 22, 17,27 },
                        { 5, 31, 22, 34, 4 },
                        {14, 16, -2, 16,27 },
                        {  26,  2, -4, 16,15 }}));
        }
    }
}