using System;
public class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        this.Data = data;
        this.Next = null;
    }
}
public class LinkedList
{
    public Node Head;
    public void Append(int data)
    {
        Node newNode = new Node(data);

        if (Head == null)
        {
            Head = newNode;
            return;
        }
        Node lastNode = Head;
        while (lastNode.Next != null)
        {
            lastNode = lastNode.Next;
        }
        lastNode.Next = newNode;
    }

    public void Prepend(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = Head;
        Head = newNode;
    }
    public void DeleteNode(int key)
    {
        Node current = Head;
        if (current != null && current.Data == key)
        {
            Head = current.Next;
            return;
        }
        Node prev = null;
        while (current != null && current.Data != key)
        {
            prev = current;
            current = current.Next;
        }
        if (current == null)
        {
            return;
        }
        prev.Next = current.Next;
    }
    public void PrintList()
    {
        Node current = Head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("None");
    }
}

class Program
{
    static void Main()
    {
        LinkedList linkedList = new LinkedList();

        linkedList.Append(1);
        linkedList.Append(2);
        linkedList.Append(3);

        Console.WriteLine("Original Linked List:");
        linkedList.PrintList();

        // Prepend a node
        linkedList.Prepend(0);

        // Print the linked list after prepending
        Console.WriteLine("\nLinked List after prepending 0:");
        linkedList.PrintList();

        // Delete a node
        linkedList.DeleteNode(2);

        // Print the linked list after deleting node with value 2
        Console.WriteLine("\nLinked List after deleting node with value 2:");
        linkedList.PrintList();
    }
}
