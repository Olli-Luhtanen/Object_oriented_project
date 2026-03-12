using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace financeApp
{
    public class TransferTransaction : Transaction
    {
        public TransferTransaction() : base() { }

        public TransferTransaction(decimal amount, string category, DateTime date)
            : base(amount, category, date)
        {
        }
    }
}