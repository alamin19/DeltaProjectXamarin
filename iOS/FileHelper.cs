
using System;
using SQLite;
using DeltaOpenWeather.Persistence;
using System.IO;
using Xamarin.Forms;
using DeltaOpenWeather.iOS;


[assembly: Dependency(typeof(FileHelper))]
namespace DeltaOpenWeather.iOS
                          
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, filename);
        }
    }
}
