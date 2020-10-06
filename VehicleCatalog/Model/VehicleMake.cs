using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleCatalog.Model
{
    public class VehicleMake
    {
        public int id { get; set; }
        public string name { get; set; }
        public string abrv { get; set; }
        public List<VehicleModel> lVehicleModel { get; set; }


        public VehicleMake (int id, string name, string abrv, List<VehicleModel>vehicleModels)
        {
            this.id = id;
            this.name = name;
            this.abrv = abrv;
            this.lVehicleModel = vehicleModels;
        }

       

        private List<VehicleMake> InitVehicleMakeData()
        {
            List<VehicleMake> lVehicleMake = new List<VehicleMake>();

            VehicleMake vm = new VehicleMake(1, "Audi", "Audi", GetMakerModels(1));
            VehicleMake vm1 = new VehicleMake(2, "BMW", "BMW", GetMakerModels(2));
            VehicleMake vm2 = new VehicleMake(3, "Volkswagen", "VW", GetMakerModels(3));
            VehicleMake vm3 = new VehicleMake(4, "Opel", "Opel", GetMakerModels(4));
            VehicleMake vm4 = new VehicleMake(5, "Ford", "Ford", GetMakerModels(5));
            VehicleMake vm5 = new VehicleMake(6, "Mercedes-benz", "Mercedes-benz", GetMakerModels(6));
            VehicleMake vm6 = new VehicleMake(7, "Škoda", "Škoda", GetMakerModels(7));


            lVehicleMake.Add(vm);
            lVehicleMake.Add(vm1);
            lVehicleMake.Add(vm2);
            lVehicleMake.Add(vm3);
            lVehicleMake.Add(vm4);
            lVehicleMake.Add(vm5);
            lVehicleMake.Add(vm6);

            return lVehicleMake;
        }

        private List<VehicleModel>GetMakerModels(int makerId)
        {
            List<VehicleModel>lMakerModels = (List<VehicleModel>)lVehicleModel.Where(vm => vm.makeId == makerId);
            return lMakerModels;
        }
    }

}
