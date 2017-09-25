using System;
using IntegrationTest.MathService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IntegrationAddTest()
        {
            using (Service1Client client1 = new Service1Client())
            {
                Assert.AreEqual(5, client1.Add(2, 3));
            }
        }
        [TestMethod]
        public void IntegrationMinusTest()
        {
            using (Service1Client client1 = new Service1Client())
            {
                Assert.AreEqual(-1, client1.Minus(2, 3));
            }
        }
        [TestMethod]
        public void IntegrationMultiplyTest()
        {
            using (Service1Client client1 = new Service1Client())
            {
                Assert.AreEqual(6, client1.Multiply(2, 3));
            }
        }
        [TestMethod]
        public void IntegrationDivideTest()
        {
            using (Service1Client client1 = new Service1Client())
            {
                Assert.AreEqual(2, client1.Divide(6, 3));
            }
        }
    }
}
