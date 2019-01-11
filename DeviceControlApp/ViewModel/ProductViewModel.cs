using System;
using System.Windows.Input;
using DeviceControlApp.Model;
using DeviceControlApp.Service;
using DeviceControlApp.View;
using Xamarin.Forms;

namespace DeviceControlApp.ViewModel
{
    public class ProductViewModel:BaseViewModel
    {
        public ICommand MessageCommand { get; private set; }

        public ICommand BackCommand { get; private set; }
        public DemoDate _data;


       
        public string Message
        {
            get => _data.Message;
            set
            {
                _data.Message = value;
                NotifyPropertyChanged("Message");
            }
        }
        public bool Flag
        {
            get => _data.flag;
            set
            {
                _data.flag = value;
                NotifyPropertyChanged("Flag");
            }
        }
        public ProductViewModel(IPageService pageService)
        {

            _pageService = pageService;
            _data = new DemoDate();
            Message = "Turned on";
            Flag = true;
            MessageCommand = new Command(OnMessageChangeCommand);
            BackCommand = new Command(OnBackCommand);
        }

        private void OnMessageChangeCommand(object obj)
        {
            if (Flag)
            {
                Message = "Turned off";
                Flag = false;
            }
            else
            {
                Message = "Turned on";
                Flag = true;
            }

        }

        public void OnBackCommand()
        {
         
            _pageService.GoNext(typeof(HomePageViewModel));
        }

       
    }
}
