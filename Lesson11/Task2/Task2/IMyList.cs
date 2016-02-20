using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Task2
{
    public interface IMyList<T>
    {
        void Add(T entity);
        T this [int index] { get; }
        int Count { get; }
        void Clear();

    }
}