namespace SinglyLinkedList
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Next { get; set; }
        
        public Node(int data)
        {
            Value = data;
            Next = null;
        }
    }
    public class LinkedList
    {
        public Node? Head { get; private set; }

        public LinkedList()
        {
            Head = null;
        }

        public LinkedList(int headValue)
        {
            Head = new Node(headValue);
        }

        public void add(int nodeValue)
        {
            if (Head == null)
            {
                Head = new Node(nodeValue);
            } else
            {
                Node newNode = new Node(nodeValue);
                newNode.Next = Head.Next;
                Head.Next = newNode;
            }
        }

        public int findNode(int nodeValue)
        {
            int index = -1;
            Node? currentNode = Head;
            while (currentNode != null && currentNode.Value <= nodeValue)
            {
                currentNode = currentNode.Next;
                index = (currentNode == null) ? -1 : index + 1;
            }
            return index + 1;
        }

        public int sum(int nodeValue)
        {
            int sum = 0;
            Node? currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Value < nodeValue)
                {
                    sum += currentNode.Value;
                }
                currentNode = currentNode.Next;
            }
            return sum;
        }

        public LinkedList getGreaterValues(int nodeValue)
        {
            LinkedList list = new LinkedList();
            Node? currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Value > nodeValue)
                {
                    list.add(currentNode.Value);
                }
                currentNode = currentNode.Next;
            }
            return list;
        }

        public void removeAfterMax()
        {
            Node? currentNode = Head;
            if (currentNode != null)
            {
                int maxValue = currentNode.Value;
                while (currentNode != null)
                {
                    if (maxValue < currentNode.Value)
                    {
                        maxValue = currentNode.Value;
                    }
                    currentNode = currentNode.Next;
                }
                currentNode = Head;
                while (currentNode.Value != maxValue)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = null;
            }
        }
    }
}