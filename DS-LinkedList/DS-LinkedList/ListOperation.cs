using System;
using System.Collections.Generic;
using System.Text;

namespace DS_LinkedList
{
    public class ListOperation
    {

        public void printList(NodeCL curr)
        {
            var current = curr;
            if (current == null) return;
            Console.WriteLine(current.value);
            printList(current.next);

        }


        public int sum(NodeCL curr)
        {
            var current = curr;
            int sum = 0;
            while (current != null)
            {
                sum = sum + current.value;
                current = current.next;
            }

            return sum;

        }

       public bool FindValue(NodeCL curr,int target)
        {
            var current = curr;
            while(current != null)
            {
                if(current.value == target) return true;

                current = current.next;

            }
            return false;
        }

        public int FindPosition(NodeCL curr, int index)
        {
            var current = curr;
            int count = 0;
            while (current != null)
            {
                if (count == index) return current.value;

                current = current.next;
                count++;

            }
            return -1;
        }



    }
}
