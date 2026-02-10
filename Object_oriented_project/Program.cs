namespace Object_oriented_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new TransactionManager();
            var storage = new StorageManager();

            StorageManager.LoadJson(manager);

            Transaction t1 = new Transaction(1500m, "Salary", TransactionType.Income, DateTime.Now);

            Console.WriteLine($"Total income: {manager.GetTotalIncome():C}");
            Console.WriteLine($"Total expenses: {manager.GetTotalExpenses():C}");
            Console.WriteLine($"Balance: {manager.GetBalance():C}");
            Console.WriteLine($"Expenses in Feb 2026: {manager.GetExpensesByMonth(2026, 2):C}");
            Console.WriteLine();

            Console.WriteLine("All transactions:");
            foreach (var tx in manager.Transactions)
            {
                Console.WriteLine($"{tx.Date:yyyy-MM-dd} | {tx.Type} | {tx.Category} | {tx.Amount:C}");
            }

            StorageManager.SaveJson(manager.Transactions);
        }
    }
}
