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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MultipleDevices
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MultipleDevices_Mobile : Page
    {
        public MultipleDevices_Mobile()
        {
            this.InitializeComponent();
            TextBlock1.Text = String.Format("Hello {0}!",
                                            Windows.System.Profile.AnalyticsInfo.VersionInfo.DeviceFamily);
        }
        private void ClickMe(object sender, RoutedEventArgs e)
        {
            TextBlock1.Text = "Hi There How are you???";
        }
    }
}
