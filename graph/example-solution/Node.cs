namespace graphing;
internal class Node<T> where T: notnull
{
    private T _value;
    private HashSet<Node<T>> connections = new HashSet<Node<T>>();

    public Node(T value)
    {
        _value = value;
    }

    public T GetValue()
    {
        return _value;
    }

    public void Connect(Node<T> other)
    {
        connections.Add(other);
    }

    public void Disconnect(Node<T> other)
    {
        connections.Remove(other);
    }

    public void Print()
    {
        Console.WriteLine(_value);
        foreach (Node<T> node in connections)
        {
            T value = node.GetValue();
            Console.WriteLine($"--{value}");
        }
    }
}

