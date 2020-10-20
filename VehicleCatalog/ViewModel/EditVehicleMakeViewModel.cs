using System.Collections.ObjectModel;
using VehicleCatalog.Model;
using VehicleCatalog.Service;

namespace VehicleCatalog.View
{
    public class EditVehicleMakeViewModel
    {
        private VehicleMake vehicleMake;
        private VehicleMakeService vehicleMakeService;
        public EditVehicleMakeViewModel(VehicleMake vm, ObservableCollection<VehicleMake> lVehicleMake)
        {
            vehicleMake = vm;
            vehicleMakeService = new VehicleMakeService();
            vehicleMakeService.SetVehicleMakeList(lVehicleMake);
        }

        public VehicleMake VehicleMake { get => vehicleMake; }

        public void EditVehicleMake(int id, string name, string abrv, VehicleMake vm)
        {
            vehicleMakeService.UpdateVehicleMake(id, name, abrv, vm);
        }

    }
}