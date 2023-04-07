namespace telephone;

internal class Node<T> where T: notnull
{
    private T _value;
    public Node<T>? next;
    public Node<T>? previous;

    public Node(T value)
    {
        _value = value;
    }

    public T GetValue()
    {
        return _value;
    }
}