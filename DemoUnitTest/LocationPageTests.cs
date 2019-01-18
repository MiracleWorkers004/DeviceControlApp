using System;
using System.Threading.Tasks;
using DemoUnitTest;
using DeviceControlApp.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeviceControlApp.UnitTests
{
    [TestClass]
    public class LocationPageTests
    {
        //Initially_coordinates_are_empty
        //When_we_hit_back_then_we_go_home_page
        //When_we_hit_get_location_then_location_is_displayed
        //When_we_hit_clear_then_location_is_cleared


        [TestMethod]
        public void Test1Location()
        {
            var dummyPageService = new DummyPageService();
            var dummyLocationService = new DummyLocationService();
            var productPageViewModel = new ProductViewModel(dummyPageService, dummyLocationService);
            var canGetLocation = productPageViewModel.DisplayLocationCommand.CanExecute(null);
            Assert.AreEqual(true, canGetLocation);
            productPageViewModel.DisplayLocationCommand.Execute(null);

            Assert.AreEqual("1.0", productPageViewModel.Latitude);
            Assert.AreEqual("2.0", productPageViewModel.Longitude);

        }
    }
}
