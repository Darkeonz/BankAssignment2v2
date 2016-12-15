using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssignment2.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public decimal Balance { get; set; }
        List<Movement> MovementList = new List<Movement>();
        public Account(decimal amount)
        {
            generateMovement(amount);
            CalculateBalance();
        }

        public Account()
        {

        }

        public void AddTransaction(decimal amount)
        {
            generateMovement(amount);
            CalculateBalance();
        }

        private void generateMovement(decimal amount)
        {
            DateTime localDate = DateTime.Now;
            Movement movement = new Movement();
            movement.amount = amount;
            movement.date = localDate;
            MovementList.Add(movement);
        }

        private void CalculateBalance()
        {
            decimal TempBalance = 0;
            foreach (Movement Movement in MovementList)
            {
                TempBalance = TempBalance + Movement.amount;
            }
            Balance = TempBalance;
        }
    }
}
