using System;
using SQLite;

namespace DeltaOpenWeather.Persistence
{
    public class WeatherTable
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(255)]
        public string Title { get; set; }


        public double Longitute { get; set; }
        public double Latitude { get; set; }

        [MaxLength(200)]  
        public string Temperature { get; set; }

        [MaxLength(255)]
        public string Wind { get; set; }

        [MaxLength(255)]
        public string Humidity { get; set; }

        [MaxLength(255)]
        public string Visibility { get; set; }

        [MaxLength(255)]
        public string Sunrise { get; set; }

        [MaxLength(255)]
        public string Sunset { get; set; }


    }
}
