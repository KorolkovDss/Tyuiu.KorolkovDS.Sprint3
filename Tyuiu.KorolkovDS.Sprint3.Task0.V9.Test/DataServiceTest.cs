using Tyuiu.KorolkovDS.Sprint3.Task0.V9.Lib;

namespace Tyuiu.KorolkovDS.Sprint3.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.5;
            int startValue = 1;
            int stopValue = 15;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait =0.43;
            Assert.AreEqual(res, wait);
        }
    }
}
