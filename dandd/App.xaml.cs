using dandd.Views;
namespace dandd
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RaceView();
            MainPage = new SubRacaView();
            MainPage = new ClasseView();
        }
    }
}