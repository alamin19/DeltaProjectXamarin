using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace DeltaOpenWeather.Persistence
{
    public class WeatherAppDatabase
    {
        readonly SQLiteAsyncConnection database;

        public WeatherAppDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<WeatherTable>().Wait();
        }

        public Task<List<WeatherTable>> GetItemsAsync()
        {
            return database.Table<WeatherTable>().ToListAsync();
        }

       
        public Task<WeatherTable> GetItemAsync(int id)
        {
            return database.Table<WeatherTable>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(WeatherTable item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(WeatherTable item)
        {
            return database.DeleteAsync(item);
        }
    }
}
