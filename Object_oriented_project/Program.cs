namespace Object_oriented_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var manager = new TransactionManager();

            //StorageManager.LoadJson(manager);

            //Console.WriteLine($"Total income: {manager.GetTotalIncome():C}");
            //Console.WriteLine($"Total expenses: {manager.GetTotalExpenses():C}");
            //Console.WriteLine($"Balance: {manager.GetBalance():C}");
            //Console.WriteLine($"Expenses in Feb 2026: {manager.GetExpensesByMonth(2026, 2):C}");
            //Console.WriteLine();

            //Console.WriteLine("All transactions (Id | Date | Type | Category | Amount):");
            //foreach (var tx in manager.Transactions)
            //{
            //    var typeName = tx.GetType().Name;
            //    Console.WriteLine($"{tx.Id} | {tx.Date:yyyy-MM-dd} | {typeName} | {tx.Category} | {tx.Amount:C}");
            //}

            //Console.WriteLine();
            //Console.Write("Enter the Id of the transaction to delete (or press Enter to skip): ");
            //var input = Console.ReadLine();
            //if (!string.IsNullOrWhiteSpace(input) && Guid.TryParse(input, out var id))
            //{
            //    if (manager.RemoveTransaction(id))
            //    {
            //        Console.WriteLine("Transaction removed.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No transaction found with that Id.");
            //    }
            //}
            //IncomeTransaction salary = new IncomeTransaction 
            //{
            //    Id = Guid.NewGuid(),
            //    Amount = 5000m,
            //    Category = "Salary",
            //    Date = DateTime.Now,
            //};
            //ExpenseTransaction rent = new ExpenseTransaction
            //{
            //    Id = Guid.NewGuid(),
            //    Amount = 1500m,
            //    Category = "Rent",
            //    Date = DateTime.Now,
            //};
            //manager.AddTransaction(rent);
            //manager.AddTransaction(salary);

            //StorageManager.SaveJson(manager.Transactions);
        }
    }
}
