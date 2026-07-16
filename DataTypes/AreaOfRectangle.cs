using System;
public class AreaOfRectangle
{
    static void Main()
    {
        float length, breadth;
        Console.WriteLine("Enter the length:");
        length = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the breadth:");
        breadth = float.Parse(Console.ReadLine());

        Console.WriteLine($"Area of rectangle  :{RectangleArea(length, breadth)}");
    }

    public static float RectangleArea(float num1, float num2)
    {
        return (num1 * num2);
    }
}