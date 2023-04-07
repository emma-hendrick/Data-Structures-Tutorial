namespace graphing;
internal class Graph<T> where T: notnull
{
    private HashSet<Node<T>> _nodes = new HashSet<Node<T>>();

    public Node<T> Insert(T value)
    {
    }

    public void Remove(T value)
    {
    }

    public void Connect(T valueA, T valueB)
    {
    }

    public void Disonnect(Node<T> nodeA, Node<T> nodeB)
    {  
    }

    public void Traverse(Action<Node<T>> predicate)
    {
    }

    public Node<T>? Search(T value)
    {
        foreach (Node<T> node in _nodes)
        {
            if (value.Equals(node.GetValue()))
            {
                return node;
            }
        }
        return null;
    }
    public void Print()
    {
        Traverse((Node<T> node) => node.Print());
    }
}