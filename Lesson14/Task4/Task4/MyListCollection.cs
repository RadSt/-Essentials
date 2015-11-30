using System.Collections;
using System.Collections.Generic;

namespace Task4
{
    public class MyListCollection<T> : IEnumerable<T>
    {
        int position = -1;
        private T[] elementsArray;

        public MyListCollection()
        {
            elementsArray = new T[0];
        }
        public int Count
        {
            get { return elementsArray.Length; }
        }
        T this[int index]
        {
            get { return elementsArray[index]; }
        }
        public void Add(T elem)
        {
            T[] temp = new T[Count + 1];
            for (int i = 0; i < elementsArray.Length; i++)
            {
                temp[i] = elementsArray[i];
            }
            temp[Count] = elem;
            elementsArray = temp;
        }
        public void Reset()
        {
            position = -1;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            while (true)
            {
                if (position < elementsArray.Length - 1)
                {
                    position++;
                    yield return elementsArray[position];

                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }
    }
}