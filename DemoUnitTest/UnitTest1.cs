using DeviceControlApp.Model;
using System.Threading.Tasks;

using DeviceControlApp.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            var homePageViewModel = new HomePageViewModel(dummyPageService);
            var canGoNext = homePageViewModel.NextCommand.CanExecute(null);
            homePageViewModel.NextCommand.Execute(null);

            Assert.AreEqual(true, canGoNext);
            Assert.AreEqual(typeof(ProductViewModel), dummyPageService.GetViewModelPageType());
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
