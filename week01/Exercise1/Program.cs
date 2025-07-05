using System;

class Program
{
    static void Main(string[] args)
    {
        // Get user imput for name and last name and store in variables
        Console.WriteLine("What is your first name?");
        string first_name = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string last_name = Console.ReadLine();

        // Display the name in last name, firs name format
        Console.WriteLine($"Your name is {last_name}, {first_name}");
    }
}