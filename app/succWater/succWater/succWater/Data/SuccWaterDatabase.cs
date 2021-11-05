using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using succWater.Model;

namespace succWater.Data
{
     public class SuccWaterDatabase
     {
          static SQLiteAsyncConnection Database;


          public static readonly AsyncLazy<SuccWaterDatabase> Instance = new AsyncLazy<SuccWaterDatabase>(async () =>
          {
               var instance = new SuccWaterDatabase();
               CreateTableResult result = await Database.CreateTableAsync<Plant>();
               CreateTableResult wResult = await Database.CreateTableAsync<WaterEvent>();
               return instance;
          });

          public SuccWaterDatabase()
          {
               Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
          }
          public Task<List<Plant>> GetItemsAsync()
          {
               return Database.Table<Plant>().ToListAsync();
          }
          public Task<int> SaveItemAsync(Plant item)
          {
               if (item.ID != 0)
               {
                    return Database.UpdateAsync(item);
               }
               else
               {
                    return Database.InsertAsync(item);
               }
          }

     }
}
