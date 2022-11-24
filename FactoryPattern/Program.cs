using FactoryPattern;


var circle = ShapeFactory.CreateShape(ShapeType.Circle);
circle.Render();