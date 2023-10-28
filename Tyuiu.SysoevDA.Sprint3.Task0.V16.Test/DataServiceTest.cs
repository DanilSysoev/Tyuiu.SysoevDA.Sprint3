using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint3.Task0.V16.Lib;

namespace Tyuiu.SysoevDA.Sprint3.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            Assert.AreEqual(63601470092869632000000.0, ds.GetMultiplySeries(1, 11));
        }
    }
}
