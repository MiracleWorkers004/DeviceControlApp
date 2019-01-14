using System;
using DeviceControlApp.Model;
using NUnit.Framework;

namespace iOSDemo
{
    [TestFixture]
    public class DemoIOSTest
    {
        [Test]
        public void Pass()
        {
            Assert.True(true);
            var demo = new DemoDate();
            demo.Message = "Hi";
            Assert.AreEqual("Hi", demo.Message);

        }

        [Test]
        public void Fail()
        {
            Assert.False(true);
        }

        [Test]
        [Ignore("another time")]
        public void Ignore()
        {
            Assert.True(false);
        }
    }
}
