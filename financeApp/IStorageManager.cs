using System.Collections.Generic;

namespace financeApp
{
    // Storage manager interface to allow multiple storage implementations (JSON, XML, etc.)
    public interface IStorageManager
    {
        IReadOnlyList<Transaction> Load();
        void Save(IReadOnlyList<Transaction> transactions);
    }
}
