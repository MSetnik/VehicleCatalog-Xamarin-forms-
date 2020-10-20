using Plugin.Toast;
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
    public partial class AddVehicleModel : ContentPage
    {
        ObservableCollection<VehicleModel> lVehicleModels = new ObservableCollection<VehicleModel>();
        AddVehicleModelViewModel addVehicleModelVM;

        int id;
        VehicleMake vehicleMake;
        public AddVehicleModel(ObservableCollection<VehicleModel> vehicleModels,int id, VehicleMake vm)
        {
            InitializeComponent();
            lVehicleModels = vehicleModels;
            addVehicleModelVM = new AddVehicleModelViewModel(lVehicleModels);
            this.id = id;
            this.vehicleMake = vm;
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            var name = vehicleModelName.Text;

            if (!String.IsNullOrEmpty(name))
            {
                addVehicleModelVM.CreateVehicleModel(id,vehicleMake.id, name, vehicleMake.abrv);
                App.Current.MainPage.Navigation.PopAsync();
                CrossToastPopUp.Current.ShowToastMessage("Saved");
            }
            else
            {
                CrossToastPopUp.Current.ShowToastMessage("Fields cannot be empty.");
            }
        }
    }
}