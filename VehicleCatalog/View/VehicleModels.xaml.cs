using System;
using System.Collections.Generic;
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
        public VehicleModels(List<VehicleModel> lVehicleModels)
        {
            InitializeComponent();
            VehicleModels_ViewModel vehicleModels_ViewModel = new VehicleModels_ViewModel();
            vehicleModels_ViewModel.GetMakerModels(lVehicleModels);
            BindingContext = vehicleModels_ViewModel;
        }
    }
}