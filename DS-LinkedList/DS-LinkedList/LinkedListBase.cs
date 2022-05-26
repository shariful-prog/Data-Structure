using System;
using System.Collections.Generic;
using System.Text;

namespace DS_LinkedList
{
    public class LinkedListBase
    {
        public Node first;
        public LinkedListBase()
        {
            first = null;
        }

        public void AddNode(int n)
        {
            Node node = new Node();
            node.num = n;
            node.next = first;
            first = node;
        }


        public void PrintList()
        {
           var current = first;




        }
    }
}
