using UsedCarsFinalProject.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace UsedCarsFinalProject.ViewModels
{
    public partial class BaseViewModel : INotifyPropertyChanged
    {
        public string? contentUri = "http://localhost/dealership.json";

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public BaseViewModel()
        {
            FetchVehicleData();
        }

        private List<Vehicles>? source;
        public ObservableCollection<Vehicles>? SourceCollection { get; private set; }

        public async void FetchVehicleData()
        {
            var _httpClient = new HttpClient();
            try
            {
                source = new List<Vehicles>();
                List<Vehicles>? jsonRes = await _httpClient.GetFromJsonAsync<List<Vehicles>>(contentUri);
                jsonRes?.ForEach(x => source.Add(x));

                SourceCollection = new ObservableCollection<Vehicles>(source);
                OnPropertyChanged(nameof(SourceCollection));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
