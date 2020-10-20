using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using VehicleCatalog.Model;
using VehicleCatalog.Service;

namespace VehicleCatalog.ViewModel
{
    public class AddVehicleModelViewModel
    {
        private VehicleModelService vehicleModelService;

        public AddVehicleModelViewModel(ObservableCollection<VehicleModel> vehicleModel)
        {
            vehicleModelService = new VehicleModelService();
            vehicleModelService.SetVehicleModelList(vehicleModel);
        }

        public void CreateVehicleModel(int id,int makeId, string name, string abrv)
        {
            vehicleModelService.CreateVehicleModel(id, makeId, name, abrv);
        }
    }
}
