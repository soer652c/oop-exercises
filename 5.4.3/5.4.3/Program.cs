using System;

class Intmaskine{
static void Main(String[] args)
{
    int maxValue = int.MaxValue;
    Console.WriteLine("Maksimal værdi for int: " + maxValue);

    int overflowValue = maxValue + 1;
    Console.WriteLine("Efter overflow: " + overflowValue);

    Console.WriteLine("Minimale værdi for int: " + int.MinValue);
}
}