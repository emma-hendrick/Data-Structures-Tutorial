namespace telephone;

internal class LinkedList<T> where T: notnull
{
    public Node<T>? head;
    public Node<T>? tail;

    private int _size;

    public void InsertHead(T element)
    {
        Node<T> node = new Node<T>(element);
        _size ++;

        if (head is null)
        {
            head = node;
            tail = node;
            return;
        }

        node.next = head;
        head.previous = node;
        head = node;
    }

    public void InsertTail(T element)
    {
        Node<T> node = new Node<T>(element);
        _size ++;

        if (tail is null)
        {
            head = node;
            tail = node;
            return;
        }

        tail.next = node;
        node.previous = tail;
        tail = node;
    }

    public Node<T>? Search(T element)
    {
        Node<T>? current = head;

        // In case the list is empty
        if (current == null)
        {
            return null;
        }

        while (!current.GetValue().Equals(element) && current.next is not null)
        {
            current = current.next;
        }

        if (current.GetValue().Equals(element)) return current;
        return null;

    }

    public void Remove(T element)
    {
        Node<T>? node = Search(element);
        if (node is not null) Remove(node);
    }

    public void Remove(Node<T> node)
    {
        _size --;

        // This is the only node in the list
        if (node.next is null && node.previous is null)
        {
            head = null;
            tail = null;
        }
        
        // This is the head of the list
        else if (node.next is not null && node.previous is null)
        {
            node.next.previous = null;
            head = node.next;
        }
        // This is the tail of the list
        else if (node.next is null && node.previous is not null)
        {
            node.previous.next = null;
            tail = node.previous;
        }

        // This element is in the middle of the list
        // We only define this so explicitly to help show the compiler that we are NOT DEREFERENCING A NULL REFERENCE...
        else if (node.next is not null && node.previous is not null)
        {
            node.previous.next = node.next;
            node.next.previous = node.previous;
        }
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