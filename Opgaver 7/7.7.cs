using System;

class Program
{
    static void Main(string[] args)
    {
        double[] temperaturer = { 21.5, 23.7, 19.6, 22.5, 25.3, 21.7, 18.9 };
        string[] dage = { "Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fredag", "Lørdag", "Søndag" };

        for (int i = 1; i < temperaturer.Length; i++)
        {
            double differens = temperaturer[i] - temperaturer[i - 1];
            Console.WriteLine($"Temperaturdifferencen mellem {dage[i]} og {dage[i - 1]} er: {differens}°C");
        }
    }
}
