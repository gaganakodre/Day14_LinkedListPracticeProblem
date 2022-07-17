using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_LinkedList
{
    public class CreateList
    {
        //Represent a node of` the singly linked list  
        public class Node<T>
        {
            public T data;
            public Node<T> next;

            public Node(T value)
            {
                data = value;
                next = null;
            }
        }

        public class SortList<T> where T : IComparable<T>
        {
            //Represent the head and tail of the singly linked list  
            public Node<T> head = null;
            public Node<T> tail = null;

            //addNode() will add a new node to the list  
            public void addNode(T data)
            {
                //Create a new node  
                Node<T> newNode = new Node<T>(data);

                //Checks if the list is empty  
                if (head == null)
                {
                    //If list is empty, both head and tail will point to new node  
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    //newNode will be added after tail such that tail's next will point to newNode  
                    tail.next = newNode;
                    //newNode will become new tail of the list  
                    tail = newNode;
                }
            }

            //sortList() will sort nodes of the list in ascending order  
            public void sortList()
            {
                //Node current will point to head  
                Node<T> current = head, index = null;
                T temp;

                if (head == null)
                {
                    return;
                }
                else
                {
                    while (current != null)
                    {
                        //Node index will point to node next to current  
                        index = current.next;//set to head to comapre with index

                        while (index != null)
                        {
                            //If current node's data is greater than index's node data, swap the data between them  
                            if (current.data.CompareTo(index.data) > 0)//if 1 greater, 0 equal,-1 left shift
                            {
                                temp = current.data;//swaping
                                current.data = index.data;
                                index.data = temp;
                            }
                            index = index.next;
                        }
                        current = current.next;
                    }
                }
            }

            //display() will display all the nodes present in the list  
            public void display()
            {
                //Node current will point to head  
                Node<T> current = head;
                if (head == null)
                {
                    Console.WriteLine("List is empty");
                    return;
                }
                while (current != null)
                {
                    //Prints each node by incrementing pointer  
                    Console.Write(current.data + " ");
                    current = current.next;
                }
                Console.WriteLine();
            }
        }

        //public static void Main()
        //{
        //    SortList<int> sList = new SortList<int>();

        //    //Adds data to the list  
        //    sList.addNode(9);
        //    sList.addNode(7);
        //    sList.addNode(2);
        //    sList.addNode(5);
        //    sList.addNode(4);

        //    //Displaying original list  
        //    Console.WriteLine("Original list: ");
        //    sList.display();

        //    //Sorting list  
        //    sList.sortList();

        //    //Displaying sorted list  
        //    Console.WriteLine("Sorted list: ");
        //    sList.display();
        //}
    }
}
