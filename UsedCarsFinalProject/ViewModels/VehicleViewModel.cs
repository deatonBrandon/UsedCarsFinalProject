using System;
using UsedCarsFinalProject.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UsedCarsFinalProject.ViewModels
{
    public class VehicleViewModel : BaseViewModel
    {
        public string? Logo { get; set; } = "logo.png";

        public VehicleViewModel()
        {
        }

        public ICommand SelectedItemCommand => new Command<Vehicles>(async (vehicleDetails) =>
        {
            var navParam = new Dictionary<string, object>
            {
                {"Vehicles", vehicleDetails }
            };

            await Shell.Current.GoToAsync(nameof(DetailsPage), navParam);
        });

        public ICommand GoToInventoryCommand => new Command(async () =>
        {
            await Shell.Current.GoToAsync($"///{nameof(InventoryPage)}");
        });

        public ICommand GoToMapCommand => new Command(async () =>
        {
            await Shell.Current.GoToAsync($"///{nameof(DirectionPage)}");
        });
    }
}