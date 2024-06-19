using SinglyLinkedList;

void printList(LinkedList list)
{
    Node? currentNode = list.Head;
    while (currentNode != null)
    {
        Console.Write($"{currentNode.Value} ");
        currentNode = currentNode.Next;
    }
}

LinkedList list = new LinkedList();
int option = 1;

while (option < 6 && option > 0)
{
    Console.Write("List: ");
    printList(list);
    Console.WriteLine("\n========================\nChoose an option:\n1) Add node\n2) Find first greater node\n3) Find sum of smaller nodes\n4) Get new list of greater nodes\n5) Remove nodes after max node\n6) Exit\n========================");
    option = Convert.ToInt32(Console.ReadLine());
    if (option == 1)
    {
        Console.Write("Enter a value of the node: ");
        int value = Convert.ToInt32(Console.ReadLine());
        list.add(value);
    }
    if (option == 2)
    {
        Console.Write("Enter a value: ");
        int value = Convert.ToInt32(Console.ReadLine());
        int index = list.findNode(value);
        Console.WriteLine($"Result: {index}");
        Console.ReadLine();
    }
    if (option == 3)
    {
        Console.Write("Enter a value: ");
        int value = Convert.ToInt32(Console.ReadLine());
        int sum = list.sum(value);
        Console.WriteLine($"Result: {sum}");
        Console.ReadLine();
    }
    if (option == 4)
    {
        Console.Write("Enter a value: ");
        int value = Convert.ToInt32(Console.ReadLine());
        LinkedList resultList = list.getGreaterValues(value);
        Console.Write("Result: ");
        printList(resultList);
        Console.ReadLine();
    }
    if (option == 5)
    {
        list.removeAfterMax();
    }
    Console.Clear();
}