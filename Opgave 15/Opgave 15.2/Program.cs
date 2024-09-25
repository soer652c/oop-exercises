int[] accounts = { 903, 716, 67 };
int GetAccountNumber()
{
while (true)
{  
 try
 {
Console.WriteLine("Enter an account number: ");
return Convert.ToInt32(Console.ReadLine());
}
catch (FormatException e)
{
Console.WriteLine("Invalid input");
Console.WriteLine(e.Message);
}
}
}
void PrintAccountState(int accountId)
{
Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
}
while (true)
{
try
{
int accountId = GetAccountNumber();
PrintAccountState(accountId);
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine("Account number does not exist"); 
    Console.WriteLine(e);
}
}