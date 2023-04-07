namespace graphing;
internal class Graph<T> where T: notnull
{
    private HashSet<Node<T>> _nodes = new HashSet<Node<T>>();

    public Node<T> Insert(T value)
    {
        Node<T> newNode = new Node<T>(value);
        _nodes.Add(newNode);
        return newNode;
    }

    public void Remove(T value)
    {
        Node<T>? removing = Search(value);
        if (removing is null) return;
        
        Traverse((Node<T> node) => node.Disconnect(removing));
        _nodes.Remove(removing);
    }

    public void Connect(T valueA, T valueB)
    {
        Node<T>? nodeA = Search(valueA);
        Node<T>? nodeB = Search(valueB);

        if (nodeA is null || nodeB is null) return;

        nodeA.Connect(nodeB);
        nodeB.Connect(nodeA);
    }

    public void Disonnect(Node<T> nodeA, Node<T> nodeB)
    {
        nodeA.Disconnect(nodeB);
        nodeB.Disconnect(nodeA);   
    }

    public void Traverse(Action<Node<T>> predicate)
    {
        foreach (Node<T> node in _nodes)
        {
            predicate(node);
        }
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