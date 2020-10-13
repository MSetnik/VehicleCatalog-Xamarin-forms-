using Plugin.Toast;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        ObservableCollection<VehicleMake> lVehicleMakes = new ObservableCollection<VehicleMake>();
        ListView listViewVehicleMake;
        public MainPage()
        {
           
            InitializeComponent();
            BindingContext = mainViewModel;
            lVehicleMakes = mainViewModel.VehicleMakes;
            /*listViewVehicleMake = vehicleMakeList;
            listViewVehicleMake.ItemsSource = lVehicleMakes;*/

        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedItem = e.Item as VehicleMake;
            
            //CrossToastPopUp.Current.ShowToastMessage(selectedItem.id.ToString());
            await Navigation.PushAsync(new VehicleModels(mainViewModel.GetSelectedMakerId(selectedItem.id)));
        }

        private async void AddNewVehicleMaker(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddVehicleMake(lVehicleMakes));
            CrossToastPopUp.Current.ShowToastMessage(mainViewModel.vehicleMakeService.ReadVehicleMake().Count.ToString());

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //listViewVehicleMake.ItemsSource = lVehicleMakes;
            CrossToastPopUp.Current.ShowToastMessage(lVehicleMakes.Count.ToString());
        }
    }
}
