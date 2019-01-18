using DeviceControlApp.Model;
using System.Threading.Tasks;

using DeviceControlApp.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NSubstitute;

namespace DemoUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var demo = new DemoDate();
            demo.Message = "Hi";
            Assert.AreEqual("Hi", demo.Message);
        }


        [TestMethod]
        public void When_we_go_next_in_home_then_we_go_to_products_page()
        {
            var dummyPageService = new DummyPageService();
            var locationdumyService = new DummyLocationService();
            var homePageViewModel = new HomePageViewModel(dummyPageService,locationdumyService);
            var canGoNext = homePageViewModel.NextCommand.CanExecute(null);
            homePageViewModel.NextCommand.Execute(null);

            Assert.AreEqual(true, canGoNext);
            Assert.AreEqual(typeof(ProductViewModel), dummyPageService.GetViewModelPageType());
        }

        [TestMethod]
        public void When_we_Click_Next_Page()
        {
            //bool IsMoved = false;
            //var pageService = Substitute.For<IPageService>();
            //pageService.GoNext(new object()).Do(()=>{
            //    IsMoved = true;
            //});
        }
        [TestMethod]
        public void Test1Location()
        {
            var dummyPageService = new DummyPageService();
            var dummyLocationService = new DummyLocationService();
            var productPageViewModel = new ProductViewModel(dummyPageService,dummyLocationService);
            var canGetLocation = productPageViewModel.DisplayLocationCommand.CanExecute(null);
            Assert.AreEqual(true, canGetLocation);
            productPageViewModel.DisplayLocationCommand.Execute(null);

            Assert.AreEqual("1.0", productPageViewModel.Latitude);
            Assert.AreEqual("2.0", productPageViewModel.Longitude);

        }


    }

    public class DummyPageService : IPageService
    {
        public Type GetViewModelPageType()
        {
            return _viewModel.GetType();
        }

        public async Task GoNext(Type viewModelType)
        {
            throw new NotImplementedException();
        }

        private object _viewModel;

        public async Task GoNext(object viewModel)
        {
            _viewModel = viewModel;
        }

      
    }
}
