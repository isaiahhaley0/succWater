using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using succWater.Model;
using succWater.ViewModels;

namespace succWater.Views
{
     [XamlCompilation(XamlCompilationOptions.Compile)]
     public partial class AddPlantView : ContentPage
     {
          PlantListViewModel myPlantList;
          public AddPlantView(ref PlantListViewModel plantList)
          {
               myPlantList = plantList;
               InitializeComponent();
          }

          public void AddPlant(Object sender, EventArgs e)
          {
               var newPlant = new Plant();
               var pName = plantName.Text;
               var pSpecies = plantSpecies.Text;
               newPlant.name = pName;
               myPlantList.addPlant(newPlant);
               Navigation.PopAsync();
          }

        
     }
}