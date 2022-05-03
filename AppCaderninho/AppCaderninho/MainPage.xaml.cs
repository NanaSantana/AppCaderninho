using AppCaderninho.EnsinoMedio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCaderninho
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //ao clicar no botão, isso fara o usuario ir para da tela de MateriasMedio
            Navigation.PushAsync(new MateriasMedio());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            //ao clicar no botão, isso fara o usuario ir para da tela de MateriasTecnico
            Navigation.PushAsync(new MateriasTecnico());
        }
    }
}
