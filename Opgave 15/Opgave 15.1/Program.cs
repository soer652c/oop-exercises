// Vi kører 10 iterationer
int iterationer = 10;
// arrayet går fra 1 til 5
int[] array = { 1, 2, 3, 4, 5 };
// incrementet stiger med 1 i hver iteration
try
{
    for (int i = 0; i < iterationer; i++)
    {
        // incrementer arrayet    
        array[i]++;
    }
}
catch (IndexOutOfRangeException e)
{
    // printer fejlmeddelelsen
    Console.WriteLine("Fejl i arrayet");
    Console.WriteLine(e);
}

// printer arrayet ud
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}