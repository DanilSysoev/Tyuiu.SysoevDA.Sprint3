using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint3.Task3.V4.Lib;
    
namespace Tyuiu.SysoevDA.Sprint3.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();
            string str = "plkjjdw cvjkl";
            char chr = 'j';

            Assert.AreEqual("plkdw cvkl", ds.DeleteCharInString(str, chr));
        }
    }
}
