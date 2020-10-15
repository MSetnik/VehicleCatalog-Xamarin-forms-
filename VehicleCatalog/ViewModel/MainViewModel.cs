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
        public ObservableCollection<VehicleMake> oVehicleMakes;
        public VehicleMakeService vehicleMakeService;
        private Repo repository;

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<VehicleMake> VehicleMakes
        {
            get { return lVehicleMake; }
            set
            {
                lVehicleMake = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(VehicleMakes)));
            }
        }
        public MainViewModel()
        {
            repository = new Repo();
            lVehicleMake = new ObservableCollection<VehicleMake>(repository.InitVehicleModelData());
            vehicleMakeService = new VehicleMakeService();
            vehicleMakeService.SetVehicleMakeList(lVehicleMake);
            lVehicleMake = new ObservableCollection<VehicleMake>(vehicleMakeService.ReadVehicleMake());
        }


        

        public List<VehicleModel> GetSelectedMakerId(int makerId)
        {

            List<VehicleModel> lVehicleModel = repository.GetVehicleModels();
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

        public void UpdateList()
        {
            
            VehicleMakes = vehicleMakeService.ReadVehicleMake();
        }
    }
}
