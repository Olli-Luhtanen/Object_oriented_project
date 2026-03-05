using System;

namespace Object_oriented_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new TransactionManager();
            var storage = new JsonStorageManager();

            // Create multiple transactions of each type
            var t1 = new IncomeTransaction(2000m, "Salary", new DateTime(2026, 2, 1));
            var t2 = new IncomeTransaction(150m, "Gift", new DateTime(2026, 2, 15));
            var t3 = new ExpenseTransaction(500m, "Rent", new DateTime(2026, 2, 5));
            var t4 = new ExpenseTransaction(60m, "Groceries", new DateTime(2026, 2, 10));
            var t5 = new TransferTransaction(300m, "Savings", new DateTime(2026, 1, 20));
            var t6 = new ExpenseTransaction(120m, "Utilities", new DateTime(2026, 3, 3));

            manager.AddTransaction(t1);
            manager.AddTransaction(t2);
            manager.AddTransaction(t3);
            manager.AddTransaction(t4);
            manager.AddTransaction(t5);
            manager.AddTransaction(t6);

            Console.WriteLine("Initial manager state:");
            PrintSummary(manager);

            Console.WriteLine("Saving to JSON...");
            storage.Save(manager.Transactions);

            // Load into a fresh manager to verify persistence
            var loadedManager = new TransactionManager();
            var loaded = storage.Load();
            foreach (var tx in loaded)
            {
                loadedManager.AddTransaction(tx);
            }

            Console.WriteLine();
            Console.WriteLine("Loaded manager state:");
            PrintSummary(loadedManager);

            // Test TransactionsByMonth and GetTotalByCategoryAndMonth
            var febTransactions = loadedManager.TransactionsByMonth(2026, 2);
            Console.WriteLine($"Transactions in Feb 2026: {febTransactions.Count}");
            Console.WriteLine($"Total for category 'Rent' in Feb 2026: {loadedManager.GetTotalByCategoryAndMonth("Rent", 2026, 2):C}");

            // Test RemoveTransaction
            var removeId = t4.Id; // remove groceries
            Console.WriteLine($"Removing transaction {removeId}");
            var removed = loadedManager.RemoveTransaction(removeId);
            Console.WriteLine(removed ? "Removed." : "Not found.");

            Console.WriteLine("State after removal:");
            PrintSummary(loadedManager);

            Console.WriteLine("Saving updated manager...");
            storage.Save(loadedManager.Transactions);
        }

        static void PrintSummary(TransactionManager manager)
        {
            Console.WriteLine($"Total income: {manager.GetTotalIncome():C}");
            Console.WriteLine($"Total expenses: {manager.GetTotalExpenses():C}");
            Console.WriteLine($"Balance: {manager.GetBalance():C}");
            Console.WriteLine();

            Console.WriteLine("All transactions (Id | Date | Type | Category | Amount):");
            foreach (var tx in manager.Transactions)
            {
                var typeName = tx.GetType().Name;
                Console.WriteLine($"{tx.Id} | {tx.Date:yyyy-MM-dd} | {typeName} | {tx.Category} | {tx.Amount:C}");
            }
            Console.WriteLine();
        }
    }
}
