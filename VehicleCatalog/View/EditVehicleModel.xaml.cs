using Plugin.Toast;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleCatalog.Model;
using VehicleCatalog.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VehicleCatalog.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditVehicleModel : ContentPage
    {
        private VehicleModel vehicleModel;
        private EditVehicleModelViewModel editVM;
        public EditVehicleModel(VehicleModel vehicleModel, ObservableCollection<VehicleModel> lVehicleModel)
        {
            InitializeComponent();
            editVM = new EditVehicleModelViewModel(vehicleModel, lVehicleModel);
            BindingContext = editVM;
            this.vehicleModel = vehicleModel;
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            var id = vehicleModel.id;
            var name = vehicleModelName.Text;

            if (!String.IsNullOrEmpty(name))
            {

                editVM.EditVehicleMake(id, name, vehicleModel);
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