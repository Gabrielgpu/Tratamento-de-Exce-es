using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using exercicio_8.Entities.Exceptions;

namespace exercicio_8.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }


        public Account()
        {
            
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (Balance < amount)
            {
                throw new DomainExceptions("Not enough balance");
            }
            else if (amount > WithDrawLimit)
            {
                throw new DomainExceptions("The amount exceeds withdraw limit");
            }
            
            Balance -= amount;
        }


        public override string ToString()
        {
            return $"New Balance: {Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}