using Plugin.Toast;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleCatalog.Model;
using VehicleCatalog.Service;
using VehicleCatalog.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VehicleCatalog.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddVehicleMake : ContentPage
    {
        ObservableCollection<VehicleMake> lVehicleMake = new ObservableCollection<VehicleMake>();
        AddVehicleMakerVievModel addVehicleMakeVM;

        int id;
        public AddVehicleMake(ObservableCollection<VehicleMake> vehicleMakes, int id)
        {
            InitializeComponent();
            lVehicleMake = vehicleMakes;
            addVehicleMakeVM = new AddVehicleMakerVievModel(lVehicleMake);
            this.id = id;
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            var Name = vehicleName.Text;
            var Abrv = vehicleAbrv.Text;

            if(!String.IsNullOrEmpty(vehicleName.Text) && !String.IsNullOrEmpty(vehicleAbrv.Text))
            {
                addVehicleMakeVM.CreateVehicleMake(id, Name, Abrv);
                App.Current.MainPage.Navigation.PopAsync();
                CrossToastPopUp.Current.ShowToastMessage("Saved");
            }
            else
            {
                CrossToastPopUp.Current.ShowToastMessage("Fields cannot be empty.");
            }
        }
    }
}