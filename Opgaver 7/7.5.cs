using System;

class Program
{
    static void Main(string[] args)
    {
        int måned = 2;

        Console.WriteLine("Måned: " + måned);

        måned += (int)0.5;
        Console.WriteLine("Måned efter at være forøget med en halv: " + måned);

        måned += (int)0.5; 
        Console.WriteLine("Måned efter at være forøget med en halv igen: " + måned);
    }
}
