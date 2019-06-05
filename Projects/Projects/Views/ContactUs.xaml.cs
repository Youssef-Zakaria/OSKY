using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Essentials;

namespace Projects.Views
{
    public partial class ContactUs : ContentPage
    {
        public ContactUs()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            initMap();
            base.OnAppearing();
        }


        async void initMap() {
            var loc = await Geolocation.GetLastKnownLocationAsync();
            LocationMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(loc.Latitude,loc.Longitude),Distance.FromKilometers(1)));

        }
    }
}
