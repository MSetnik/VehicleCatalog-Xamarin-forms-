using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using VehicleCatalog.Model;
using VehicleCatalog.Service;

namespace VehicleCatalog.ViewModel
{
    public class AddVehicleMakerVievModel
    {
        private VehicleMakeService vehicleMakeService;

        public AddVehicleMakerVievModel(ObservableCollection<VehicleMake> vehicleMakes)
        {
            vehicleMakeService = new VehicleMakeService();
            vehicleMakeService.SetVehicleMakeList(vehicleMakes);
        }

        public void CreateVehicleMake(int id, string name, string abrv)
        {
            vehicleMakeService.CreateVehicleMake(id, name, abrv);
        }
    }
}
