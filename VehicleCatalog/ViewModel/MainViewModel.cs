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
           VehicleMake vm = new VehicleMake()
        }
    }
}
