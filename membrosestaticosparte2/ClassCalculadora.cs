using System;
using System.Globalization;

namespace membrosestaticosparte2
{
    internal class ClassCalculadora
    {
        /*
         //Esse modo, é obrigatorio instanciar a classe
        public double Pi = 3.14;
        public double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public double Volume(double r)
        {
            //return 4.0 / 3.0 * Pi * r * r * r;
            // Ou
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
        */

        //Esse modo, não é obrigatorio instanciar a classe, com static
        public static double Pi = 3.14;
        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r)
        {
            //return 4.0 / 3.0 * Pi * r * r * r;
            // Ou
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}
