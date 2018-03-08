using System;
using System.Collections.Generic;
using System.Diagnostics;
using Plugin.Geolocator;
using Xamarin.Forms;

namespace DeltaOpenWeather.View
{
    public partial class HomePage : ContentPage
    {
       

        public HomePage()
        {
            InitializeComponent();



        }

        async private void ContentPage_Appearing(object sender, EventArgs e)
        {
            var locator = CrossGeolocator.Current;


            //var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10));

            //Debug.WriteLine("Position Status: {0}", position.Timestamp);
            //Debug.WriteLine("Position Latitude: {0}", position.Latitude);
            //Debug.WriteLine("Position Longitude: {0}", position.Longitude);

            //string location = position.Timestamp.ToString();

            await DisplayAlert("Location", "test", "OK");

        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
           await  Navigation.PushAsync(new WeatherPage());
        }

    }
}
