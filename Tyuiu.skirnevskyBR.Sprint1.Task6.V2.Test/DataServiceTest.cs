using Tyuiu.skirnevskyBR.Sprint1.Task6.V2.Lib;
namespace Tyuiu.skirnevskyBR.Sprint1.Task6.V2.Test
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

        [TestMethod]
        public void ValidStringWithoutHello()
        {
            string strTest = "Привет мир как дела";
            DataService ds = new DataService();
            bool res = ds.CheckHello(strTest);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidStringHelloWithPunctuation()
        {
            string strTest = "Hello, мир!";
            DataService ds = new DataService();
            bool res = ds.CheckHello(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidStringEmpty()
        {
            string strTest = "";
            DataService ds = new DataService();
            bool res = ds.CheckHello(strTest);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidStringOnlyHello()
        {
            string strTest = "Hello";
            DataService ds = new DataService();
            bool res = ds.CheckHello(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}