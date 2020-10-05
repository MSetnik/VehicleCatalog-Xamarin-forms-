using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using VehicleCatalog.Model;

namespace VehicleCatalog.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;

        public List<VehicleMake> VehicleMakes { get => InitVehicleModelData(); }

        private List<VehicleMake> InitVehicleModelData()
        {
            List<VehicleMake> lVehicleMake = new List<VehicleMake>();

            VehicleMake vm = new VehicleMake(1, "Audi", "Audi");
            VehicleMake vm1 = new VehicleMake(2, "BMW", "BMW");
            VehicleMake vm2 = new VehicleMake(3, "Volkswagen", "VW");
            VehicleMake vm3 = new VehicleMake(4, "Opel", "Opel");
            VehicleMake vm4 = new VehicleMake(5, "Ford", "Ford");
            VehicleMake vm5 = new VehicleMake(6, "Mercedes-benz", "Mercedes-benz");
            VehicleMake vm6 = new VehicleMake(7, "Škoda", "Škoda");



            lVehicleMake.Add(vm);
            lVehicleMake.Add(vm1);
            lVehicleMake.Add(vm2);
            lVehicleMake.Add(vm3);
            lVehicleMake.Add(vm4);
            lVehicleMake.Add(vm5);
            lVehicleMake.Add(vm6);

            return lVehicleMake;
        }
    }
}
