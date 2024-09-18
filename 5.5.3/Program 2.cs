using System;

class Program
{
    static void Main(string[] args)
    {
        float f = 100.5f;
        Console.WriteLine("float f = " + f);

        double d;

        d = f;
        Console.WriteLine("double d = " + d);

        f = (float)d;
        Console.WriteLine("float f (efter cast fra double) = " + f);

        f = float.MaxValue;
        Console.WriteLine("Maksimal værdi for float: " + f);
        d = f;
        Console.WriteLine("Tildeler float.MaxValue til double: " + d);
      
        d = double.MaxValue;
        Console.WriteLine("Maksimal værdi for double: " + d);
        f = (float)d;
        Console.WriteLine("float f efter cast fra double.MaxValue = " + f);
    }
}
