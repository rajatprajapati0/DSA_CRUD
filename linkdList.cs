using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace DSA_CRUD
{
    internal class linkdList
    {
        private Node head;
        public void add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;               
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }

        }
        public void addRe(int data)
        {
            Node node = new Node(data);
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
                Node temp = head;
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
