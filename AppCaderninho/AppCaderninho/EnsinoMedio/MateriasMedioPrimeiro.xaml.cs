using AppCaderninho.PrimeiroMedio; // esse using permitira que o codigo acesse essa pasta do primeiromedio
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCaderninho.EnsinoMedio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MateriasMedioPrimeiro : ContentPage
    {
        public MateriasMedioPrimeiro()
        {
            InitializeComponent();
        }

        private void ArtePrimeiro(object sender, EventArgs e)
        {
            //novamente, isso fara o usuario ir para a tela aonde estara o conteuno daquele ano e materia
            Navigation.PushAsync(new PrimeiroArte());
        }

        private void BiologiaPrimeiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroBiologia());
        }

        private void EdFisicaPrimeiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroEdFisica());
        }

        private void FilosofiaPrimeiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroFilosofia());
        }

        private void FisicaPrimeiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroFisica());
        }

        private void GeografiaPrimeiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroGeografia());
        }

        private void HistoriaPrimeiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroHistoria());
        }

        private void InglesPrimeiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroIngles());
        }

        private void LPLPrimeiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroLPL());
        }

        private void MatematicaPrimeiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroMatematica());
        }

        private void QuimicaPrimeiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroQuimica());
        }
    }
}