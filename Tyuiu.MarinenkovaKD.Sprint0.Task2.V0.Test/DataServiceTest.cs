using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MarinenkovaKD.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Кристина";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Кристина", res);
        }
    }
}
