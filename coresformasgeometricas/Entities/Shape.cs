using coresformasgeometricas.Entities.Enums;

namespace coresformasgeometricas.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        // O calculo da Area é muito generica, nesse caso deve-se ser abstrata
        public abstract double Area();
    }
}
