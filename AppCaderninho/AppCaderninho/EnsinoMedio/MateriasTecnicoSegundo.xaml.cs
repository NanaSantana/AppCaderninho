using AppCaderninho.SegundoTecnico;
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
    public partial class MateriasTecnicoSegundo : ContentPage
    {
        public MateriasTecnicoSegundo()
        {
            InitializeComponent();
        }

        private void BDSegundo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoBD());
        }

        private void MobileSegundo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoMobile());
        }

        private void SisSegundo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoSisEmbarcados());
        }

        private void WebSegundo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SegundoWeb());
        }
    }
}