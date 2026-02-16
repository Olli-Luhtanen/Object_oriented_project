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

                var dtos = transactions.Select(tx => new TransactionDto
                {
                    Id = tx.Id,
                    Amount = tx.Amount,
                    Category = tx.Category,
                    Date = tx.Date,
                    Kind = tx.GetType().Name
                }).ToList();

                var json = JsonSerializer.Serialize(dtos, options);
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

                var dtos = JsonSerializer.Deserialize<List<TransactionDto>>(json, options);
                if (dtos is not null)
                {
                    foreach (var dto in dtos)
                    {
                        Transaction? transaction = null;
                        var kind = dto.Kind ?? string.Empty;
                        switch (kind.ToLowerInvariant())
                        {
                            case "incometransaction":
                                transaction = new IncomeTransaction(dto.Amount, dto.Category, dto.Date) { Id = dto.Id };
                                break;
                            case "expensetransaction":
                                transaction = new ExpenseTransaction(dto.Amount, dto.Category, dto.Date) { Id = dto.Id };
                                break;
                            case "transfertransaction":
                                transaction = new TransferTransaction(dto.Amount, dto.Category, dto.Date) { Id = dto.Id };
                                break;
                            default:
                                // Unknown kind — skip and log
                                Console.WriteLine($"Skipping unknown transaction kind '{dto.Kind}' for Id {dto.Id}");
                                break;
                        }

                        if (transaction is not null)
                        {
                            manager.AddTransaction(transaction);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in loading! " + e.Message);
            }
        }

        private class TransactionDto
        {
            public Guid Id { get; set; }
            public decimal Amount { get; set; }
            public string Category { get; set; } = "Other";
            public DateTime Date { get; set; }
            public string? Kind { get; set; }
        }
    }
}