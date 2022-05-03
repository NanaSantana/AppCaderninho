using AppCaderninho.SegundoMedio;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCaderninho.EnsinoMedio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MateriasMedioSegundo : ContentPage
    {
        public MateriasMedioSegundo()
        {
            InitializeComponent();
        }

        private void BiologiaSegundo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoBiologia());
        }

        private void EdFisicaSegundo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoEdFisica());
        }

        private void EticaSegundo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoEtica());
        }

        private void FilosofiaSegundo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoFilosofia());
        }

        private void FisicaSegundo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoFisica());
        }

        private void GeografiaSegundo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoGeografia());
        }

        private void HistoriaSegundo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoHistoria());
        }

        private void InglesSegundo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoIngles());
        }

        private void LPLSegundo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoLPL());
        }

        private void MatematicaSegundo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoMatematica());
        }

        private void QuimicaSegundo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoQuimica());
        }

        private void SociologiaSegundo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoSociologia());
        }
    }
}