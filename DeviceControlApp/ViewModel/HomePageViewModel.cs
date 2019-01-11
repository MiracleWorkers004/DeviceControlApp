using System;
using System.Windows.Input;
using DeviceControlApp.Service;
using DeviceControlApp.View;
using Xamarin.Forms;

namespace DeviceControlApp.ViewModel
{
    public class HomePageViewModel
    {
        public ICommand NextCommand { get; private set; }
      //  private INavigation _navigation;
        private IPageService _pageService;
        public HomePageViewModel(IPageService pageService)
        {
            //_navigation = navigation;
            //  _pageService = new PageService();
            _pageService = pageService;
            NextCommand = new Command(OnNextCommand);
        }

        public void OnNextCommand()
        {
            // _navigation.PushModalAsync(new ProductPage());
            //  _pageService.PushNextPage(_navigation, typeof(ProductPage));
            //   App.pageService.GoNext(typeof(ProductPage));
            _pageService.GoNext(typeof(ProductViewModel));
        }
    }
}
