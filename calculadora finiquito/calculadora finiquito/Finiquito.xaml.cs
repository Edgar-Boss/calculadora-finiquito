using calculadora_finiquito.ViewModel;
using MarcTron.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace calculadora_finiquito
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Finiquito : ContentPage
    {
        Calculos calculos;
        float sal_min;
        public Finiquito(float sal_min)
        {
            CrossMTAdmob.Current.OnInterstitialLoaded += (sender, e) => { CrossMTAdmob.Current.ShowInterstitial(); };
            InitializeComponent();
            this.sal_min = sal_min;
        }

        private void CargarAnuncio()
        {
            //CrossMTAdmob.Current.LoadInterstitial("ca-app-pub-8967169262052512/3216972468");
            //CrossMTAdmob.Current.OnInterstitialClosed -= InterstitialCerrado;
            //CrossMTAdmob.Current.OnInterstitialLoaded += (sender, e) => { CrossMTAdmob.Current.ShowInterstitial(); };
            //CrossMTAdmob.Current.LoadInterstitial("ca-app-pub-3940256099942544/1033173712");
            CalcularResultado();
            InterstitialCerrado();
            //CrossMTAdmob.Current.OnInterstitialClosed += InterstitialCerrado;
            //btn_calcular.Text = "Calculando ...";


        }
        private void InterstitialCerrado()//(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Resultados(calculos, false));
            //Navigation.PushAsync(new Resultados(calculos, true));

        }

        private void CalcularResultado()
        {
            int dias_nop = 0;
            int vac_nop = 0;

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

            if (ent_idas_nop.Text != null && ent_idas_nop.Text != "")
            {
                try
                {
                    dias_nop = int.Parse(ent_idas_nop.Text);
                }
                catch (Exception ex)
                {
                    dias_nop = (int)Math.Floor(float.Parse(ent_idas_nop.Text));

                }

            }
            if (ent_vac_nop.IsEnabled)
            {
                if (ent_vac_nop.Text != null && ent_vac_nop.Text != "")
                {
                    try
                    {
                        vac_nop = int.Parse(ent_vac_nop.Text);
                    }
                    catch (Exception ex)
                    {
                        vac_nop = (int)Math.Floor(float.Parse(ent_vac_nop.Text));
                    }
                }
            }
            else
                vac_nop = 0;

            int diasdevac_aux = calcular_dias_de_vac();
            if (ent_idasvac.Text != "" && ent_idasvac.Text != null && ent_idasvac.Text != "0" && int.Parse(ent_idasvac.Text) >= diasdevac_aux)
            {
                diasdevac_aux = int.Parse(ent_idasvac.Text);
            }


            calculos = new Calculos(sal_min, float.Parse(ent_sueldo.Text), periodo, dp_ingreso.Date, dp_egreso.Date, diasdevac_aux, dias_nop, vac_nop, false);


        }
        private void btn_calcular_Clicked(object sender, EventArgs e)
        {
            CargarAnuncio();
             

        }
        private void chb_vac_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value == true)
            {
                ent_vac_nop.IsEnabled = true;

            }
            else
            {
                ent_vac_nop.IsEnabled = false;
            }
        }
        private void dp_ingreso_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime hoy = DateTime.Today;
            hoy = hoy.AddDays(-1);
            dp_ingreso.MaximumDate = hoy;
        }
        private void dp_ingreso_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

            ent_idasvac.Text = calcular_dias_de_vac().ToString();
        }
        public int calcular_dias_de_vac()
        {
            int anios = obtener_antiguedad();
            int dias_vac = 0;

            switch (anios)
            {
                case 0:
                case 1:
                    dias_vac = 12;
                    break;
                case 2:
                    dias_vac = 14;
                    break;
                case 3:
                    dias_vac = 16;
                    break;
                case 4:
                    dias_vac = 18;
                    break;
                case 5:
                    dias_vac = 20;
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    dias_vac = 22;
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    dias_vac = 24;
                    break;
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    dias_vac = 26;
                    break;
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                    dias_vac = 28;
                    break;
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                    dias_vac = 30;
                    break;
                default:
                    if (anios > 30)
                    {
                        dias_vac = 24;
                    }
                    break;
            }
            return dias_vac;
        }
        public int obtener_antiguedad()
        {

            
            int anios = dp_egreso.Date.Year - dp_ingreso.Date.Year;
            if ((dp_ingreso.Date.Month == dp_egreso.Date.Month && dp_ingreso.Date.Day > dp_egreso.Date.Day) || dp_ingreso.Date.Month > dp_egreso.Date.Month)
                anios--;

            return anios;
        }
        private void dp_ingreso_PropertyChanging(object sender, PropertyChangingEventArgs e)
        {
            ent_idasvac.Text = calcular_dias_de_vac().ToString();
        }
        private void ent_sueldo_PropertyChanging(object sender, PropertyChangingEventArgs e)
        {
            if (ent_sueldo.Text != "0" && ent_sueldo.Text != "" && ent_sueldo.Text != null && pk_periodo.SelectedIndex != -1)
            {
                btn_calcular.IsEnabled = true;
            }
            else
            {
                btn_calcular.IsEnabled = false;
            }
        }
        private void pk_periodo_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (ent_sueldo.Text != "0" && ent_sueldo.Text != "" && ent_sueldo.Text != null && pk_periodo.SelectedIndex != -1)
            {
                btn_calcular.IsEnabled = true;
            }
            else
            {
                btn_calcular.IsEnabled = false;
            }
        }
    }
}