using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;


namespace Projects.Interfaces
{
    public interface ILocationService
    {
        Task<Location> getCurrentLocationAsync();
        Task<Placemark> getCurrentPlaceAsync();
    }
}
