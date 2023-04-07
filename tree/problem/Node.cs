namespace millions;
internal class Node<T> where T: IComparable<T>
{
    private T _value;
    public Node<T>? left;
    public Node<T>? right;

    public Node(T value)
    {
        _value = value;
    }

    public void Traverse(Action<T> predicate)
    {
    }

    public void Insert(T value)
    {
    }

    public bool Search(T value)
    {
    }

    public List<T> GetNodeValues()
    {
    }
}

