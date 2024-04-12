using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.PlatformConfiguration;

namespace calculadora_finiquito.ViewModel
{
    public class Calculos
    {
        int periodo = 0;
        DateTime ingreso, egreso;
        float sueldo = 0;
        public float sal_min = 0;
        public float sal_diario = 0;
        int dias_nop = 0;
        int dias_vac_nop = 0;
        bool mod;
        int dias_vac=0;

        public Calculos(float sal_min, float sueldo,int periodo, DateTime ingreso, DateTime egreso,int dias_vac,int dias_nop,int dias_vac_nop,bool mod)
        {
            this.periodo = periodo;
            this.ingreso = ingreso;
            this.egreso = egreso;
            this.sueldo = sueldo;
            this.sal_min = sal_min;
            this.dias_nop = dias_nop;
            this.dias_vac_nop = dias_vac_nop;
            this.mod = mod;
            this.dias_vac = dias_vac;
            sal_diario= calcular_sd();
        }

        public int  get_datos()
        {

            return periodo;
        }
        public float calcular_sd()
        {
            float sd = sueldo / periodo;
            return sd;
        }

        public int obtener_antiguedad()
        {
            int anios = egreso.Year - ingreso.Year;
            if ((ingreso.Month == egreso.Month && ingreso.Day > egreso.Day) || ingreso.Month > egreso.Month)
                anios--;
            
            return anios;
        }
        public float calcular_prima_ant()
        {
            float  sal_d = calcular_sd();

            if (sal_d < sal_min)
                sal_d = sal_min;
            else if( sal_d > (sal_min*2))
                sal_d = sal_min*2;


            var dias_tot = egreso - ingreso;



            

            return ((12f / 365f)* (float)dias_tot.TotalDays) * sal_d;
        }
        public float calcular_prim_vac()
        {


            float prim_vac = calcular_vacaciones() * 0.25f;

            return prim_vac;
        }

        public float calcular_vacaciones()
        {
            int dias;
            if (egreso.Month > ingreso.Month)
            {

                dias = egreso.DayOfYear-ingreso.DayOfYear;
            
            }
            else
            {
                dias = (365 - ingreso.DayOfYear) + egreso.DayOfYear;
                
            }


            float x = (( dias_vac / 365f )* (float)dias)* calcular_sd();
           

            return (float) x;
        }


        public float calcular_indemnizacion()
        {
            
            return calcular_sd() * 30 * 3; 
        }

        public float calcular_aguinaldo()
        {
            int day = egreso.DayOfYear;


            
            float dias_agui = day* (15f/365f);

            float x = dias_agui* calcular_sd();
            
            
            return x;
        }

        public float calcular_vac_no_pagados()
        {
            float x = dias_vac_nop * calcular_sd();

            return x;
        }
        public float calcular_dias_no_pagados()
        {
            float x = calcular_sd() * (float)dias_nop;
            return x;
        }

        public float calcular_total()
        {

            if (mod)
            {
                return calcular_aguinaldo() + calcular_vacaciones() + calcular_prim_vac() + calcular_prima_ant() + calcular_indemnizacion() + calcular_dias_no_pagados() + calcular_vac_no_pagados() ;
            }
            else
            {
                return calcular_aguinaldo() + calcular_vacaciones() + calcular_prim_vac() + calcular_dias_no_pagados() + calcular_vac_no_pagados() ;
            }
            //return 0;
        }

    }
}
