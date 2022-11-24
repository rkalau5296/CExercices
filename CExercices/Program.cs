using FactoryPattern;
using SingielResponsibility.Class;
using StrategyPattern;

var circle = ShapeFactory.CreateShape(ShapeType.Circle);
circle.Render();

var start = new Coordinate();
var end = new Coordinate();

var map = new Map(new StrategyBike());
map.CreateRoute(start, end);


