using System;

class Program
{
    static void Main(string[] args)
    {
        double temperaturCelsius = 25.0;
        Console.WriteLine($"Temperatur i Celsius: {temperaturCelsius}°C");

        double temperaturFahrenheit = 32 + (9.0 / 5.0) * temperaturCelsius;

        Console.WriteLine($"Temperatur i Fahrenheit: {temperaturFahrenheit}°F");
    }
}
