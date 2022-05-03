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
    public partial class MateriasMedio : ContentPage
    {
        public MateriasMedio()
        {
            InitializeComponent();
        }

        private void btnPrimeiroAno(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MateriasMedioPrimeiro());
        }

        private void btnTerceiroAno(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MateriasMedioTerceiro());
        }

        private void btnSegundoAno(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MateriasMedioSegundo());
        }
    }
}