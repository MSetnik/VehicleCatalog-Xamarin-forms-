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


        public VehicleMake(int id, string name, string abrv)
        {
            this.id = id;
            this.name = name;
            this.abrv = abrv;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }

}
