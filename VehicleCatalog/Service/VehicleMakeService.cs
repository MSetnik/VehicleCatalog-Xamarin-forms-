using System.Collections.ObjectModel;
using System.Linq;
using VehicleCatalog.Model;

namespace VehicleCatalog.Service
{
    public class VehicleMakeService
    {
        private ObservableCollection<VehicleMake> lVehicleMake;
        public VehicleMakeService()
        {
        }

        public void SetVehicleMakeList(ObservableCollection<VehicleMake> lVehicleMake)
        {
            this.lVehicleMake = lVehicleMake;
        }


        public void CreateVehicleMake(int id, string Name, string Abrv)
        {
            VehicleMake vehicleMake = new VehicleMake(id, Name, Abrv);
            lVehicleMake.Add(vehicleMake);

        }

        public ObservableCollection<VehicleMake> ReadVehicleMake()
        {
            return lVehicleMake;
        }

        public void UpdateVehicleMake(int id, string name, string abrv, VehicleMake vehicleMake)
        {
            vehicleMake.name = name;
            vehicleMake.abrv = abrv;

            int itemIndex;
            foreach (VehicleMake vm in lVehicleMake.ToList())
            {
                if (vm.id == id)
                {   
                    /*
                     * Nije radilo pa sam morao raditi na pokušaj iznad
                     
                    vm.name = name;
                    vm.abrv = abrv;

                     */
                    itemIndex =lVehicleMake.IndexOf(vm);
                    lVehicleMake.Remove(vm);
                    lVehicleMake.Insert(itemIndex, new VehicleMake(id, name, abrv));
                }
            }
            lVehicleMake = new ObservableCollection<VehicleMake>(lVehicleMake);

        }

        public void DeleteVehicleMake(VehicleMake vehicleMake)
        {
            foreach (VehicleMake vm in lVehicleMake)
            {
                if (vehicleMake.id == vm.id)
                {
                    lVehicleMake.Remove(vm);
                }
            }
        }

        public ObservableCollection<VehicleMake> SortVehicleMakeByName()
        {
            lVehicleMake = new ObservableCollection<VehicleMake>(lVehicleMake.OrderByDescending(vm => vm.name).ToList());
            return lVehicleMake;
        }

        public ObservableCollection<VehicleMake> SortVehicleMakeById()
        {
            lVehicleMake = new ObservableCollection<VehicleMake>(lVehicleMake.OrderByDescending(vm => vm.id).ToList());
            return lVehicleMake;
        }
    }
}
