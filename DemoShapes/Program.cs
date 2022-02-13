//https://www.tutorialspoint.com/design_pattern/decorator_pattern.htm
using DemoShapes;

Shape circle = new Circle();

Shape redCircle = new RedShapeDecorator(new Circle());

Shape redRectangle = new RedShapeDecorator(new Rectangle());
Console.WriteLine("Circle with normal border");
circle.draw();

Console.WriteLine("\nCircle of red border");
redCircle.draw();

Console.WriteLine("\nRectangle of red border");
redRectangle.draw();

Shape redRectangleInHtml = new HtmlFormatDecorator(redRectangle);
Console.WriteLine("\nRectangle of red border in HTML Format");
redRectangleInHtml.draw();