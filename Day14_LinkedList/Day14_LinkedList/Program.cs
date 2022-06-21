namespace Day14_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedLists linkedLists = new LinkedLists();

            //UC-1
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);
            node1.next = node2;
            node2.next = node3;
            linkedLists.Head = node1;
            linkedLists.Display();
            Console.WriteLine("*************uc1 o/p:Linked List:56-> 30-> 70*************************");
            //uc1 o/p:Linked List:56-> 30-> 70
            //uc2
            linkedLists.AddNode(70);
            linkedLists.AddNode(30);
            linkedLists.AddNode(56);
            linkedLists.Display();
            Console.WriteLine("*****************  Added 70 at start of the linkedlist " +
                "Added 30 at start of the linkedlist " +
                "Added 56 at start of the linkedlist " +
                "Linked List:56-> 30-> 70->* ********************");









        }
    }
}