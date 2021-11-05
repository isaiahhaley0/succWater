using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using succWater.Model;
using succWater.Data;

using System.Collections.ObjectModel;


namespace succWater.ViewModels
{
     public class PlantListViewModel : INotifyPropertyChanged
     {

          public ObservableCollection<Plant> plants;
          
          SuccWaterDatabase database;
          public PlantListViewModel()
          {

               plants = new ObservableCollection<Plant>();
          }

          public async void buildPlantList()
          {
               database = await SuccWaterDatabase.Instance;
               var plants1 = await database.GetItemsAsync();

               for(int i = 0; i < plants1.Count; i++)
               {
                    plants.Add(plants1[i]);
               }
          }
                

          public async void addPlant(Plant newPlant)
          {
               plants.Add(newPlant);
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
