namespace Task2
{
    public interface IMyLIst<T>
    {
        void Add(T elem);
        T this [int index] { get; }
        int Count { get; }
        void Clear();
        bool Contains(T item);
    }
}