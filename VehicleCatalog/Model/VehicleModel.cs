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
    }
}
