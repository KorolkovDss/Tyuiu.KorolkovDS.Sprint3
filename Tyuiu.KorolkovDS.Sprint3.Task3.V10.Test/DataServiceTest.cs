using Tyuiu.KorolkovDS.Sprint3.Task3.V10.Lib;

namespace Tyuiu.KorolkovDS.Sprint3.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "gdfppf vfppt p";
            char item = 'c';
            string res = ds.DeleteCharInString(value, item);
            string wait = "gdff vft ";
            Assert.AreEqual(wait, res);

        }
    }
}
