using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3TareaDario
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new VentanaUno());
            //MainPage = new Page1();

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
