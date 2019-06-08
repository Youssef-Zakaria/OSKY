using Projects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Projects.Services
{
    public class LocationService : ILocationService
    {
        public Task<Location> getCurrentLocationAsync()
        {
            return Geolocation.GetLastKnownLocationAsync();
        }

        async public Task<Placemark> getCurrentPlaceAsync()
        {
            var loc = await Geolocation.GetLastKnownLocationAsync();
            var places = await Geocoding.GetPlacemarksAsync(loc);
            return places.FirstOrDefault();
        }
    }
}
