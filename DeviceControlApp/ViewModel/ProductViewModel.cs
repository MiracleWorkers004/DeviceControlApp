using System;
using System.Threading.Tasks;
using System.Windows.Input;
using DeviceControlApp.Model;
using DeviceControlApp.Services;
using DeviceControlApp.View;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using Xamarin.Forms;

namespace DeviceControlApp.ViewModel
{
    public class ProductViewModel:BaseViewModel
    {
       
        public ICommand BackCommand { get; private set; }

        public ICommand DisplayLocationCommand { get; private set; }


        public IPageService _pageService;

        public ILocationService _locationService;




        private string _latitude;
        public string Latitude
        {

            get => _latitude;
            set
            {

                _latitude = value;
                NotifyPropertyChanged("Latitude");
            }

        }
        private string _longitude;
        public string Longitude
        {

            get => _longitude;
            set
            {

                _longitude = value;
                NotifyPropertyChanged("Longitude");
            }

        }
        public ProductViewModel(IPageService pageService,ILocationService locationService)
        {

            _pageService = pageService;
            _locationService = locationService;
          
   

            BackCommand = new Command(OnBackCommand);
            DisplayLocationCommand = new Command(() => { GetLocationSync(); });
        }

        private async Task<int> GetLocation()
        {

            var myLocation = await _locationService.GetLocation();
            Latitude = myLocation.Latitude;
            Longitude = myLocation.Longitude;
            return 1;
        }

        private void GetLocationSync()
        {
            GetLocation().Wait();
        }



        public void OnBackCommand()
        {

            var viewModel = new HomePageViewModel(_pageService,_locationService);
            _pageService.GoNext(viewModel);
        }

       
    }
}
