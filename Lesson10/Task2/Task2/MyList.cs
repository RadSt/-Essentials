using System;
using System.Diagnostics;

namespace Task2
{
    public class MyList <T>:IMyLIst<T>
    {
        T[] array;
        private int numberOfElements;

        public MyList()
        {
            array=new T[0];
        } 
        public int NumberOfElements { get;}
        public void Add(T elem)
        {
            T[] tempArray=new T[array.Length+1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[array.Length] = elem;
            array = tempArray;
        }

        public T this[int index]
        {
            get { return array[index]; } 
        }

        public int Count
        {
            get { return array.Length; }
        }
        public void Clear()
        {
            array=new T[0];
        }
        public bool Contains(T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((int)(object)array[i] == (int)(object)item)
                {
                    return true;
                }
            }
            return false;
        }

    }
}