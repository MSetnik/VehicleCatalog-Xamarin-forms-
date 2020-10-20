using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleCatalog.Model;
using VehicleCatalog.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VehicleCatalog.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VehicleModels : ContentPage
    {
        private ObservableCollection<VehicleModel> lVehicleModels;
        private VehicleMake vehicleMake;
        int id;
        int vehicleModelId;
        public VehicleModels(ObservableCollection<VehicleModel> lVehicleModels, VehicleMake vm, int vehicleModelId)
        {
            InitializeComponent();
            VehicleModelsViewModel vehicleModels_ViewModel = new VehicleModelsViewModel(lVehicleModels);
            BindingContext = vehicleModels_ViewModel;
            this.lVehicleModels = lVehicleModels;
            this.vehicleMake = vm;
            this.id = lVehicleModels.Count;
            this.vehicleModelId = vehicleModelId;
        }

        private void AddNewVehicleModel(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddVehicleModel(lVehicleModels, ++vehicleModelId, vehicleMake));
        }

        private void SwipeView_edit(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var editItem = item.BindingContext as VehicleModel;

            Navigation.PushAsync(new EditVehicleModel(editItem, lVehicleModels));
        }

        private void SwipeView_delete(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var deleteItem = item.BindingContext as VehicleModel;

            foreach (VehicleModel vm in lVehicleModels.ToList())
            {
                if (deleteItem.id == vm.id)
                {
                    lVehicleModels.Remove(vm);
                }

            }
        }
    }
}