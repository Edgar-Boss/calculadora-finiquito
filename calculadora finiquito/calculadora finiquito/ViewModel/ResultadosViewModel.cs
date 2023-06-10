using calculadora_finiquito.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace calculadora_finiquito.ViewModel
{
    public class ResultadosViewModel
    {
        public ObservableCollection<Result> Resultados { get; set; }

        public ResultadosViewModel(Calculos calculos,bool mod)
        {


            if (mod)
            {
                Resultados = new ObservableCollection<Result>
                {
                new Result
                {
                    Nombre = "Salario Diario",
                    Cantidad = calculos.calcular_sd(),
                    color = Color.Gray
                },

                new Result
                {
                    Nombre = "Salario Minimo",
                    Cantidad = calculos.sal_min,
                    color = Color.Gray
                },
                new Result
                {
                    Nombre = "Prima de antigüedad",
                    Cantidad = calculos.calcular_prima_ant(),
                    color = Color.Gray
                },
                new Result
                {
                    Nombre = "Prima vacacional",
                    Cantidad = calculos.calcular_prim_vac(),
                    color = Color.Gray
                },
                new Result
                {
                    Nombre = "Indemnizacion Constitucional",
                    Cantidad = calculos.calcular_indemnizacion(),
                    color = Color.Gray
                },
                new Result
                {
                    Nombre = "Aguinaldo",
                    Cantidad = calculos.calcular_aguinaldo(),
                    color = Color.Gray
                },
                new Result
                {
                    Nombre = "Vacaciones",
                    Cantidad = calculos.calcular_vacaciones(),
                    color = Color.Gray
                },
                new Result
                {
                    Nombre = "Vacaciones sin pagar",
                    Cantidad = calculos.calcular_vac_no_pagados(),
                    color = Color.Gray
                },
                new Result
                {
                    Nombre = "Días sin pagar",
                    Cantidad = calculos.calcular_dias_no_pagados(),
                    color = Color.Gray
                },
                new Result
                {
                    Nombre = "Total correspondiente",
                    Cantidad = calculos.calcular_total(),
                    color = Color.ForestGreen
                }
                };
            }
            else
            {
                Resultados = new ObservableCollection<Result>
                {
                new Result
                {
                    Nombre = "Salario Diario",
                    Cantidad = calculos.calcular_sd(),
                    color = Color.Gray,
                },

                new Result
                {
                    Nombre = "Salario Minimo",
                    Cantidad = calculos.sal_min,
                    color = Color.Gray
                },
                new Result
                {
                    Nombre = "Prima vacacional",
                    Cantidad = calculos.calcular_prim_vac(),
                    color = Color.Gray
                },
                
                new Result
                {
                    Nombre = "Aguinaldo",
                    Cantidad = calculos.calcular_aguinaldo(),
                    color = Color.Gray
                },
                new Result
                {
                    Nombre = "Vacaciones",
                    Cantidad = calculos.calcular_vacaciones(),
                    color = Color.Gray
                },
                new Result
                {
                    Nombre = "Vacaciones sin pagar",
                    Cantidad = calculos.calcular_vac_no_pagados(),
                    color = Color.Gray
                },
                new Result
                {
                    Nombre = "Días sin pagar",
                    Cantidad = calculos.calcular_dias_no_pagados(),
                    color = Color.Gray
                },
                new Result
                {
                    Nombre = "Total correspondiente",
                    Cantidad = calculos.calcular_total(),
                    color = Color.ForestGreen
                }
                };
            }
        }
    }
}
