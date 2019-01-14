using System;
using System.IO;
using System.Linq;
using DeviceControlApp.Model;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace DeviceControlApp.Tests
{
   // [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            var demo = new DemoDate();
            demo.Message = "Hi1s";
            Assert.AreEqual("Hi", demo.Message);
            app.Screenshot("First screen.");
        }
    }
}
