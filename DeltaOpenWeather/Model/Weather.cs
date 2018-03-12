using System;
namespace DeltaOpenWeather.Model
{
    public class WeatherModal
    {
        public double longitute { get; set; }
        public double latitude { get; set; }



        public string Title {  
        get;  
        set;  
    }  
    public string Temperature {  
        get;  
        set;  
    }  
    public string Wind {  
        get;  
        set;  
    }  
    public string Humidity {  
        get;  
        set;  
    }  
    public string Visibility {  
        get;  
        set;  
    }  
    public string Sunrise {  
        get;  
        set;  
    }  
    public string Sunset {  
        get;  
        set;  
    }  
    public WeatherModal() {  
        this.Title = " ";  
        this.Temperature = " ";  
        this.Wind = " ";  
        this.Humidity = " ";  
        this.Visibility = " ";  
        this.Sunrise = " ";  
        this.Sunset = " ";  
    }  
    }
}
