using System;
using SQLite;
using DeltaOpenWeather.Persistence;
using System.IO;
using Xamarin.Forms;
using DeltaOpenWeather.Droid;


[assembly: Dependency(typeof(FileHelper))]
namespace DeltaOpenWeather.Droid
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}
