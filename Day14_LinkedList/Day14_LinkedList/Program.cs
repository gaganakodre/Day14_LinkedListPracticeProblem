namespace Day14_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedLists linkedLists = new LinkedLists();

            ////UC-1
            //Node node1 = new Node(56);
            //Node node2 = new Node(30);
            //Node node3 = new Node(70);
            //node1.next = node2;
            //node2.next = node3;
            //linkedLists.Head = node1;
            //linkedLists.Display();
            //Console.WriteLine("*************uc1 o/p:Linked List:56-> 30-> 70*************************");
            ////uc1 o/p:Linked List:56-> 30-> 70
            ////uc2
            //linkedLists.AddNode(70);
            //linkedLists.AddNode(30);
            //linkedLists.AddNode(56);
            //linkedLists.Display();
            //Console.WriteLine("*****************  Added 70 at start of the linkedlist " +
            //    "Added 30 at start of the linkedlist " +
            //    "Added 56 at start of the linkedlist " +
            //    "Linked List:56-> 30-> 70->* ********************");
            ////UC-3
            //linkedLists.AppendNode(56);
            //linkedLists.AppendNode(30);
            //linkedLists.AppendNode(70);
            //linkedLists.Display();
            //Console.WriteLine("*****************************Added 56 at start of the linkedlist " +
            //    "Added 30 at start of the linkedlist" +
            //    " Added 70 at start of the linkedlist Linked List:56-> 30-> 70************");
            //uc4
            //linkedLists.AppendNode(56);
            //linkedLists.AppendNode(70);
            //linkedLists.InsertNode(30, 56);
            //linkedLists.Display();
            //Console.WriteLine("***uc4****Added 56 at start of the linkedlist" +
            //    " Added 70 at start of the linkedlist" +
            //    " Linked List:56-> 30-> 70 * ************************************************************");
            ////uc5
            ////UC-5
            //linkedLists.AppendNode(56);
            //linkedLists.AppendNode(30);
            //linkedLists.AppendNode(70);
            //Console.WriteLine("Delete First element");
            //linkedLists.DeleteNodeAtFirst();
            //linkedLists.Display();
            //Console.WriteLine("**********56 removed and remaing linkedlist is 30->70******************");
            ////UC-6
            //linkedLists.AppendNode(56);
            //linkedLists.AppendNode(30);
            //linkedLists.AppendNode(70);
            //Console.WriteLine("Delete Last element");
            //linkedLists.DeleteNodeAtLast();
            //linkedLists.Display();
            //Console.WriteLine("*************70 is removed linkedlist:56->30**********************");
            //UC-7
            //Node node1 = new Node(56);
            //Node node2 = new Node(30);
            //Node node3 = new Node(70);
            //node1.next = node2;
            //node2.next = node3;
            //linkedLists.Head = node1;
            //Console.WriteLine("Search For Node value 30");
            //linkedLists.Display();
            //if (linkedLists.Search(30))
            //{
            //    Console.WriteLine("\nNode with value 30 is available in Linked list");
            //}
            //Console.WriteLine("**********56-> 30-> 70***Node with value 30 is available in Linked list********************************");
            ////UC-8
            //linkedLists.AppendNode(56);
            //linkedLists.AppendNode(30);
            //linkedLists.AppendNode(70);
            //linkedLists.InsertNode(40,30);
            //linkedLists.Display();
            /////uc9
            Console.WriteLine("Add Node After Node value 30 ");
            linkedLists.AppendNode(56);
            linkedLists.AppendNode(30);
            linkedLists.AppendNode(40);
            linkedLists.AppendNode(70);
            Console.WriteLine("before deleting:");
            linkedLists.Display();
            linkedLists.deleteNode(40);
            Console.WriteLine("afore deleting:");
            linkedLists.Display();
            Console.WriteLine("Count of nodes is " + linkedLists.getCount());



















        }
    }
}