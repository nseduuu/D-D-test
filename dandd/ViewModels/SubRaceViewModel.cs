using CommunityToolkit.Mvvm.ComponentModel;
using dandd.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using dandd.Services;

namespace dandd.ViewModels
{
    internal partial class SubRaceViewModel : ObservableObject, IDisposable
    {

        private readonly SubRaceServices _subRaceService;

        [ObservableProperty]
        public string _Index;
        [ObservableProperty]
        public string _Name;
        [ObservableProperty]
        public string _Url;
        public ObservableCollection<SubRaces> subRace;

        public SubRaceViewModel()
        {
           subRace = new ObservableCollection<SubRaces>();
            _subRaceService = new SubRaceServices();
        }

        public ICommand GetPostsCommand => new Command(async () => await LoadSubRacesAsync());

        private async Task LoadSubRacesAsync()
        {
          subRace = await _subRaceService.GetSubRacesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
