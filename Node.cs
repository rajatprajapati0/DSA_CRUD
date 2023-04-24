using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_CRUD
{
    internal class Node<T> where T : IComparable
    {
        public Node<T> next;
        public T data;
        public Node(T data)
        {
            this.data = data;

        }
    }
}
