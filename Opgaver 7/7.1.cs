using System;

class Program
{
    static void Main(string[] args)
    {
        double[] radier = { 1.0, 3.0, 5.0 };
        
        foreach (double radius in radier)
        {
            double areal = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"Arealet af en cirkel med radius {radius} er: {areal}");
        }
    }
}
