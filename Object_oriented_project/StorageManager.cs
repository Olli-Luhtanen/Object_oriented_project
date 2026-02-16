using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text.Json;

namespace Object_oriented_project
{
    public class StorageManager
    {
        private const string FilePath = "transactions.json";

        public static void SaveJson(IReadOnlyList<Transaction> transactions)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                var json = JsonSerializer.Serialize(transactions, options);
                File.WriteAllText(FilePath, json);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in saving! " + e.Message);
            }
        }

        public static void LoadJson(TransactionManager manager)
        {
            try
            {
                if (!File.Exists(FilePath)) return;

                var json = File.ReadAllText(FilePath);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                var transactions = JsonSerializer.Deserialize<List<Transaction>>(json, options);
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
        }
    }
}