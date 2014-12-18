using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using System.Diagnostics;
namespace BLSTREAM_PATRONAGE
{
    
    public sealed partial class AddPlacePage : Page
    {
        Place Filler= new Place();

        public AddPlacePage()
        {
         
           
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
            LayoutRoot.DataContext = Filler;
         
        }
                  
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
      
           
        }

        private async void Location_Click(object sender, RoutedEventArgs e)
        {
            
           
            Geolocator geolocator = new Geolocator();
            geolocator.DesiredAccuracyInMeters = 50;

                Geoposition geoposition = await geolocator.GetGeopositionAsync(
                    maximumAge: TimeSpan.FromMinutes(5),
                    timeout: TimeSpan.FromSeconds(10)
                    );

                Lattitude.Text = geoposition.Coordinate.Latitude.ToString("0.00");
                Longitude.Text = geoposition.Coordinate.Longitude.ToString("0.00");
            
      
        }
    }
}
