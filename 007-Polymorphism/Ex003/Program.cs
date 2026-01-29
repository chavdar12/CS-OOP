using Ex003;

Shape rectangle = new Rectangle(4.50, 6.50);
Shape circle = new Circle(4.50);

Console.WriteLine(rectangle.CalculateArea());
Console.WriteLine(rectangle.CalculatePerimeter());
Console.WriteLine(rectangle.Draw());

Console.WriteLine(circle.CalculateArea());
Console.WriteLine(circle.CalculatePerimeter());
Console.WriteLine(circle.Draw());