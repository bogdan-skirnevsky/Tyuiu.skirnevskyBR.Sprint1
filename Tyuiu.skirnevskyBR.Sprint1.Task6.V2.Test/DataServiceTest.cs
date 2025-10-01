using Tyuiu.skirnevskyBR.Sprint1.Task6.V18.Lib;
namespace Tyuiu.skirnevskyBR.Sprint1.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string sT = "123";
            DataService ds = new DataService();
            string res = ds.CheckNumber(sT);
            int x = Convert.ToInt32(res);
            int wait = 123;
            Assert.AreEqual(wait, x);
        }
    }
}
