using System;
using System.Collections.Generic;
using DeviceControlApp.ViewModel;
using Plugin.Geolocator;
using Xamarin.Forms;

namespace DeviceControlApp.View
{
    public partial class ProductPage : ContentPage
    {
        public ProductPage()
        {
            InitializeComponent();
          //  BindingContext = new ProductViewModel();
        }

        async  void GetLocationClicked(object sender, System.EventArgs e)
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;
            var position = await locator.GetPositionAsync();
            Latitude.Text = position.Latitude.ToString();
            Longitude.Text = position.Longitude.ToString();
        }
    }

    
}
