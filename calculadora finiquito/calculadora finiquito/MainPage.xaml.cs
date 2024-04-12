using MarcTron.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculadora_finiquito
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();
            
        }

        private void btn_liq_Clicked(object sender, EventArgs e)
        {

            float sm = 207.44f;
            switch (pk_estados.SelectedIndex)
            {
                case 1: case 5: case 7: case 18: case 25: case 27: sm= 312.41f;
                    break;
            }

            if (pk_estados.SelectedIndex != -1)
                Navigation.PushAsync(new Liquidacion(sm));
            else
                DisplayAlert(null, "Debe seleccionar un estado", "ok");
        }

        private void btn_fin_Clicked(object sender, EventArgs e)
        {
            
            float sm = 207.44f;
            switch (pk_estados.SelectedIndex)
            {
                case 1:
                case 5:
                case 7:
                case 18:
                case 25:
                case 27:
                    sm = 312.41f;
                    break;
            }

            if (pk_estados.SelectedIndex != -1)
                Navigation.PushAsync(new Finiquito(sm));
            else
                DisplayAlert(null,"Debe seleccionar un estado","ok");
        }
    }
}
