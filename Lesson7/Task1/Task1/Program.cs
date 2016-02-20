using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Notebook notebook=new Notebook("SGR53647","Sony",235000);
            notebook.ShowNotebookInfo();

            Notebook notebook2=new Notebook("hgafgagf","Acer");
            notebook2.ShowNotebookInfo();

            Notebook notebook3=new Notebook("sfsefesf");
            notebook3.ShowNotebookInfo();

            Console.ReadKey();
        }
    }
}
