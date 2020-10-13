using Plugin.Toast;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleCatalog.Model;
using VehicleCatalog.Service;
using VehicleCatalog.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VehicleCatalog.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddVehicleMake : ContentPage
    {
        ObservableCollection<VehicleMake> TempVehicleMake = new ObservableCollection<VehicleMake>();
        VehicleMakeService vehicleMakeService;
        public AddVehicleMake(ObservableCollection<VehicleMake> vehicleMakes)
        {
            InitializeComponent();
            TempVehicleMake = vehicleMakes;
            vehicleMakeService = new VehicleMakeService(TempVehicleMake);
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            var Name = vehicleName.Text;
            var Abrv = vehicleAbrv.Text;

            vehicleMakeService.CreateVehicleMake(Name, Abrv);
            CrossToastPopUp.Current.ShowToastMessage("Saved");
        }
    }
}