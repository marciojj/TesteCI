using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloCI;

namespace TestUnitCI
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello Ci", Program.CreateMessage());
        }
    }
}
