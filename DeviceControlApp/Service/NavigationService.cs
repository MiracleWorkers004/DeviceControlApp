using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DeviceControlApp.Service
{
    public class NavigationService
    {
        private Dictionary<string, Type> pages { get; } = new Dictionary<string, Type>();
        public Page MainPage => Application.Current.MainPage;
        public void Configure(string key, Type pageType) => pages[key] = pageType;

        public void GoBack() => MainPage.Navigation.PopAsync();

        public void NavigateTo(string pageKey, object parameter = null)
        {
            Type pageType;
            if (pages.TryGetValue(pageKey, out pageType))
            {
             
            }
            }

     
    }
}
