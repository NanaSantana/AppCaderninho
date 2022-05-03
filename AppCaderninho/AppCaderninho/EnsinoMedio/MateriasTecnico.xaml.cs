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
    public partial class MateriasTecnico : ContentPage
    {
        public MateriasTecnico()
        {
            InitializeComponent();
        }


        private void btnPrimeiroTecnico(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MateriasTecnicoPrimeiro());
        }

        private void bntSegundoTecnico(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MateriasTecnicoSegundo());
        }

        private void bntTerceiroTecnico(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MateriasTecnicoTerceiro());
        }
    }
}