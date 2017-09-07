using Xamarin.Forms;

namespace EjemploEstilos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new EjemploEstilosPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
