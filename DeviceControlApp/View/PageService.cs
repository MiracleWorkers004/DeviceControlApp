using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DeviceControlApp.ViewModel;
using Xamarin.Forms;

namespace DeviceControlApp.View
{
    public class PageService:IPageService
    {
        public PageService()
        {
            MapViewToViewModel();
        }
        private Dictionary<Type, Type> _map = new Dictionary<Type, Type>();
        public async Task GoNext(Type viewModelType)
        {
            if(_map.ContainsKey(viewModelType))
            {
                var viewtype = _map[viewModelType];

                await  Application.Current.MainPage.Navigation.PushModalAsync(((Page)Activator.CreateInstance(viewtype)));
            

        }
            else
            {
                throw new Exception("Navigating to unmapped type");
            }
          
        }
        private void MapViewToViewModel()
        {
            _map.Add(typeof(HomePageViewModel), typeof(HomePage));
            _map.Add(typeof(ProductViewModel), typeof(ProductPage));

        }

        public async Task GoNext(object viewModel)
        {
            var viewmodeltype = viewModel.GetType();

            if (_map.ContainsKey(viewmodeltype))
            {
                var viewtype = _map[viewmodeltype];
                var page = (Page)Activator.CreateInstance(viewtype);
                page.BindingContext = viewModel;

                await Application.Current.MainPage.Navigation.PushModalAsync(page);

            }
            else
            {
                throw new Exception("Navigating to unmapped type");
            }


         

        }
    }
}
