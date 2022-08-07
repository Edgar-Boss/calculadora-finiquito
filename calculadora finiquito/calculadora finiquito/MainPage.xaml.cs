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
            InitializeComponent();//comentario de prueba para github ////
        }

        private void btn_liq_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Liquidacion());
        }
    }
}
