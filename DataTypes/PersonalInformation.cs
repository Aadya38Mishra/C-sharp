using System;

public class PersonalInformation
{
    static void Main(){
    string name = "";
    int age;
    float height;
    bool isStudent;

    Console.WriteLine("Enter the name: ");
    name = Console.ReadLine();
    Console.WriteLine("Enter age: ");
    age = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter height: ");
    height = float.Parse(Console.ReadLine());
    Console.WriteLine("Is Student: ");
    isStudent = bool.Parse(Console.ReadLine());

    Console.WriteLine("----Candidate Details----");
    Console.WriteLine("Name : {0}", name);
    Console.WriteLine("Age : {0}", age);
    Console.WriteLine("Height : {0}", height);
    Console.WriteLine("Student: {0}", isStudent);
    }
}