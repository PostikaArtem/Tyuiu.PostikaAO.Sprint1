using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PostikaAO.Sprint1.Task4.V27.Lib;

namespace Tyuiu.PostikaAO.Sprint1.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 1.70711;
            var res = ds.Calculate(x, y);
            var afterRound=Math.Round(res, 5);
            Assert.AreEqual(wait, afterRound);
        }
    }
}
