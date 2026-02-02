using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Object_oriented_project
{
    public class TransactionManager
    {
        List<Transaction> transactions = new List<Transaction>();
        public void addTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
        }
        public void removeTransaction(Transaction transaction)
        {
            transactions.Remove(transaction);
        }
        public decimal getTotalExpenses()
        {
            decimal expenseAmount = 0;

            foreach (Transaction transaction in transactions)
            {
                if (transaction.Type == "Expense")
                {
                    expenseAmount += transaction.Amount;
                }
            }
            return expenseAmount;
        }

        public decimal getTotalIncome()
        {
            decimal incomeAmount = 0;

            foreach (Transaction transaction in transactions)
            {
                if (transaction.Type == "Income")
                {
                    incomeAmount += transaction.Amount;
                }
            }
            return incomeAmount;
        }

        public List<Transaction> TransactionsByMonth(int year, int month)
        {
            List<Transaction> monthlyTransactions = new List<Transaction>();
            
            foreach (Transaction transaction in transactions)
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