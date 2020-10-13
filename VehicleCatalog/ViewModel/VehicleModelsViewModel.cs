using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleCatalog.Model;

namespace VehicleCatalog.ViewModel
{
    class VehicleModelsViewModel
    {
        public List<VehicleModel> lVehicleModels = new List<VehicleModel>();
        public void GetMakerModels(List<VehicleModel> lVehicleModels)
        {
           this.lVehicleModels = lVehicleModels;
        }

        public List<VehicleModel> VehicleModels { get =>lVehicleModels; }

       
    }
}
