using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint3.Task0.V16.Lib;

namespace Tyuiu.SysoevDA.Sprint3.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 11;
            Assert.AreEqual(63601470092869632000000.0, ds.GetSumSeries(value));
        }
    }
}
