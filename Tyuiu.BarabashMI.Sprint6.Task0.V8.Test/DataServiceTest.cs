using Tyuiu.BarabashMI.Sprint6.Task0.V8.Lib;
namespace Tyuiu.BarabashMI.Sprint6.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = 6.425;
            double res = ds.Calculate(3);
            Assert.AreEqual(wait, res);
        }
    }
}
