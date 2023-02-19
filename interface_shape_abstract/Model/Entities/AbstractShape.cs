using interface_shape_abstract.Model.Enums;

namespace interface_shape_abstract.Model.Entities {
    abstract class AbstractShape : IShape {

        public Color Color { get; set; }

        public abstract double Area();
    }
}
