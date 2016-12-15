using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {         
        static void Main(string[] args)
        {
            
            BankAssignment2.Entities.Customer customer1 = new BankAssignment2.Entities.Customer();
            BankAssignment2.Entities.Customer customer2 = new BankAssignment2.Entities.Customer();
            BankAssignment2.Entities.Bank bank = new BankAssignment2.Entities.Bank();
            

            
            customer1.Id = 1;
            customer2.Id = 2;
            customer1.name = "hans";
            customer2.name = "nisse";
            customer1.account = new BankAssignment2.Entities.Account(10000);
            customer2.account = new BankAssignment2.Entities.Account();
            customer1.account.Number = 10;
            customer2.account.Number = 11;
            bank.account.Add(customer1.account);
            bank.account.Add(customer2.account);

            bank.moveCash(-100, customer1.account.Number, customer2.account.Number);
            bank.moveCash(500, customer1.account.Number, customer2.account.Number);
            bank.moveCash(50000, customer1.account.Number, customer2.account.Number);


            Console.Write(customer1.account.Balance + " ");           
            Console.Write(customer2.account.Balance);
            Console.ReadLine();
        }
    }
}
