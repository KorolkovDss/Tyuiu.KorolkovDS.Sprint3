﻿using Tyuiu.KorolkovDS.Sprint3.Task6.V28.Lib;

namespace Tyuiu.KorolkovDS.Sprint3.Task6.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 13;
            int stopValue = 19;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 15;
            Assert.AreEqual(wait, res);
        }
    }
}
