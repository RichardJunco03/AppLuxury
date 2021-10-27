using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLuxury
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.Agora());
                }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
