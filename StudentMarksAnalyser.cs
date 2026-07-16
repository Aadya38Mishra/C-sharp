using System;
public class StudentMarksAnalyser
{
    static void Main()
    {
        string studentName;
        int rollNo;
        long? phoneNumber;
        int[] marks = new int[5];
        Console.WriteLine("Enter the name of the student: ");
        studentName = Console.ReadLine();
        Console.WriteLine("Enter the roll number of the student: ");
        rollNo = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the contact number of the student: ");
        string? input = (Console.ReadLine());
        phoneNumber = string.IsNullOrWhiteSpace(input) ? null : long.Parse(input);
        Console.WriteLine("Enter the marks of 1st subject: ");
        marks[0] = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the marks of 2nd subject: ");
        marks[1] = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the marks of 3rd subject: ");
        marks[2] = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the marks of 4th subject: ");
        marks[3] = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the marks of 5th subject: ");
        marks[4] = int.Parse(Console.ReadLine());

        double total =(marks[0]+marks[1]+marks[2]+marks[3]+marks[4]);
        double average =(total/5);

        Console.WriteLine("Here are the details of the student:");
        Console.WriteLine($"Name : {studentName}");
        Console.WriteLine($"Roll No : {rollNo}");
        Console.WriteLine($"Phone Number : {(phoneNumber.HasValue ? phoneNumber.ToString() : "Not provided")}");
        Console.WriteLine($"Marks of all subjects: ");
        Console.WriteLine($"1st subject : {marks[0]}");
        Console.WriteLine($"2nd subject : {marks[1]}");
        Console.WriteLine($"3rd subject : {marks[2]}");
        Console.WriteLine($"4th subject : {marks[3]}");
        Console.WriteLine($"5th subject : {marks[4]}");
        Console.WriteLine($"Total marks : {total}");
        Console.WriteLine($"Average marks : {average}");
    }
}