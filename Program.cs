// test bank program
var name = "Boca Code";
Console.WriteLine($"Welcome to bank {name}!");

BankAccount account = new BankAccount(300);
account.AccountNumber = "12345";

account.MakeDeposit(100);

BankAccount account2 = new SavingsAccount(500);

try {
decimal newBalance = account2.MakeDepositGetBalance(-1);
} catch(Exception ex) {
    Console.WriteLine($"We got an error when running MakeDepositGetBalance(-1)");
}

Console.WriteLine($"The balance of account is {account.Balance}");
Console.WriteLine($"The account number is {account.AccountNumber}");

Console.WriteLine($"The balance of account2 is {account2.Balance}");