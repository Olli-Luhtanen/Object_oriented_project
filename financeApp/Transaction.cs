using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Object_oriented_project
{
    public abstract class Transaction
    {
        private decimal _amount = 0;
        private string _category = "Other";
        private DateTime _date = DateTime.Now;
        public Guid Id { get; init; } = Guid.NewGuid();

        public Transaction() { }
        public Transaction(decimal amount, string category, DateTime date)
        {
            Amount = amount;
            Category = category;
            Date = date;
        }
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
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
    }
}