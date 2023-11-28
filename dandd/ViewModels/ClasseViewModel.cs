using System.Collections.ObjectModel;
using System.Text.Json;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using dandd.Models;
using dandd.Services;

namespace dandd.ViewModels
{
    internal partial class ClasseViewModel : ObservableObject, IDisposable
    {

        private readonly ClasseServices _classeServices;

        [ObservableProperty]
        public string _Index;
        [ObservableProperty]
        public string _Name;
        [ObservableProperty]
        public string _Url;

        [ObservableProperty]
        public ObservableCollection<Classes> _classes;

        public ClasseViewModel()
        {
            _classes = new ObservableCollection<Classes>();
            _classeServices = new ClasseServices();
        }

        public ICommand GetPostsCommand => new Command(async () => await LoadSubRacesAsync());

        private async Task LoadSubRacesAsync()
        {
            _classes = await _classeServices.GetClassesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}