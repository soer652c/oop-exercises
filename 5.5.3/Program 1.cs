using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 100;
        Console.WriteLine("int i = " + i);

        long l;

        l = i;
        Console.WriteLine("long l = " + l);
      
        i = (int)l;
        Console.WriteLine("int i (efter cast fra long) = " + i);

        i = int.MaxValue;
        Console.WriteLine("Maksimal værdi for int: " + i);
        l = i;
        Console.WriteLine("Tildeler maksimal værdi af int til long l = " + l);

        l = long.MaxValue;
        Console.WriteLine("Maksimal værdi for long: " + l);
        i = (int)l;
        Console.WriteLine("int i efter cast fra long.MaxValue = " + i);
    }
}
