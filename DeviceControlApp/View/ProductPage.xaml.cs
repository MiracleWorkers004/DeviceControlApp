using System;
using System.Collections.Generic;
using DeviceControlApp.ViewModel;
using Xamarin.Forms;

namespace DeviceControlApp.View
{
    public partial class ProductPage : ContentPage
    {
        public ProductPage()
        {
            InitializeComponent();
            BindingContext = new ProductViewModel(Navigation);
        }
    }
}
