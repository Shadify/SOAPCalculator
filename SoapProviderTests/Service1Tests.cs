using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoapProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoapProviderTests.MathService;

namespace SoapProvider.Tests
{
    [TestClass]
    public class Service1Tests
    {
        Service1 client = new Service1();


        [TestMethod]
        public void AddTest()
        {
            Assert.AreEqual(10, client.Add(5, 5));
        }

        [TestMethod]
        public void MinusTest()
        {
            Assert.AreEqual(0, client.Minus(5, 5));
        }

        [TestMethod]
        public void MultiplyTest()
        {
            Assert.AreEqual(75, client.Multiply(15, 5));
        }

        [TestMethod]
        public void DivideTest()
        {
            Assert.AreEqual(5, client.Divide(25, 5));
        }

        [TestMethod]
        public void DivideByZeroTest()
        {
            Assert.AreEqual(0, client.Divide(10, 0));
        }
    }
}