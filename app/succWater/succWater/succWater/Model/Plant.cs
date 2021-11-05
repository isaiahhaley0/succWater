using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SQLite;
namespace succWater.Model
{
     public class Plant : INotifyPropertyChanged
     {
          string myName;
          string mySpecies;
          DateTime lastFertilized;
          DateTime lastWatered;
          double needToWater;

          public Plant()
          {

          }
          [PrimaryKey, AutoIncrement]
          public int ID { get; set; }
          public string name
          {
               get
               {
                    return myName;
               }
               set
               {
                    myName = value;
                    OnPropertyChanged("name");
               }
          }

          public string species
          {
               get
               {
                    return mySpecies;
               }
               set
               {
                    mySpecies = value;
                    OnPropertyChanged("species");
               }
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
