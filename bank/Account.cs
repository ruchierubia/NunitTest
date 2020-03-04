using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Account
    {
        private float balance;
        private float minBalance = 10;
        public Account()
        {

        }

        public Account(int value)
        {
            balance = value;
        }

        public void Deposit(float amount)
        {
            balance += amount;
        }

        public void Withraw(float amount)
        {
            balance -= amount;
        }

        public Account TransferMinFunds(Account distination, float amount)
        {
            if (Balance - amount > MinBalance)
            {
                distination.Deposit(amount);
                Withraw(amount);
            }
            else
            {
                throw new NotEnoughFundsException();
            }
            return distination;
        }

        public void TransferFunds(Account  destination, float amount)
        {
            destination.Deposit(amount);
            Withraw(amount);
        }



        public float Balance
        {
            get { return balance; }
        }

        public float MinBalance
        {
            get { return minBalance; }
        }


    }
}
