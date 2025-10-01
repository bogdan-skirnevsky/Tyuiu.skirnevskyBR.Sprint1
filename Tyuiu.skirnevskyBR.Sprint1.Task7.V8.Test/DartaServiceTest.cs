﻿using Tyuiu.skirnevskyBR.Sprint1.V8.Lib;
namespace Tyuiu.skirnevskyBR.Sprint1.V8.Test
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
            double wait = 9.663;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
