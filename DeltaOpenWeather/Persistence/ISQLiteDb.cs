using System;
using SQLite;
namespace DeltaOpenWeather.Persistence
{
    

    public interface ISQLiteDb  
    {  
        SQLiteAsyncConnection GetConnection();  
    } 
}
