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
        int id;
        public MainPage()
        {

            InitializeComponent();
            BindingContext = mainViewModel;
            lVehicleMakes = mainViewModel.VehicleMakes;
            id = lVehicleMakes.Count;

        }
        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedItem = e.Item as VehicleMake;

            Navigation.PushAsync(new VehicleModels(mainViewModel.GetSelectedMakerId(selectedItem.id)));
        }

        private void AddNewVehicleMaker(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddVehicleMake(lVehicleMakes, ++id));

        }

        private void DeleteItem(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var deleteItem = item.BindingContext as VehicleMake;

            foreach (VehicleMake vm in lVehicleMakes.ToList())
            {
                if (deleteItem.id == vm.id)
                {
                    lVehicleMakes.Remove(vm);
                }

            }

        }

        private void EditItem(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var editItem = item.BindingContext as VehicleMake;

            Navigation.PushAsync(new EditVehicleMake(editItem, lVehicleMakes));
        }
    }
}
