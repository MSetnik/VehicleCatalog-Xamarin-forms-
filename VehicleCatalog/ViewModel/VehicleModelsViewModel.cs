using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VehicleCatalog.Model;

namespace VehicleCatalog.ViewModel
{
    public class VehicleModelsViewModel
    {
        public ObservableCollection<VehicleModel> lVehicleModels = new ObservableCollection<VehicleModel>();

        public VehicleModelsViewModel(ObservableCollection<VehicleModel> vehicleModels)
        {
            this.lVehicleModels = vehicleModels;
        }


        public ObservableCollection<VehicleModel> VehicleModels { get =>lVehicleModels; }

       
    }
}
