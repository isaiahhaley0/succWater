using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using succWater.Model;
using succWater.Views;
using succWater.ViewModels;
namespace succWater
{
     public partial class MainPage : ContentPage
     {
          PlantListViewModel myPlantList;
          public MainPage()
          {
               InitializeComponent();
               myPlantList = new PlantListViewModel();
               BindingContext = myPlantList;
               pList.ItemsSource = myPlantList.plants;
                
          }

          public async void AddPlant(Object sender, EventArgs e)
          {
               var newPlant = new AddPlantView(ref myPlantList);
               await Navigation.PushAsync(newPlant);
          }
     }
}
