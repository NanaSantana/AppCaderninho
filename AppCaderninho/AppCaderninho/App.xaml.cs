using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCaderninho
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // isso vai permitir a navegação de telas no app :D
            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
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
