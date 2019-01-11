using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DeviceControlApp.Service;
using Xamarin.Forms;

namespace DeviceControlApp.ViewModel
{
    public class BaseViewModel:INotifyPropertyChanged
    {
        public INavigation _navigation;
        public IPageService _pageService;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
