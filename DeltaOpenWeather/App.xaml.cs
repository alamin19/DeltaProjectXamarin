using DeltaOpenWeather.Persistence;
using DeltaOpenWeather.View;
using Xamarin.Forms;

namespace DeltaOpenWeather
{
    public partial class App : Application
    {
        static WeatherAppDatabase database;

        public App()
        {
            InitializeComponent();

          //  MainPage = new DeltaOpenWeatherPage();

            MainPage = new NavigationPage(new HomePage());
        }

        public static WeatherAppDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new WeatherAppDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("WeatherSQLite.db3"));
                }
                return database;
            }
        }

        public int ResumeAtWeatherId { get; set; }




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
