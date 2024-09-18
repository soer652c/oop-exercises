using System;

class Program
{
    static void Main(string[] args)
    {
        long sekunderSiden1970 = 1000000000;

        const long sekunderPrDag = 60 * 60 * 24; 
        const long sekunderPrAar = sekunderPrDag * 365;

        long antalAar = sekunderSiden1970 / sekunderPrAar;

        long resterendeSekunder = sekunderSiden1970 % sekunderPrAar;
      
        long antalDageIndenforAaret = resterendeSekunder / sekunderPrDag;

        Console.WriteLine($"Tidsstemplet svarer til cirka {antalAar} år og {antalDageIndenforAaret} dage siden 1. januar 1970.");
    }
}
