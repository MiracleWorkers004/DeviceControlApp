using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DeviceControlApp.Service
{
    public interface IPageService
    {
        Task PushModalAsync(Page page);
        Task PopModalAsync(Page page);
    }
}
