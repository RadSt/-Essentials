using System.Runtime.CompilerServices;

namespace Task3
{
    public interface IMyClass<T>
    {
        void Add(T elem);
        T this[int index] { get; }
        int Count { get; }
    }
    public class MyClass <T>:IMyClass<T>
    {
        T[] array;

        public MyClass()
        {
            array=new T[0];
        }

        public int Count { get { return array.Length; } }

        public void Add(T elem)
        {
            T[] tempArray=new T[Count+1];
            for (int i = 0; i < Count; i++)
            {
                tempArray[i]=array[i];
            }
            tempArray[Count] = elem;
            array = tempArray;
        }

        public T this[int index]
        {
            get { return array[index]; }
        }
    }
}