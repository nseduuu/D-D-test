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

        [ObservableProperty]
        public int _Id;
        [ObservableProperty]
        public string _Name;
        [ObservableProperty]
        public string _Url;

        public ObservableCollection<Classes> classes;
        private readonly ClasseServices _classeServices;

        public ClasseViewModel()
        {
            classes = new ObservableCollection<Classes>();
            _classeServices = new ClasseServices();
        }

        public ICommand GetPostsCommand => new Command(async () => await LoadSubRacesAsync());

        private async Task LoadSubRacesAsync()
        {
            classes = await _classeServices.GetClassesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}