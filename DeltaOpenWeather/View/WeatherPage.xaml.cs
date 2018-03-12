using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Newtonsoft.Json;  
using System.Net.Http;
using DeltaOpenWeather.Model;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

namespace DeltaOpenWeather.View
{
    public partial class WeatherPage : ContentPage
    {
      

        public WeatherPage(WeatherModal weather)
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


                var position = new Position(weather.latitude, weather.longitute); // Latitude, Longitude

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
        //async void btnMapWeather_Click(object sender, System.EventArgs e)
        //{
        //    if (weather.latitude > 0)
        //    {
        //        string position = "Lat -" + weather.latitude.ToString() + "Long" + weather.longitute.ToString();
        //        await DisplayAlert("Location", position, "OK");

        //    }


        //}


    }
}
