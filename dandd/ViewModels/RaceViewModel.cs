using CommunityToolkit.Mvvm.ComponentModel;
using dandd.Models;
using dandd.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;

namespace dandd.ViewModels
{
    internal partial class RaceViewModel : ObservableObject, IDisposable
    {

        private readonly RaceServices _raceServices;

        [ObservableProperty]
        public string _Index;
        [ObservableProperty]
        public string _Name;
        [ObservableProperty]
        public string _Url;

        [ObservableProperty]
        public ObservableCollection<Races> _Races;

        public RaceViewModel()
        {
            Races = new ObservableCollection<Races>();
            _raceServices = new RaceServices();
        }

        public ICommand GetRacesCommand => new Command(async () => await LoadRacesAsync());

        private async Task LoadRacesAsync()
        {
            Races = await _raceServices.GetRacesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
