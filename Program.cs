using System;
using System.Collections;

namespace DSA_CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            linkdList<string> linkdList = new linkdList<string>();
            linkdList<int> linkdList1 = new linkdList<int>();


            Console.WriteLine("Hello World!");
            linkdList.add("r");
            linkdList.add("a");
            linkdList.add("j");
            linkdList.add("a t");
            Console.WriteLine(linkdList.Display());
            linkdList1.add(2);
            linkdList1.add(4);
            linkdList1.add(6);
            linkdList1.add(8);
            Console.WriteLine(linkdList1.Display());


        }
    }
}
