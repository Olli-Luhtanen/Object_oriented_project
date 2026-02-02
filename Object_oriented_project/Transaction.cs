using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Object_oriented_project
{
    public class Transaction
    {
        private decimal _amount;
        private string _category;
        private DateTime _date;
        private string _type;

        public decimal Amount
        {
            get {return _amount;}
            set {_amount = value;}
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public Transaction(decimal amount, string category, DateTime date, string type)
        {
            _amount = amount;
            _category = category;
            _date = date;
            _type = type;
        }
    }
}