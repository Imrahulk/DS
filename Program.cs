using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    class Program
    {

        class LinkedListNode
        {
            public int data;
            public LinkedListNode next;
            public LinkedListNode(int x)
            {
                data = x;
                next = null;
            }
        }

        class LinkedList
        {
            LinkedListNode head;
            int count;  
            public LinkedList()
            {
                head = null;
                count = 0;
            }
            public void AddNodeToFront(int data)
            {
                LinkedListNode node = new LinkedListNode(data);
                node.next = head;
                head = node;
                count++;
            }

            public void PrintList()
            {
                LinkedListNode runner = head;
                while(runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next;
                }
            }
        }


        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            l.AddNodeToFront(1);
            l.AddNodeToFront(2);
            l.AddNodeToFront(3);
            l.AddNodeToFront(4);
            l.AddNodeToFront(5);
            l.AddNodeToFront(6);
            l.AddNodeToFront(7);
            l.PrintList();
            Console.ReadLine();
        }
    }
}
