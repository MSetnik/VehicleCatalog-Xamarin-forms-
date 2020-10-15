using System;
using System.Collections.Generic;
using System.Text;
using VehicleCatalog.Model;

namespace VehicleCatalog.Interface
{
    interface IUpdateVehicleMakeList
    {
        VehicleMake UpdateVehicleMakeList(VehicleMake vehicleMake);
    }
}
