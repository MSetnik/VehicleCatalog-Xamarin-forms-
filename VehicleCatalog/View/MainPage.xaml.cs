using Plugin.Toast;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleCatalog.Model;
using VehicleCatalog.ViewModel;
using Xamarin.Forms;

namespace VehicleCatalog
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedItem = e.Item as VehicleMake;

            CrossToastPopUp.Current.ShowToastMessage(selectedItem.name.ToString());

        }
    }
}
