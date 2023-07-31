using StrategyDesignPattern;

var circle = new Circle
{
    Radius= 10,
};
var circleShape = new Shape(circle);

Console.WriteLine($"Area of circle is {circleShape.CalculateArea()}");


var square = new Square
{
    SideLength = 5
};
var squareShape = new Shape(square);

Console.WriteLine($"Area of square is {squareShape.CalculateArea()}");
