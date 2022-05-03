using AppCaderninho.TerceiroMedio;
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
    public partial class MateriasMedioTerceiro : ContentPage
    {
        public MateriasMedioTerceiro()
        {
            InitializeComponent();
        }

        private void BiologiaTerceiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroBiologia());
        }

        private void EdFisicaTerceiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroEdFisica());
        }

        private void FisologiaTerceiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroFilosofia());
        }

        private void FisicaTerceiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroFisica());
        }

        private void GeografiaTerceiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroGeografia());
        }

        private void HistoriaTerceiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroHistoria());
        }

        private void InglesTerceiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroIngles());
        }

        private void LPLTerceiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroLPL());
        }

        private void MatematicaTerceiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroMatematica());
        }

        private void QuimicaTerceiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroQuimica());
        }

        private void SociologiaTerceiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroSociologia());
        }

    }
}