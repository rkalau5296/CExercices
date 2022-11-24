using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ShapeFactory
    {
        public static Shape CreateShape(ShapeType type)
        {
            return type switch
            {
                ShapeType.Circle => new Circle(),
                ShapeType.Triangle => new Triangle(),
                ShapeType.Rectangle => new Rectangle(),
                _ => throw new Exception($"Type {type} is not handled.")
            };
        }
    }
}
