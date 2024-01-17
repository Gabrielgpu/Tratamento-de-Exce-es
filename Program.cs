

using System.Globalization;
using exercicio_8.Entities;
using exercicio_8.Entities.Exceptions;
try
{


    Console.WriteLine("Enter account data");


    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());

    Console.Write("Holder: ");
    string holder = Console.ReadLine();

    Console.Write("Initial balance: ");
    double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Withdraw limit: ");
    double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


    Account account = new Account(number, holder, balance, withDrawLimit);


    Console.Write("\nEnter amount for withdraw: ");
    double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    account.WithDraw(withDraw);


    Console.WriteLine(account);
}
catch (DomainExceptions e)
{
    Console.WriteLine("Withdraw erro: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Error: " + e.Message);
}