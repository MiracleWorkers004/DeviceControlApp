using System.Threading;
using System.Threading.Tasks;
using DeviceControlApp.Services;

namespace DemoUnitTest
{
    internal class DummyLocationService:ILocationService
    {
        public DummyLocationService()
        {
        }

        public async Task<MyPosition> GetLocation()
        {


            await Task.Delay(100);
            return new MyPosition() 
            {
                Latitude = "1.0",
                Longitude = "2.0"

            };
        }
    }
}