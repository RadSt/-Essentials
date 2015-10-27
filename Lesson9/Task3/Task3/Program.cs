using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public delegate int MyDelegateRand();

        public delegate double MyDelegateAvg(MyDelegateRand[] myDelegateRand);

        static int GetRandom()
        {
            return new Random().Next(100);
        }
        static void Main(string[] args)
        {
            MyDelegateRand[] myDelegateArray=new MyDelegateRand[10];

            for (int i = 0; i < myDelegateArray.Length; i++)
            {
                myDelegateArray[i] = () => new MyDelegateRand(GetRandom).Invoke();
            }


            MyDelegateAvg myDelegateAvg = delegate(MyDelegateRand[] delegateArray)
            {
                double sr = 0;
                for (int i = 0; i < delegateArray.Length; i++)
                {
                    sr += delegateArray[i].Invoke();
                }
                return sr/delegateArray.Length;
            };

            for (int i = 0; i < myDelegateArray.Length; i++)
            {
                Console.WriteLine(myDelegateArray[i].Invoke()+" ");
            }

            Console.WriteLine("Среднее арифметическое {0}",myDelegateAvg(myDelegateArray));

            Console.ReadKey();

        }
    }
}
