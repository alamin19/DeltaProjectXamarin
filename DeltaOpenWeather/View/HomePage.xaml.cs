using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using DeltaOpenWeather.Model;
using Newtonsoft.Json;
using Plugin.Geolocator;
using Xamarin.Forms;

namespace DeltaOpenWeather.View
{
    public partial class HomePage : ContentPage
    {
        
        WeatherModal weather = new WeatherModal();

        public HomePage()
        {
            InitializeComponent();



        }

       


        void btnFavourite_Click(object sender, System.EventArgs e)
        {
          
        }

         async void btnGetWeather_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(entPinCode.Text))
            {
                weather = await GetWeather(entPinCode.Text);
                if (weather != null)
                {
                    await Navigation.PushAsync(new WeatherPage(weather));

                }else{
                    string message = "Unable to get  weather Details.";
                        await DisplayAlert("Location", message, "OK"); 
                }
            }
        }


        public async Task<WeatherModal> GetWeather(string pinCode)
        {
            string key = "20f27684bc3b5b55cfbb3acd27bb60ad";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?zip=" + pinCode + ",us&appid=" + key + "&units=imperial";

            //string queryString = "http://api.openweathermap.org/data/2.5/weather?zip=20903,us&appid=20f27684bc3b5b55cfbb3acd27bb60ad&units=imperial";

            dynamic results = await getDataFromService(queryString).ConfigureAwait(false);
            if (results["weather"] != null)
            {

                weather.Title = (string)results["name"];
                weather.Temperature = (string)results["main"]["temp"] + " F";
                DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);
                weather.Sunrise = sunrise.ToString() + " UTC";
                weather.Sunset = sunset.ToString() + " UTC";
                weather.Wind = (string)results["wind"]["speed"] + " mph";
                weather.Humidity = (string)results["main"]["humidity"] + " %";
                weather.latitude = (double)results["coord"]["lat"];
                weather.longitute = (double)results["coord"]["lon"];

                return weather;
            }
            else
            {
                return null;
            }
        }
        public static async Task<dynamic> getDataFromService(string pQueryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(pQueryString);
            dynamic data = null;
            if (response != null)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject(json);
            }
            return data;
        }
    


    }
}
