using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using succWater.Model;
using succWater.Data;

using succWater.Data;
namespace succWater.ViewModels
{
     public class PlantDetailViewModel : INotifyPropertyChanged
     {

          SuccWaterDatabase database;
          public PlantDetailViewModel()
          {

          }
          public async void connectDataBase()
          {
               database = await SuccWaterDatabase.Instance;
          }
          public async void savePlant(Plant newPlant)
          {
                
               await database.SaveItemAsync(newPlant);
               OnPropertyChanged("plants");

          }
          protected void OnPropertyChanged(string propertyName)
          {
               var handler = PropertyChanged;
               if (handler != null)
                    handler(this, new PropertyChangedEventArgs(propertyName));
          }
          public event PropertyChangedEventHandler PropertyChanged;
     }
}
