using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace financeApp
{
    public class ExpenseTransaction : Transaction
    {
        public ExpenseTransaction() : base() { }

        public ExpenseTransaction(decimal amount, string category, DateTime date)
            : base(amount, category, date)
        {
        }
    }
}