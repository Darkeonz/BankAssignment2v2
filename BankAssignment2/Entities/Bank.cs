using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssignment2.Entities
{
    public class Bank
    {
        public string name { get; set; }
        public List<Account> account = new List<Account>();
        public Bank()
        {
        }

        public void moveCash(decimal amount, int accountSourceNumber, int accountTargetNumber)
        {        
            // You cannot move to your own account.
            Contract.Requires(accountSourceNumber != accountTargetNumber);     
            Account accountSource = account.Find(x => x.Number.Equals(accountSourceNumber));
            Account accountTarget = account.Find(x => x.Number.Equals(accountTargetNumber));
            decimal TestBalance = accountSource.Balance - amount;
            // can only transfer is balance minus the amount is above zero.
            Contract.Requires(TestBalance > 0, "Balance cannot go below zero");

            accountSource.AddTransaction(amount * -1);
            accountTarget.AddTransaction(amount);
        }

        public string makeStatement(Customer customer, Account account)
        {
            return "";
        }
    }
}
