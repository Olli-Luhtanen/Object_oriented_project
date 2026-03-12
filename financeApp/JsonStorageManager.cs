using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace financeApp
{
    public class JsonStorageManager : IStorageManager
    {
        private readonly string _filePath;

        public JsonStorageManager(string filePath = "transactions.json")
        {
            _filePath = filePath;
        }

        public IReadOnlyList<Transaction> Load()
        {
            var result = new List<Transaction>();

            try
            {
                if (!File.Exists(_filePath)) return result;

                var json = File.ReadAllText(_filePath);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                options.Converters.Add(new JsonStringEnumConverter());

                var dtos = JsonSerializer.Deserialize<List<TransactionDto>>(json, options);
                if (dtos is not null)
                {
                    foreach (var dto in dtos)
                    {
                        Transaction? transaction = null;
                        switch (dto.Kind)
                        {
                            case TransactionKind.Income:
                                transaction = new IncomeTransaction(dto.Amount, dto.Category, dto.Date) { Id = dto.Id };
                                break;
                            case TransactionKind.Expense:
                                transaction = new ExpenseTransaction(dto.Amount, dto.Category, dto.Date) { Id = dto.Id };
                                break;
                            case TransactionKind.Transfer:
                                transaction = new TransferTransaction(dto.Amount, dto.Category, dto.Date) { Id = dto.Id };
                                break;
                            default:
                                // unknown enum value
                                Console.WriteLine($"Skipping unknown transaction kind '{dto.Kind}' for Id {dto.Id}");
                                break;
                        }

                        if (transaction is not null)
                        {
                            result.Add(transaction);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in loading! " + e.Message);
            }

            return result;
        }

        public void Save(IReadOnlyList<Transaction> transactions)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                options.Converters.Add(new JsonStringEnumConverter());

                var dtos = transactions.Select(tx => new TransactionDto
                {
                    Id = tx.Id,
                    Amount = tx.Amount,
                    Category = tx.Category,
                    Date = tx.Date,
                    Kind = tx switch
                    {
                        IncomeTransaction => TransactionKind.Income,
                        ExpenseTransaction => TransactionKind.Expense,
                        TransferTransaction => TransactionKind.Transfer,
                        _ => TransactionKind.Expense
                    }
                }).ToList();

                var json = JsonSerializer.Serialize(dtos, options);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in saving! " + e.Message);
            }
        }

        private class TransactionDto
        {
            public Guid Id { get; set; }
            public decimal Amount { get; set; }
            public string Category { get; set; } = "Other";
            public DateTime Date { get; set; }
            public TransactionKind Kind { get; set; }
        }
    }
}
