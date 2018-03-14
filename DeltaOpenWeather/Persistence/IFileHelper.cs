using System;
namespace DeltaOpenWeather.Persistence
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}
