using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint3.Task4.V27.Lib;

namespace Tyuiu.SysoevDA.Sprint3.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-44.313, ds.Calculate(-5, 5));
        }
    }
}
