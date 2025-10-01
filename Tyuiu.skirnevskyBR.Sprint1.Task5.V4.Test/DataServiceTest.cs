using Tyuiu.skirnevskyBR.Sprint1.Task5.V4.Lib;
namespace Tyuiu.skirnevskyBR.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VaLidExpression()
        {
            int x = 13257;
            int wait = 3;
            DataService ds = new DataService();
            int res = ds.SecondsToHours(x);
            Assert.AreEqual(wait, res);
        }
    }
}
