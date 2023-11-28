using dandd.ViewModels;
using dandd.Models;

namespace dandd.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClasseView : ContentPage
    {
        public ClasseView()
        {
            InitializeComponent();
            BindingContext = new ClasseViewModel();
        }

    }
}