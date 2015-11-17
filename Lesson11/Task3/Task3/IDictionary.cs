using System.Security.Cryptography.X509Certificates;

namespace Task3
{
    public interface IDictionary<TKey,TValue>
    {
        void Add(TKey key, TValue value);
        TValue this[TKey num] { get; }
        int CountEl();
    }
}