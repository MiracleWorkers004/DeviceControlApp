using System;
using System.Windows.Input;
using DeviceControlApp.Services;
using DeviceControlApp.View;
using Xamarin.Forms;

namespace DeviceControlApp.ViewModel
{
    public class HomePageViewModel
    {
        public ICommand NextCommand { get; private set; }  //GoToNextCommand
      
        private IPageService _pageService;

        private ILocationService _locationService;

        public HomePageViewModel(IPageService pageService,ILocationService locationService)
        {
            _pageService = pageService;
            _locationService = locationService;
            NextCommand = new Command(OnNextCommand);
        }

        public async void OnNextCommand()
        {
            var viewModel = new ProductViewModel(_pageService,_locationService);

            await _pageService.GoNext(viewModel);
        }
    }
}
