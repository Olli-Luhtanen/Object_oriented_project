using System.Collections.Generic;

namespace Object_oriented_project
{
    // Storage manager interface to allow multiple storage implementations (JSON, XML, etc.)
    public interface IStorageManager
    {
        IReadOnlyList<Transaction> Load();
        void Save(IReadOnlyList<Transaction> transactions);
    }
}
