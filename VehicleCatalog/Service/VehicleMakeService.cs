using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using VehicleCatalog.Model;
using VehicleCatalog.ViewModel;

namespace VehicleCatalog.Service
{
    public class VehicleMakeService
    {
        ObservableCollection<VehicleMake> lVehicleMake;

        public VehicleMakeService(ObservableCollection<VehicleMake> lVehiceMake)
        {
            this.lVehicleMake = lVehiceMake;
        }



        public void CreateVehicleMake(string Name, string Abrv)
        {
            int id = lVehicleMake.Count + 1;
            VehicleMake vehicleMake = new VehicleMake(id, Name, Abrv);
            lVehicleMake.Add(vehicleMake);
        
        }

        public ObservableCollection<VehicleMake> ReadVehicleMake()
        {
            return lVehicleMake;
        }

        public VehicleMake UpdateVehicleMake(string name, string abrv, VehicleMake vehicleMake)
        {
            vehicleMake.name = name;
            vehicleMake.abrv = abrv;

            return vehicleMake;
        }

        public void DeleteVehicleMake(VehicleMake vehicleMake)
        {
            foreach(VehicleMake vm in lVehicleMake)
            {
                if(vehicleMake.id == vm.id)
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
