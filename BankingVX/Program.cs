using BankingVX.Models.Domain;
using System;

namespace BankingVX
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount("123-4567890-12");
            Console.WriteLine($"AccountNumber: {myAccount.AccountNumber}");
            Console.WriteLine($"Balance: {myAccount.Balance}");
            myAccount.Deposit(200M);
            Console.WriteLine($"Balance after deposit of 200 euros: {myAccount.Balance}");
            myAccount.Withdraw(100M);
            Console.WriteLine($"Balance after deposit of 200 euros: {myAccount.Balance}");
            Console.WriteLine();
        }
    }
}
