using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using VehicleCatalog.Model;
using VehicleCatalog.Service;

namespace VehicleCatalog.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<VehicleMake> lVehicleMake = new ObservableCollection<VehicleMake>();
        public ObservableCollection<VehicleMake> oVehicleMakes;
        public VehicleMakeService vehicleMakeService;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            InitVehicleModelData();
            vehicleMakeService = new VehicleMakeService(lVehicleMake);
            oVehicleMakes = new ObservableCollection<VehicleMake>(vehicleMakeService.ReadVehicleMake());
        }

        public ObservableCollection<VehicleMake> VehicleMakes { get => oVehicleMakes; set { oVehicleMakes = value;  OnPropertyChanged(nameof(VehicleMakes)); } }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void InitVehicleModelData()
        {

            VehicleMake vm = new VehicleMake(1, "BMW", "BMW");
            VehicleMake vm1 = new VehicleMake(2, "Audi", "Audi");
            VehicleMake vm2 = new VehicleMake(3, "Volkswagen", "VW");
            VehicleMake vm3 = new VehicleMake(4, "Opel", "Opel");
            VehicleMake vm4 = new VehicleMake(5, "Ford", "Ford");
            VehicleMake vm5 = new VehicleMake(6, "Mercedes-benz", "Mercedes-benz");
            VehicleMake vm6 = new VehicleMake(7, "Škoda", "Škoda");


            lVehicleMake.Add(vm);
            lVehicleMake.Add(vm1);
            lVehicleMake.Add(vm2);
            lVehicleMake.Add(vm3);
            lVehicleMake.Add(vm4);
            lVehicleMake.Add(vm5);
            lVehicleMake.Add(vm6);
        }

        public List<VehicleModel> GetVehicleModels()
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

        public List<VehicleModel> GetSelectedMakerId(int makerId)
        {

            List<VehicleModel> lVehicleModel = GetVehicleModels();
            List<VehicleModel> lVehicleMakerModels = new List<VehicleModel>();
            foreach (VehicleModel vm in lVehicleModel)
            {
                if(vm.makeId == makerId)
                {
                    lVehicleMakerModels.Add(vm);
                }
            }
            return lVehicleMakerModels;
            
        }
    }
}
