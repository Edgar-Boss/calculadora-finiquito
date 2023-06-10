using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using calculadora_finiquito.ViewModel;
using System.IO;
using System.Data.SqlTypes;
using System.Globalization;
using MarcTron.Plugin;

namespace calculadora_finiquito
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resultados : ContentPage
    {

        Calculos calculos;
        bool mod;
        public Resultados(Calculos calculos,bool mod)
        {
            InitializeComponent();
            
            BindingContext = new ResultadosViewModel(calculos,mod);
            this.calculos = calculos;
            this.mod = mod;
            

        }

        [Obsolete]
        private async void btn_wp_Clicked(object sender, EventArgs e)
        {

            string Codigo = "+52";
           
            if (mod)
            {
                Codigo += await DisplayPromptAsync("Enviar resultados", "ingrese numero al que desea enviar", "aceptar", "cancelar", "numero", maxLength: 10, keyboard: Keyboard.Numeric);

                if (Codigo.Length == 13)
                {
                    
                    Chat.Open(Codigo, " Salario Diario \n "
                        + calculos.calcular_sd().ToString("C3", CultureInfo.CreateSpecificCulture("es-MX"))
                        + "\nSalario Minimo \n"
                        + calculos.sal_min.ToString("C3", CultureInfo.CreateSpecificCulture("es-MX"))
                        + "\nPrima de antigüedad\n"
                        + calculos.calcular_prima_ant().ToString("C3", CultureInfo.CreateSpecificCulture("es-MX"))
                        + "\nIndemnizacion constitucional\n"
                        + calculos.calcular_indemnizacion().ToString("C3", CultureInfo.CreateSpecificCulture("es-MX"))
                        + "\nAguinaldo\n"
                        + calculos.calcular_aguinaldo().ToString("C3", CultureInfo.CreateSpecificCulture("es-MX"))
                        + "\nVacaciones\n"
                        + calculos.calcular_vacaciones().ToString("C3", CultureInfo.CreateSpecificCulture("es-MX"))
                        + "\nVacaciones sin pagar\n"
                        + calculos.calcular_vac_no_pagados().ToString("C3", CultureInfo.CreateSpecificCulture("es-MX"))
                        + "\nDías sin pagar\n"
                        + calculos.calcular_dias_no_pagados().ToString("C3", CultureInfo.CreateSpecificCulture("es-MX"))
                        + "\nTotal correspondiente\n"
                        + calculos.calcular_total().ToString("C3", CultureInfo.CreateSpecificCulture("es-MX")));
                }
                else
                {
                    await DisplayAlert("Error", "numero no valido", "ok");
                }

            }
            else 
            {
               
                Codigo += await DisplayPromptAsync("Enviar resultados", "ingrese numero al que desea enviar", "aceptar", "cancelar", "numero", maxLength: 10, keyboard: Keyboard.Numeric);

                if (Codigo.Length == 13)
                {
                   
                    Chat.Open(Codigo, " Salario Diario \n "
                        + calculos.calcular_sd().ToString("C3", CultureInfo.CreateSpecificCulture("es-MX"))
                        + "\nSalario Minimo \n"
                        + calculos.sal_min.ToString("C3", CultureInfo.CreateSpecificCulture("es-MX"))
                        + "\nPrima vacacional\n"
                        + calculos.calcular_prim_vac().ToString("C3", CultureInfo.CreateSpecificCulture("es-MX"))
                        + "\nAguinaldo\n"
                        + calculos.calcular_aguinaldo().ToString("C3", CultureInfo.CreateSpecificCulture("es-MX"))
                        + "\nVacaciones\n"
                        + calculos.calcular_vacaciones().ToString("C3", CultureInfo.CreateSpecificCulture("es-MX"))
                        + "\nVacaciones sin pagar\n"
                        + calculos.calcular_vac_no_pagados().ToString("C3", CultureInfo.CreateSpecificCulture("es-MX"))
                        + "\nDías sin pagar\n"
                        + calculos.calcular_dias_no_pagados().ToString("C3", CultureInfo.CreateSpecificCulture("es-MX"))
                        + "\nTotal correspondiente\n"
                        + calculos.calcular_total().ToString("C3", CultureInfo.CreateSpecificCulture("es-MX")));
                }
                else
                {
                    await DisplayAlert("Error", "numero no valido", "ok");
                }

            }

            
           
            
           
        }
    }
}