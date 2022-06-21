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
        public void AddNode(int value)
        {
            Node node = new Node(value);
            //Check wheather the list is empty then creates node as head
            if (Head == null & Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                ////If node than add new node as head 
                node.next = Head;
                Head = node;
            }
            Console.WriteLine($" Added {value} at start of the linkedlist");
        }
        public void AppendNode(int value)
        {
            Node node = new Node(value);
            //Check wheather the list is empty then creates node as head
            if (Head == null & Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Node temp = Head;
                ////If node than add new node as head 
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine($"Added {value} at start of the linkedlist");
        }
        internal void Display()
        {
            //temp variable will head
            Node temp = Head;
            //Check wheather list is empty or not 
            if (temp == null)
                Console.WriteLine("Linked list is empty");
            else
                Console.WriteLine("Linked List:");
            while (temp != null)
            {
                //Check until temp will null
                Console.Write(temp.data);
                if (temp.next != null)
                    Console.Write(" -> ");
                //for traversing the node
                temp = temp.next;
            }

        }
    }
}
