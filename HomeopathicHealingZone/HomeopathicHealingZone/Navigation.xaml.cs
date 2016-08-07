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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HomeopathicHealingZone
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Navigation : Page
    {
        public Navigation()
        {

            this.InitializeComponent();
            Backbutton.Visibility = Visibility.Collapsed;
            MyFrame.Navigate(typeof(Home));
            TittleTextBlock.Text = "Home";
            HomeBox.IsSelected = true;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void Backbutton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
                HomeBox.IsSelected = true;
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HomeBox.IsSelected)
            {
                Backbutton.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(Home));
                TittleTextBlock.Text = "Home";
            }
            if (DiagnoseBox.IsSelected)
            {
                Backbutton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Diagnose));
                TittleTextBlock.Text = "Diagnose";
            }

            if (AppointmentBox.IsSelected)
            {
                Backbutton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Appointment));
                TittleTextBlock.Text = "Appointment";
            }

            if (ProfileBox.IsSelected)
            {
                Backbutton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Profile));
                TittleTextBlock.Text = "Profile";
            }
        }
    }
}
