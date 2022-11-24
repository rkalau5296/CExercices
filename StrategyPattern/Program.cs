using StrategyPattern;

var start = new Coordinate();
var end = new Coordinate();

var map = new Map(new StrategyBike());
map.CreateRoute(start, end);    