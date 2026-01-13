using Tyuiu.skirnevskyBR.sprint1.Task6.V2.Lib;
namespace Tyuiu.skirnevskyBR.sprint1.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Привет Hello мир";
            DataService ds = new DataService();
            bool res = ds.CheckHello(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}