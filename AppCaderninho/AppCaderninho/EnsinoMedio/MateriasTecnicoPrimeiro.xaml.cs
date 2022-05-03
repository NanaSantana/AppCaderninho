using AppCaderninho.PrimeiroTecnico;
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
    public partial class MateriasTecnicoPrimeiro : ContentPage
    {
        public MateriasTecnicoPrimeiro()
        {
            InitializeComponent();
        }

        private void AnaPrimeiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroAnalise());
        }

        private void BDprimeiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroBD());
        }

        private void DesignPrimeiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroDesign());
        }

        private void FundPrimeiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroFundInfo());
        }

        private void WebPrimeiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeiroWeb());
        }
    }
}