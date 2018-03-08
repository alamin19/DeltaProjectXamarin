using DeltaOpenWeather.View;
using Xamarin.Forms;

namespace DeltaOpenWeather
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

          //  MainPage = new DeltaOpenWeatherPage();

            MainPage = new NavigationPage(new HomePage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
