using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculadora_finiquito.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace calculadora_finiquito
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Liquidacion : ContentPage
    {
        Calculos calculos;
        public Liquidacion()
        {
            InitializeComponent();

            dp_ingreso_DateSelected(null, null);
            


            
           






        }

        private void chb_vac_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value == true)
            {
                ent_vac.IsEnabled = true;

            }
            else 
            {
                ent_vac.IsEnabled = false;
            }
        }

        private void dp_ingreso_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime hoy = DateTime.Today;
            hoy = hoy.AddDays(-1);
            dp_ingreso.MaximumDate= hoy;
            
        }

        private void btn_calcular_Clicked(object sender, EventArgs e)
        {
            //TimeSpan timeSpan = dp_egreso.Date - dp_ingreso.Date
            //int dias = timeSpan.Days;
            int periodo = pk_periodo.SelectedIndex;

            switch (periodo)
            {
                case 0:
                    periodo = 7;
                    break;
                case 1:
                    periodo = 15;
                    break;
                case 2:
                    periodo = 30;
                    break;

            }
            calculos = new Calculos(periodo);

            DisplayAlert("",calculos.get_datos().ToString(),"ok");
            int res= calculos.obtener_antiguedad(dp_ingreso.Date.Year, dp_egreso.Date.Year);
            //DisplayAlert("", res.ToString(), "OK");

           
            
            double  x = calculos.calcular_sdi(float.Parse(ent_sueldo.Text), periodo);
            //DisplayAlert("", x.ToString(), "ok");
        }

      
    }
}