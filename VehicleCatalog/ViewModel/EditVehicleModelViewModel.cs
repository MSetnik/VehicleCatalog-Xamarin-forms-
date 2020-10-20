using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using VehicleCatalog.Model;
using VehicleCatalog.Service;

namespace VehicleCatalog.ViewModel
{
    public class EditVehicleModelViewModel
    {
        private VehicleModel vehicleModel;
        private VehicleModelService vehicleModelService;
        public EditVehicleModelViewModel(VehicleModel vm, ObservableCollection<VehicleModel> lVehicleModel)
        {
            vehicleModel = vm;
            vehicleModelService = new VehicleModelService();
            vehicleModelService.SetVehicleModelList(lVehicleModel);
        }

        public VehicleModel VehicleModel { get => vehicleModel; }

        public void EditVehicleMake(int id,string name, VehicleModel vm)
        {
            vehicleModelService.UpdateVehicleModel(id, name, vm);
        }
    }
}
