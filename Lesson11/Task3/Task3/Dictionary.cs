using System.Runtime.CompilerServices;

namespace Task3
{
    public class Dictionary<TKey,TValue>
    {
        readonly MyList<TKey> key;
        readonly MyList<TValue> val;

        public Dictionary()
        {
            key=new MyList<TKey>();
            val=new MyList<TValue>();
        }

        public void Add(TKey keyEl,TValue valueEl)
        {
            key.Add(keyEl);
            val.Add(valueEl);
        }

        public string this[int index]
        {
            get { return key[index]+" "+val[index]; }
        }

        public string this[TKey index]
        {
            get
            {
                for (int i = 0; i < key.CountEl; i++)
                {
                    if ((string)(object)key[i]== (string)(object)index)
                    {
                        return val[i].ToString();
                    }
                }
                return "Искомый элемент не найден";
            }
        }

        public int Length
        {
            get{ return val.CountEl;}
        }

        public override string ToString()
        {
            string stroka = null;
            for (int i = 0; i < key.CountEl; i++)
            {
                stroka += key[i] + " " + val[i] + "\n";
            }
            return stroka ?? "В словаре элементы оссутствуют";
        }
    }
}