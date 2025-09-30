using Tyuiu.skirnevskyBR.Sprint1.Task4.V12.Lib;
namespace Tyuiu.skirnevskyBR.Sprint1.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 0;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}