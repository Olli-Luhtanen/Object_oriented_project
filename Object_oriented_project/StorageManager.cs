using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text.Json;

namespace Object_oriented_project
{
    public class StorageManager
    {
        public static void SaveJson(IReadOnlyList<Transaction> transactions)
        {
            FileStream fileStream = new FileStream("transactions.json", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                JsonSerializer.Serialize(fileStream, transactions);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in saving! " + e.Message);
            }
            finally
            {
                fileStream.Close();
            }
        }
        public static void LoadJson(TransactionManager manager)
        {
            FileStream fileStream = new FileStream("transactions.json", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
            try
            {
                var transactions = JsonSerializer.Deserialize<List<Transaction>>(fileStream);
                if (transactions is not null)
                {
                    foreach (var transaction in transactions)
                    {
                        manager.AddTransaction(transaction);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in loading! " + e.Message);
            }
            finally
            {
                fileStream.Close();
            }
        }
    }
}