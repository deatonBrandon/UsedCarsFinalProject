using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsedCarsFinalProject.Models;

namespace UsedCarsFinalProject.ViewModels
{
    [QueryProperty(nameof(Vehicles), "Vehicles")]
    public class VehicleDataViewModel : BaseViewModel
    {
        private Vehicles? _vehicles;
        public Vehicles Vehicles
        {
            get => _vehicles;
            set
            {
                _vehicles = value;
                OnPropertyChanged(nameof(Vehicles));
            }
        }
    }
}
