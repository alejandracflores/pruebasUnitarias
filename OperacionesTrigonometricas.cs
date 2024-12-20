﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class OperacionesTrigonometricas
    {
        public static double CalcularSeno(double anguloGrados)
        {
            double anguloRadianes = ConvertirGradosARadianes(anguloGrados);
            // return Math.Tan(anguloRadianes);
		    // Corrección
            return Math.Sin(anguloRadianes);
        }

        public static double CalcularCoseno(double anguloGrados)
        {
            double anguloRadianes = ConvertirGradosARadianes(anguloGrados);
            // return Math.Sin(anguloRadianes);
		    // Corrección
            return Math.Cos(anguloRadianes);
        }

        private static double ConvertirGradosARadianes(double grados)
        {
            return grados * (Math.PI / 180);
        }
    }

}
