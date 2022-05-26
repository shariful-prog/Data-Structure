using System;

namespace DS_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var a = new NodeCL(2);
            var b = new NodeCL(3);
            var c = new NodeCL(5);
            var d = new NodeCL(12);
            a.next = b;
            b.next = c;
            c.next = d;
            d.next = null;

            ListOperation listOperation = new ListOperation();
            listOperation.printList(a);
            Console.WriteLine("total sum = " + listOperation.sum(a));

            Console.WriteLine(listOperation.FindValue(a,1));
            Console.WriteLine(listOperation.FindPosition(a,0));


        }
    }
}
