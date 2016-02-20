using System.Runtime.CompilerServices;

namespace Task3
{
    public interface IMyDictionary<Tkey, Tvalue>
    {
        void Add(int i,Tkey key, Tvalue value);
        string this[int index] { get; }
        int Length { get; }
    }
}