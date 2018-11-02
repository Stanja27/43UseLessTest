using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _43UseLessTest;


namespace UseLessUnitTest
{
    [TestClass]
    public class UseLessUnitTest1
    {
        UseLessClass use = new UseLessClass();

        [TestMethod]
        public void TestGetOutputAbsurdNonsense()
        {
            string expected = "Absurd Nonsense";
            string actual = use.GetOutput(15);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetOutputAbsurd()
        {
            string expected = "Absurd";
            string actual = use.GetOutput(18);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetOutputNonsense()
        {
            string expected = "Nonsense";
            string actual = use.GetOutput(25);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetOutputReturnNumber()
        {
            string expected = "13";
            string actual = use.GetOutput(13);
            Assert.AreEqual(expected, actual);
        }
    }
}
