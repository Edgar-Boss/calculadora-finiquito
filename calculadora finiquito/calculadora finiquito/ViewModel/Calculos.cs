using System;
using System.Collections.Generic;
using System.Text;

namespace calculadora_finiquito.ViewModel
{
    internal class Calculos
    {
        int periodo = 0;

        public Calculos(int periodo )
        {
            this.periodo = periodo;
        }

        public int  get_datos()
        {

            return periodo;
        }
        public double calcular_sdi(float sal_di,int periodo)
        {

            float sdi = sal_di / periodo;
            
            return sdi;
            
            

        }

        public int obtener_antiguedad(int ingreso, int egreso)
        {

            int res = 0;
            res = egreso - ingreso;

            
            return periodo;
        }
    }
}
