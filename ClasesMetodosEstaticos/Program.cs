double circleArea = AdvanceMath.CalculateCircleArea(5.0);
double rectanglePerimeter = AdvanceMath.CalculateRectanglePerimeter(4.0, 6.0);
Console.WriteLine($"Circle Area: {circleArea}. " +
    $"Rectangle Perimeter: {rectanglePerimeter}");
public static class AdvanceMath
{
    public static double CalculateCircleArea(double radius)
    {
        if (radius < 0)
            throw new ArgumentException("Radius cannot be negative");

        return Math.PI * radius * radius;
    }

    public static double CalculateRectanglePerimeter
        (double width, double height)
    {
        if ((width < 0) || (height < 0))
            throw new 
                ArgumentException("Width and height cannot be negative");

        return 2 * (width + height);
    }
}