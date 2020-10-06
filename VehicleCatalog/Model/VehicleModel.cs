using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalog.Model
{
    public class VehicleModel
    {
        public int id { get; set; }
        public int makeId { get; set; }
        public string name { get; set; }
        public string abrv { get; set; }

        public VehicleModel(int id, int makeId, string name, string abrv)
        {
            this.id = id;
            this.makeId = makeId;
            this.name = name;
            this.abrv = abrv;
        }


        private List<VehicleModel> GetVehicleModels()
        {
            List<VehicleModel> lVehicleModel = new List<VehicleModel>();

            lVehicleModel.Add(new VehicleModel(1, 1, "128", "BMW"));
            lVehicleModel.Add(new VehicleModel(2, 1, "325", "BMW"));
            lVehicleModel.Add(new VehicleModel(3, 1, "X5", "BMW"));
            lVehicleModel.Add(new VehicleModel(4, 2, "A2", "Audi"));
            lVehicleModel.Add(new VehicleModel(5, 2, "A6", "Audi"));
            lVehicleModel.Add(new VehicleModel(6, 3, "Golf", "VW"));
            lVehicleModel.Add(new VehicleModel(7, 3, "Passat", "VW"));
            lVehicleModel.Add(new VehicleModel(8, 3, "Polo", "VW"));
            lVehicleModel.Add(new VehicleModel(9, 4, "Corsa", "Opel"));
            lVehicleModel.Add(new VehicleModel(10, 4, "Insignia", "Opel"));
            lVehicleModel.Add(new VehicleModel(11, 4, "Adam", "Opel"));
            lVehicleModel.Add(new VehicleModel(12, 5, "Ford", "Focus"));
            lVehicleModel.Add(new VehicleModel(13, 6, "A180", "Mercedes-benz"));
            lVehicleModel.Add(new VehicleModel(14, 6, "C220", "Mercedes-benz"));
            lVehicleModel.Add(new VehicleModel(15, 6, "E180", "Mercedes-benz"));
            lVehicleModel.Add(new VehicleModel(16, 7, "Superb", "Škoda"));
            lVehicleModel.Add(new VehicleModel(17, 7, "Octavia", "Škoda"));
            lVehicleModel.Add(new VehicleModel(18, 7, "Rapid", "Škoda"));
            lVehicleModel.Add(new VehicleModel(19, 7, "Fabia", "Škoda"));

            return lVehicleModel;
        }

    }
}
