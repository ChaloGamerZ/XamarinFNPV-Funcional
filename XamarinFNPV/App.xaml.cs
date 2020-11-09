using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFNPV
{
    public partial class App : Application
    {
        public App()
        {


            MainPage = new NavigationPage(new Principal());
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
