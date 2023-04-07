namespace telephone;

internal class LinkedList<T> where T: notnull
{
    public Node<T>? head;
    public Node<T>? tail;

    private int _size;

    public void InsertHead(T element)
    {
    }

    public void InsertTail(T element)
    {
    }

    public Node<T>? Search(T element)
    {
    }

    public void Remove(T element)
    {
        Node<T>? node = Search(element);
        if (node is not null) Remove(node);
    }

    public void Remove(Node<T> node)
    {
    }

    public int Size()
    {
        return _size;
    }

    public bool Empty()
    {
        return _size == 0;
    }

    public void Print()
    {
        Node<T>? current = head;

        while (current is not null)
        {
            Console.WriteLine(current.GetValue());
            current = current.next;
        }
    }
}