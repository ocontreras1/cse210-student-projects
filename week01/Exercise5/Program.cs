using System;

class Program
{
    
    
    static void Main(string[] args)
    {
        DisplayWelcome();
        // Get name and number from user by using functions
        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        // square the number
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);

    }

    // Function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function to get a name from user
    static string PromptUserName()
    {
        Console.Write("What is your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Function to get number from user
    static int PromptUserNumber()
    {
        Console.Write("What is your favourite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Function to square the number
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    // Function to display the name and the square of the number
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    
}