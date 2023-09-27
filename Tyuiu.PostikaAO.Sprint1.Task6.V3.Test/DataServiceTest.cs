using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PostikaAO.Sprint1.Task6.V3.Lib;

namespace Tyuiu.PostikaAO.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string spn = "Съешь ещё этих французких булок да выпей чаю";
            string res = ds.LastLetterWord(spn);
            string wait = "ьёххкайю";
            Assert.AreEqual(wait, res);

        }
    }
}
