using Tyuiu.skirnevskyBR.Sprint1.Task3.V5.Lib;
namespace Tyuiu.skirnevskyBR.Sprint1.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Validexpressiong()
        {
            DataService ds = new DataService();
            double x = 120;
            double y = 3.5;
            double wait = 420;
            var res = ds.DistanceLength(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
