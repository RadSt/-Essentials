using System;

namespace Task3
{
    public class MyDictionary <Tkey,Tvalue>:IMyDictionary<Tkey, Tvalue>
    {
        private Tkey[] key;
        private Tvalue[] value;
        private int lenght;

        public MyDictionary(int n)
        {
            key=new Tkey[n];
            value=new Tvalue[n];
            lenght = n;
        }
        public int Length { get { return lenght; } }
        public void Add(int i, Tkey key, Tvalue value)
        {
            this.key[i] = key;
            this.value[i] = value;
        }

        public string this[int index]
        {
            get
            {
                if(index>0 && index<=key.Length)
                    return key[index]+" "+value[index];
                return "Попытка обращения за пределы массива";
            }

        }


    }
}