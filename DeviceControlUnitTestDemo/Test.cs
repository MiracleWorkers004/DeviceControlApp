using DeviceControlApp.Model;
using NUnit.Framework;
using System;
namespace DeviceControlUnitTestDemo
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            var demo = new DemoDate();
            demo.Message = "Hii";
            Assert.AreEqual("Hi", demo.Message);
        }
    }
}
