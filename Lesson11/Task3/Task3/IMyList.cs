using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Task3
{
    public interface IMyList<T>
    {
        void Add(T elem);
        T this[int index] { get; }
        int CountEl { get; }
        void Clear();
    }

    public class MyList<T>:IMyList<T>
    {
        T [] array;
        public MyList()
        {
            array = new T[0];
        }

        public void Add(T elem)
        {
           T[] temp =new T[array.Length+1];
            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = array[i];
            }
            temp[array.Length] = elem;
            array = temp;
        }

        public T this[int index]
        {
            get { return array[index]; }
        }

        public int CountEl
        {
            get{ return array.Length;}
        }

        public void Clear()
        {
            array = new T[0];
        }
    }
}