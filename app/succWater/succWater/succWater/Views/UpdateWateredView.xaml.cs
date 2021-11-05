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
     public partial class UpdateWateredView : ContentPage
     {
          private Plant myPlant;
          public UpdateWateredView(ref Plant inPlant)
          {
               myPlant = inPlant;
               InitializeComponent();
          }
          public async void UpdateLastDateWatered(object sender, EventArgs e)
          {
               var temp = lWaterDate.Date;
               myPlant.lastWatered = temp;
               var detailControl = new PlantDetailViewModel();
               detailControl.connectDataBase();
               detailControl.savePlant(myPlant);
          }
     }
}