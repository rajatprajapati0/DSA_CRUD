using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace DSA_CRUD
{
    internal class linkdList<T> where T : IComparable
    {
        private Node<T> head;
        public void add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }

        }
        public void addRe(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;

            }
            else
            {
                node.next = head;
                head = node;
            }
        }
        public string Display()
        {
            if (head == null)
            {
                return null;
            }
            else
            {
                Node<T> temp = head;
                string s = "";
                while (temp != null)
                {
                    s = s + temp.data + " ";
                    temp = temp.next;
                }
                return s;
            }
        }
    }
}
