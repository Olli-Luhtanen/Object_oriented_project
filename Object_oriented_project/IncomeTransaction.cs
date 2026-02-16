using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Object_oriented_project
{
    public class IncomeTransaction : Transaction
    {
        public IncomeTransaction() : base() { }

        public IncomeTransaction(decimal amount, string category, DateTime date)
            : base(amount, category, date)
        {
        }
    }
}