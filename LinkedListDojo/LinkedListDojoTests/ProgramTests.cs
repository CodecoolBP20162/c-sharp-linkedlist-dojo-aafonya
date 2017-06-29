using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDojo.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void ToTestTest()
        {
            int fromToTestMethod = Program.ToTest();
            int testInt = 2;
            Assert.AreEqual(fromToTestMethod, testInt);
        }


    }
}