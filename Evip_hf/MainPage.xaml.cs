﻿using System.Threading;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Evip_hf
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }

        private void toSplash_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(typeof(SplashScreen));
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(typeof(BlankPage2));
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(typeof(BlankPage3));
        }
    }
}
