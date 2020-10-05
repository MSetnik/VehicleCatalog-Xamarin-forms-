using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalog.Model
{
    public class VehicleModel
    {
        private int id { get; set; }
        private string makeId { get; set; }
        private string name { get; set; }
        private string abrv { get; set; }

        VehicleModel(int id, string makeId, string name, string abrv)
        {
            this.id = id;
            this.makeId = makeId;
            this.name = name;
            this.abrv = abrv;
        }

    }
}
