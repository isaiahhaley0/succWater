using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using succWater.Model;
using System.Collections.ObjectModel;


namespace succWater.ViewModels
{
     public class PlantListViewModel : INotifyPropertyChanged
     {

          public ObservableCollection<Plant> plants;
          public PlantListViewModel()
          {
               plants = new ObservableCollection<Plant>();
          }
          public async void addPlant(Plant newPlant)
          {
               plants.Add(newPlant);
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
