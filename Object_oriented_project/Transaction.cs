using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Object_oriented_project
{
    public enum TransactionType
    {
        Unknown = 0,
        Income,
        Expense,
        Transfer
    }

    public class Transaction
    {
        private decimal _amount = 0;
        private string _category = "Other";
        private DateTime _date = DateTime.Now;
        private TransactionType _type = TransactionType.Unknown;

        public decimal Amount
        {
            get {return _amount;}
            set
            {
                if (value >= 0)
                {
                    _amount = value;
                }
                else
                {
                    _amount = 0;
                }
            }
        }

        public string Category
        {
            get { return _category; }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _category = value;
                }
                else
                {
                    _category = "Other";
                }
            }
        }

        public TransactionType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
    }
}