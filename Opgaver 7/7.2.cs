using System;

class Program
{
    static void Main(string[] args)
    {
        double[] radier = { 1.0, 3.0, 5.0 };
        
        double samletOmkreds = 0.0;

        foreach (double radius in radier)
        {
            double omkreds = 2 * Math.PI * radius;
            
            Console.WriteLine($"Omkredsen af en cirkel med radius {radius} er: {omkreds}");
            samletOmkreds += omkreds;
        }

        Console.WriteLine($"\nSummen af omkredsene er: {samletOmkreds}");
    }
}
