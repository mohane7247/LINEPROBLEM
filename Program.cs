using System;

public class Line
{
    private double x1;
    private double y1;
    private double x2;
    private double y2;


    public Line(double x1, double y1, double x2, double y2)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;

    }
    public double CalculateLenght()
    {
        double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
           return length; 
          
           }
}
public class program
{
 public static void Main(string[] args)
    { 
        double x1 = 5.0;
        double y1 = 4.0;
        double x2 = 3.0;
        double y2 = 9.0;
        Line line = new Line(x1, y1, x2, y2);

        double length = line.CalculateLenght();
        Console.WriteLine("the length of the line is" + length);
            
            
            }
}