using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using succWater.Model;

namespace succWater.Views
{
     [XamlCompilation(XamlCompilationOptions.Compile)]
     public partial class PlantDetailView : ContentPage
     {
          private Plant myPlant;
          public PlantDetailView(ref Plant inPlant)
          {
               myPlant = inPlant;
               BindingContext = myPlant;
               InitializeComponent();
          }

          public async void UpdateLastDateWatered(object sender, EventArgs e)
          {
               var uwv = new UpdateWateredView(ref myPlant);
               
               uwv.BindingContext = myPlant;
               await Navigation.PushAsync(uwv);
               
          }
     }
}