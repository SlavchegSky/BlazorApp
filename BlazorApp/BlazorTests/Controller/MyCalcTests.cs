using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blazor.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.Controller.Tests
{
    [TestClass()]
    public class MyCalcTests
    {
        [TestMethod()]
        public void SumTest_20_30_50returned()
        {
            int x = 20;
            int y = 30;
            int expected = 50;

            MyCalc c = new MyCalc();

            int actual = c.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}