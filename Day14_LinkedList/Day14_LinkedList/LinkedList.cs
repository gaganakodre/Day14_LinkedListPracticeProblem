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
        public void AddNode(int value)//add front
        {
            Node node = new Node(value);
            //Check wheather the list is empty then creates node as head
            if (Head == null & Tail == null)
            {
                Head = node;//both head and gaile refered to same node now
                Tail = node;
            }
            else
            {
                ////If node than add new node as head 
                node.next = Head;//add at first
                Head = node;
            }
            Console.WriteLine($" Added {value} at start of the linkedlist");
        }
        public void AppendNode(int value)//is also same code for addlast() method

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
        public void InsertNode(int value, int Previousvalue)
        {
            Node newNode = new Node(value);//40 node we have to create
            if (Head == null & Tail == null)
            {
                Head = newNode;
            }
            else
            {
                Node temp = Head;
                //Checking until temp variable data equal to the previous value of value to be added
                while (temp.data != Previousvalue)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;
            }
        }
        public void DeleteNodeAtFirst()
        {
            if (Head == null & Tail == null)
            {
                Console.WriteLine("Nothing to delete list is empty");
            }
            Node temp = Head;
            //Change head to next node to delete the previous node
            Head = Head.next;//assign head refence to the next 

            Console.WriteLine("Removed from linkedlist :" + temp.data);
        }
        public void DeleteNodeAtLast()
        {

            if (Head == null & Tail == null)
            {
                Console.WriteLine("Nothing to delete list is empty");

            }

            Node temp = Head;
            //Check until the temp next nodes's next loction is null
            while (temp.next.next != null)//we have to find the second last node
            {

                temp = temp.next;
            }
            //After getting this node change its location to null
            temp.next = null;
        }
        public bool Search(int value)
        {
            //Temp variable is head now
            Node temp = Head;
            //Check until temp location will null
            while (temp != null)
            {
                //If temp node data is equal to value to be searched
                if (temp.data == value)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }


        public int getCount()
        {
            Node temp = Head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
            
        }
        public void deleteNode(int key)
        {
            // Store head node
            Node temp = Head, prev = null;

            // If head node itself holds
            // the key to be deleted
            if (temp != null &&
                temp.data == key)//here head.data refers to head and 5
            {
                // Changed head
                Head = temp.next;
                return;
            }

            // Search for the key to be
            // deleted, keep track of the
            // previous node as we need
            // to change temp.next
            while (temp != null &&
                   temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }

            // If key was not present
            // in linked list
            if (temp == null)
                return;

            // Unlink the node from linked list
            prev.next = temp.next;
        }
       
       

        internal void Display()
        {
            //temp variable will head
            Node temp = Head;//refernce type
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
        public void sort()
        {
            Node i, j;
            int temp;
            for (i = this.Head; i.next != null; i = i.next)
            {
                for (j = i.next; j != null; j = j.next)
                {
                    if (i.data > j.data)
                    {
                        temp = i.data;
                        i.data = j.data;
                        j.data = temp;
                    }
                }
            }
        }
    }
}
