using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class BusinessAcount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAcount (int number, string holder, double balance, double loanlimit) : base (number, holder, balance)
        {
            LoanLimit = loanlimit;
        }

        public void loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
