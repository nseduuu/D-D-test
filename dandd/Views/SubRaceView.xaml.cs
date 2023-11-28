using dandd.ViewModels;
using dandd.Models;

namespace dandd.Views
{
    public partial class SubRacaView : ContentPage
    {
        public SubRacaView()
        {
            InitializeComponent();
            BindingContext = new SubRaceViewModel();
        }
    }
}