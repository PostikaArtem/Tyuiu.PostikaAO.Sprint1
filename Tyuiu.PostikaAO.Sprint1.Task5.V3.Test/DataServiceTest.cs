using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PostikaAO.Sprint1.Task5.V2.Lib;

namespace Tyuiu.PostikaAO.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 12;
            double res = ds.FahrenheitToСelsius(x);

            Assert.AreEqual(54, res);

        }
    }
}
