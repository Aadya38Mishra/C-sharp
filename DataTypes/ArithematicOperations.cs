using System;

public class ArithematicOperations
{
    static void Main()
    {
        int num1, num2;
        ArithematicOperations obj = new ArithematicOperations();
        Console.WriteLine("Enter the first number: ");
        num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter second number:");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("The operations formed on the numbers are: ");
        Console.WriteLine($"Sum :{obj.SumOfNumbers(num1, num2)}");
        Console.WriteLine($"Substraction :{obj.SubstractionOfNumbers(num1, num2)}");
        Console.WriteLine($"Multiplication :{obj.MultiplicationOfNumbers(num1, num2)}");
        Console.WriteLine($"Division :{obj.DivisionOfNumbers(num1, num2)}");
    }

    public int SumOfNumbers(int num1, int num2)
    {
        return (num1+num2);
    }
    public int SubstractionOfNumbers(int num1, int num2)
    {
        return (num1-num2);
    }
    public int MultiplicationOfNumbers(int num1, int num2)
    {
        return (num1 * num2);
    }
    public float DivisionOfNumbers(int num1, int num2)
    {
        return (float)(num1 / num2);
    }
}