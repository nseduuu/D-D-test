using CommunityToolkit.Mvvm.ComponentModel;
using dandd.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using dandd.Services;

namespace dandd.ViewModels
{
    internal partial class SubRaceViewModel : ObservableObject, IDisposable
    {

        private readonly SubRaceServices _subRaceServices;

        [ObservableProperty]
        public string _Index;
        [ObservableProperty]
        public int _Name;
        [ObservableProperty]
        public string _Url;

        [ObservableProperty]
        public ObservableCollection<SubRaces> _subRaces;

        public SubRaceViewModel()
        {
            SubRaces = new ObservableCollection<SubRaces>();
            _subRaceServices = new SubRaceServices();
        }

        public ICommand GetSubRacesCommand => new Command(async () => await LoadSubRacesAsync());

        private async Task LoadSubRacesAsync()
        {
            SubRaces = await _subRaceServices.GetSubRacesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
