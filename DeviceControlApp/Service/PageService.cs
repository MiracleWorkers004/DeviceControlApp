using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DeviceControlApp.Service
{
    public class PageService:IPageService
    {
        public async Task GoNext(Type pagename)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(((Page)Activator.CreateInstance(pagename)));
        }

        public async Task PopModalAsync(Page page)
        {
            await Application.Current.MainPage.Navigation.PopAsync();

        }

        public async Task PushModalAsync(Page page)
        {

            await Application.Current.MainPage.Navigation.PushAsync(page);
        }

        public  void PushNextPage(INavigation navigation,Type pagename)
        {
            navigation.PushModalAsync( ((Page)Activator.CreateInstance(pagename)));
        }
    }
}
