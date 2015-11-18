using System.Runtime.InteropServices.ComTypes;

namespace Task4
{
    public interface IArrayList
    {
        void Add(object a);
        object this[int index] { get; }
        int Count { get; }
        void Clear();
        bool Contains(object item);


    }
    public class ArrayList:IArrayList
    {
        object[] array;
        private object _o;

        public ArrayList()
        {
            array=new object[0];
        }

        public void Add(object a)
        {
            var temp=new object[array.Length+1];
            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = array[i];
            }
            temp[array.Length] = a;
            array = temp;
        }

        public object this[int index]
        {
            get { return array[index]; }
        }

        public int Count
        {
            get { return array.Length; }
        }

        public void Clear()
        {
            array=new object[0];
        }

        public bool Contains(object item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (Equals(array[i],item))
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string str = null;
            for (int i = 0; i < array.Length; i++)
            {
                str += array[i] + "\n";
            }
            return str ?? "В массиве нет элементов";
        }
    }
}