using System;

class Program
{
    static void Main(string[] args)
    {
        // Definerer radii for de tre cirkler
        double[] radier = { 1.0, 3.0, 5.0 };
        
        // Gennemgår hver radius og beregner arealet
        foreach (double radius in radier)
        {
            // Beregner arealet af cirklen
            double areal = Math.PI * Math.Pow(radius, 2);
            
            // Udskriver resultatet
            Console.WriteLine($"Arealet af en cirkel med radius {radius} er: {areal}");
        }
    }
}
