using System;
using System.Collections;

namespace DSA_CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            linkdList linkdList = new linkdList();

            Console.WriteLine("linkdList CRUD opretion");
            linkdList.add(2);
            linkdList.add(4);
            linkdList.add(6);
            linkdList.add(8);
            Console.WriteLine(linkdList.Display());

            
        }
    }
}
