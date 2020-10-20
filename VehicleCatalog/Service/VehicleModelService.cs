using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VehicleCatalog.Model;

namespace VehicleCatalog.Service
{
    public class VehicleModelService
    {
        private ObservableCollection<VehicleModel> lVehicleModel;

        public void SetVehicleModelList(ObservableCollection<VehicleModel> lVehicleModel)
        {
            this.lVehicleModel = lVehicleModel;
        }


        public void CreateVehicleModel(int id,int makeId, string name, string abrv)
        {
            VehicleModel vehicleModel = new VehicleModel(id, makeId, name, abrv);
            lVehicleModel.Add(vehicleModel);

        }

        public ObservableCollection<VehicleModel> ReadVehicleModel()
        {
            return lVehicleModel;
        }

        public void UpdateVehicleModel(int id, string name, VehicleModel vehicleModel)
        {
            //vehicleModel.name = name;

            int itemIndex;
            foreach (VehicleModel vm in lVehicleModel.ToList())
            {
                if (vm.id == id)
                {
                    /*
                     * Nije radilo pa sam morao raditi na pokušaj iznad
                     
                    vm.name = name;
                    vm.abrv = abrv;

                     */
                    itemIndex = lVehicleModel.IndexOf(vm);
                    lVehicleModel.Remove(vm);
                    lVehicleModel.Insert(itemIndex, new VehicleModel(vm.id,vm.makeId, name, vm.abrv));
                }
            }
            //lVehicleModel = new ObservableCollection<VehicleMake>(lVehicleModel);

        }

        public void DeleteVehicleModel(VehicleModel vehicleModel)
        {
            foreach (VehicleModel vm in lVehicleModel)
            {
                if (vehicleModel.id == vm.id)
                {
                    lVehicleModel.Remove(vm);
                }
            }
        }

        //public ObservableCollection<VehicleMake> SortVehicleMakeByName()
        //{
        //    lVehicleMake = new ObservableCollection<VehicleMake>(lVehicleMake.OrderByDescending(vm => vm.name).ToList());
        //    return lVehicleMake;
        //}

        //public ObservableCollection<VehicleMake> SortVehicleMakeById()
        //{
        //    lVehicleMake = new ObservableCollection<VehicleMake>(lVehicleMake.OrderByDescending(vm => vm.id).ToList());
        //    return lVehicleMake;
        //}
    }
}
