using DeviceControlApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var demo = new DemoDate();
            demo.Message = "Hi1s";
            Assert.AreEqual("Hi", demo.Message);

            Assert.Fail("hi","hi");
        }
    }
}
