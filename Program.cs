using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        Console.WriteLine("Hello " + name);

        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Next year you will be " + (age + 1));

        if (age < 18)
        {
            Console.WriteLine("You are under 18.");
        }
        else
        {
            Console.Write("You are 18 or older");
        }
    }
}