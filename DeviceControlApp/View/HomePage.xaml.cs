using System;
using System.Collections.Generic;
using DeviceControlApp.ViewModel;
using Xamarin.Forms;

namespace DeviceControlApp.View
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomePageViewModel(new PageService());
        }
    }
}
