using System;
namespace trianguloOrientadoObjeto
{
    internal class ClassTriangulo
    {
        //Atributos
        public double A;
        public double B;
        public double C;

        //Funcao
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

    }
}
