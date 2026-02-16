using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Object_oriented_project
{
    public class TransactionManager
    {
        private List<Transaction> _transactions = new List<Transaction>();
        public IReadOnlyList<Transaction> Transactions => _transactions.AsReadOnly();

        public void AddTransaction(Transaction transaction)
        {
            if (transaction is null) 
                throw new ArgumentNullException(nameof(transaction));
            
            else
                _transactions.Add(transaction);
        }
        public bool RemoveTransaction(Guid id)
        {
            var t = _transactions.FirstOrDefault(x => x.Id == id);
            if (t is null) return false;
            _transactions.Remove(t);
            return true;
        }
        public decimal GetExpensesByMonth(int year, int month)
        {
            decimal expenseAmount = 0;
            foreach (Transaction transaction in _transactions)
            {
                if (transaction.Type == TransactionType.Expense &&
                    transaction.Date.Year == year && transaction.Date.Month == month)
                {
                    expenseAmount += transaction.Amount;
                }
            }
            return expenseAmount;
        }
        public decimal GetTotalExpenses()
        {
            decimal expenseAmount = 0;

            foreach (Transaction transaction in _transactions)
            {
                if (transaction.Type == TransactionType.Expense)
                {
                    expenseAmount += transaction.Amount;
                }
            }
            return expenseAmount;
        }
        public decimal GetIncomeByMonth(int year, int month)
        {
            decimal incomeAmount = 0;
            foreach (Transaction transaction in _transactions)
            {
                if (transaction.Type == TransactionType.Income &&
                    transaction.Date.Year == year && transaction.Date.Month == month)
                {
                    incomeAmount += transaction.Amount;
                }
            }
            return incomeAmount;
        }
        public decimal GetTotalIncome()
        {
            decimal incomeAmount = 0;

            foreach (Transaction transaction in _transactions)
            {
                if (transaction.Type == TransactionType.Income)
                {
                    incomeAmount += transaction.Amount;
                }
            }
            return incomeAmount;
        }
        public decimal GetTotalByCategory(string category)
        {
            decimal totalAmount = 0;
            foreach (Transaction transaction in _transactions)
            {
                if (transaction.Category == category)
                {
                    totalAmount += transaction.Amount;
                }
            }
            return totalAmount;
        }
        public decimal GetBalance()
        {
            return GetTotalIncome() - GetTotalExpenses();
        }

        public List<Transaction> TransactionsByMonth(int year, int month)
        {
            List<Transaction> monthlyTransactions = new List<Transaction>();
            
            foreach (Transaction transaction in _transactions)
            {
                if (transaction.Date.Year == year && transaction.Date.Month == month)
                {
                    monthlyTransactions.Add(transaction);
                }
            }

            return monthlyTransactions;
        }
    }
}