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
            VehicleModelsViewModel vehicleModels_ViewModel = new VehicleModelsViewModel(lVehicleModels);
            BindingContext = vehicleModels_ViewModel;
        }
    }
}