using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleCatalog.Model;

namespace VehicleCatalog.ViewModel
{
    public class VehicleModelsViewModel
    {
        public List<VehicleModel> lVehicleModels = new List<VehicleModel>();

        public VehicleModelsViewModel(List<VehicleModel> vehicleModels)
        {
            this.lVehicleModels = vehicleModels;
        }


        public List<VehicleModel> VehicleModels { get =>lVehicleModels; }

       
    }
}
