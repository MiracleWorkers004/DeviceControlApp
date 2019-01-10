using System;
using System.Windows.Input;
using DeviceControlApp.View;
using Xamarin.Forms;

namespace DeviceControlApp.ViewModel
{
    public class HomePageViewModel
    {
        public ICommand NextCommand { get; private set; }
        private INavigation _navigation;
        public HomePageViewModel(INavigation navigation)
        {
            _navigation = navigation;
            NextCommand = new Command(OnNextCommand);
        }

        public void OnNextCommand()
        {
            _navigation.PushModalAsync(new ProductPage());
        }
    }
}
