using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using VehicleCatalog.Model;
using VehicleCatalog.Repository;
using VehicleCatalog.Service;
using VehicleCatalog.View;

namespace VehicleCatalog.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<VehicleMake> lVehicleMake = new ObservableCollection<VehicleMake>();
        public ObservableCollection<VehicleModel> lVehicleModel = new ObservableCollection<VehicleModel>();
        public VehicleMakeService vehicleMakeService;
        private Repo repository;

        public ObservableCollection<VehicleMake> VehicleMakes
        {
            get => lVehicleMake;
        }
        public MainViewModel()
        {
            repository = new Repo();
            lVehicleMake = new ObservableCollection<VehicleMake>(repository.InitVehicleMakeData());
            vehicleMakeService = new VehicleMakeService();
            vehicleMakeService.SetVehicleMakeList(lVehicleMake);
            lVehicleMake = new ObservableCollection<VehicleMake>(vehicleMakeService.ReadVehicleMake());
            lVehicleModel = new ObservableCollection<VehicleModel>(repository.InitVehicleModelData());
        }


        

        public List<VehicleModel> GetSelectedMakerId(int makerId)
        {
            List<VehicleModel> lVehicleMakerModels = new List<VehicleModel>();

            foreach (VehicleModel vm in lVehicleModel)
            {
                if (vm.makeId == makerId)
                {
                    lVehicleMakerModels.Add(vm);
                }
            }
            return lVehicleMakerModels;

        }
    }
}
