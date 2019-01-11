using System;
using System.Windows.Input;

using DeviceControlApp.View;
using Xamarin.Forms;

namespace DeviceControlApp.ViewModel
{
    public class HomePageViewModel
    {
        public ICommand NextCommand { get; private set; }
      
        private IPageService _pageService;
        public HomePageViewModel(IPageService pageService)
        {
          
            _pageService = pageService;
            NextCommand = new Command(OnNextCommand);
        }

        public void OnNextCommand()
        {
            var viewModel = new ProductViewModel(_pageService);

            _pageService.GoNext(viewModel);
        }
    }
}
