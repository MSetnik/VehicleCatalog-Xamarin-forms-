using Plugin.Toast;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleCatalog.Model;
using VehicleCatalog.View;
using VehicleCatalog.ViewModel;
using Xamarin.Forms;

namespace VehicleCatalog
{
    public partial class MainPage : ContentPage
    { 
        MainViewModel mainViewModel = new MainViewModel();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = mainViewModel;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedItem = e.Item as VehicleMake;
            
            CrossToastPopUp.Current.ShowToastMessage(selectedItem.id.ToString());

           // List<VehicleModel> list = mainViewModel.GetSelectedMakerId(selectedItem.id).ToList();

            Navigation.PushAsync(new VehicleModels(mainViewModel.GetSelectedMakerId(selectedItem.id)));
        }
    }
}
