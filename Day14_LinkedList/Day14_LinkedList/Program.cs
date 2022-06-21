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
            //uc1 o/p:Linked List:56-> 30-> 70
            

        }
    }
}