using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

namespace Task3
{
    public class MyDictionary<Tkey, Tvalue> : IEnumerable
    {
        private int position = -1;
        private MyClass<Tkey> key;
        private MyClass<Tvalue> value;

        public MyDictionary()
        {
            key = new MyClass<Tkey>();
            value = new MyClass<Tvalue>();
        }

        public void Add(Tkey tkey, Tvalue tvalue)
        {
            key.Add(tkey);
            value.Add(tvalue);
        }

        public string this[int index]
        {
            get { return key[index] + " " + value[index]; }
        }

        public string this[Tkey index]
        {
            get
            {
                for (int i = 0; i < key.Count; i++)
                {
                    if ((string) (object) key[i] == (string) (object) index)
                    {
                        return "По ключу " + key[i] + "Найдено значение" + value[i];
                    }
                }
                return "Значение не найдено";
            }
        }

        public int Count
        {
            get { return key.Count; }
        }

        public void Reset()
        {
            position = -1;
        }

        public IEnumerator GetEnumerator()
        {
            while (true)
            {
                if (position < key.Count - 1)
                {
                    position++;
                    yield return key[position] + " " + value[position];
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