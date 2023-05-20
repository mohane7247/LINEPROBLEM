using System;
using System.Drawing;

public class Line
{
    private Point startPoint;
    private Point endPoint;

    public Line(Point startPoint, Point endPoint)
    { this.startPoint = startPoint;
        this.endPoint = endPoint;
    }
    public bool Isequal(Line otherLine)
    {
        return startPoint.Equals(otherLine.startPoint) && endPoint.Equals(otherLine.endPoint);
    }
}
public class Point
{
    private double x;
    private double y;
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        Point otherPoint = (Point)obj;
        return x == otherPoint.x && y == otherPoint.y;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(x,y);

    }
}
public class program
{
    public static void Main(string[] args)
    {
        Point point1 = new Point(1, 2);
        Point point2 = new Point(0, 4);
        Point point3 = new Point(5, 6);
        Point point4 = new Point(3, 0);

        Line line1 = new Line(point1, point2);
        Line line2 = new Line(point3, point4);

        bool areEqual = line1.Isequal(line2);
        Console.WriteLine($"are thge lines equal{areEqual}");



    }
}