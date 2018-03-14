using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Newtonsoft.Json;  
using System.Net.Http;
using DeltaOpenWeather.Model;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;
using DeltaOpenWeather.Persistence;

namespace DeltaOpenWeather.View
{
    public partial class WeatherPage : ContentPage
    {
        double longitute;
        double latitude;
       
        public WeatherPage (WeatherModal weather)
        {
            InitializeComponent();

            if (weather != null)
            {
               

                txtLocation.Text = weather.Title;
                txtTemperature.Text = weather.Temperature;
                txtWind.Text = weather.Wind;
                txtHumidity.Text = weather.Humidity;
                txtSunrise.Text = weather.Sunrise;
                txtSunset.Text = weather.Sunset;
                longitute = weather.longitute;
                latitude = weather.latitude;

                var position = new Position(latitude, longitute); // Latitude, Longitude

                MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(position.Latitude, 
                                                                            position.Longitude),
                                                               Distance.FromMiles(1)));

              

                var pin = new Pin
                {
                    Type = PinType.Place,
                    Position = position,
                    Label = "custom pin",
                    Address = "custom detail info"
                };

               
                MyMap.Pins.Add(pin);

            }
        }


        async  void btnAddFavourite_Click(object sender, System.EventArgs e)
        {
            try
            {
                WeatherTable weatherItem = new WeatherTable
                {
                    Title = txtLocation.Text,
                    Temperature = txtTemperature.Text,
                    Wind = txtWind.Text,
                    Humidity = txtHumidity.Text,
                    Sunrise = txtSunrise.Text,
                    Sunset = txtSunset.Text,
                    Visibility = "",
                    Longitute = longitute,
                    Latitude = latitude
                };

               


                int id = await App.Database.SaveItemAsync(weatherItem);

                if (id > 0)
                {
                    await DisplayAlert("Alert", "Favourite Added", "Ok");
                }
            }
            catch (Exception ex)
            {
                await  DisplayAlert("Error",ex.Message,"Ok");
            }


        }



    }
}
