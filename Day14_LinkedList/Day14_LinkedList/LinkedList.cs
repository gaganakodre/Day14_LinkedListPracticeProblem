using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_LinkedList
{
    public class LinkedLists
    {
        public Node Head;
        public Node Tail;

        public LinkedLists()
        {
            Head = null;
            Tail = null;
        }

        internal void Display()
        {

            Node temp = Head;
            if (temp == null)
                Console.WriteLine("Linked list is empty");
            else
                Console.WriteLine("Linked List:");
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                    Console.Write(" -> ");
                temp = temp.next;
            }
        }
    }
}
