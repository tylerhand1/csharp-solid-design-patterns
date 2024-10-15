// Encapsulation

using ConsoleApp.src.OopPrinciples.Encapsulation;

BankAccount bankAccount = new(100);
Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);
Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withdraw(100);
Console.WriteLine(bankAccount.GetBalance());