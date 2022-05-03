using AppCaderninho.TerceiroTecnico;
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
    public partial class MateriasTecnicoTerceiro : ContentPage
    {
        public MateriasTecnicoTerceiro()
        {
            InitializeComponent();
        }

        private void TCCTerceiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroTcc());
        }

        private void MobileTerceiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroMobile());
        }

        private void InternetTerceiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroInternet());
        }

        private void WebTerceiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroWeb());
        }
        private void SotfwareTerceiro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TerceiroSoftware());
        }
    }
}