using Plugin.Toast;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleCatalog.ViewModel;
using VehicleCatalog.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VehicleCatalog.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditVehicleMake : ContentPage
    {
        private VehicleMake vehicleMake;
        private EditVehicleMakeViewModel editVM;
        public EditVehicleMake(VehicleMake vehicleMake, ObservableCollection<VehicleMake> lVehicleMake)
        {
            InitializeComponent();
            editVM = new EditVehicleMakeViewModel(vehicleMake, lVehicleMake);
            BindingContext = editVM;
            this.vehicleMake = vehicleMake;
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            var Id = vehicleMake.id;
            var Name = vehicleName.Text;
            var Abrv = vehicleAbrv.Text;

            if (!String.IsNullOrEmpty(vehicleName.Text) && !String.IsNullOrEmpty(vehicleAbrv.Text))
            {

                editVM.EditVehicleMake(Id, Name, Abrv, vehicleMake);
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