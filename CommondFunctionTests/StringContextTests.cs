using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommondFunction;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommondFunction.Tests
{
    [TestClass()]
    public class StringContextTests
    {
        [TestMethod()]
        public void IsNotNullOrWhiteSpaceTest()
        {
            string cek1 = string.Empty;
            string cek2 = "        ";
            string cek3 = null;

            bool resultCek1 = cek1.IsNotNullOrWhiteSpace();
            bool resultCek2 = cek2.IsNotNullOrWhiteSpace();
            bool resultCek3 = cek3.IsNotNullOrWhiteSpace();

            Assert.IsTrue(resultCek1 == false);
            Assert.IsTrue(resultCek2 == false);
            Assert.IsTrue(resultCek3 == false);
        }
    }
}