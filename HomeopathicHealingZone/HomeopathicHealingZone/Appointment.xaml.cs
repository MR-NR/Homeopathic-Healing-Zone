using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HomeopathicHealingZone
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Appointment : Page
    {
        public Appointment()
        {
            this.InitializeComponent();
            Map.Center =
              new Geopoint(new BasicGeoposition()
              {
                  Latitude = 31.4755386,
                  Longitude = 74.3399867
              });
            Map.ZoomLevel = 12;
            Map.LandmarksVisible = true;
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DoctorsPage));
        }
    }
}
