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
        // Execute for the left branch, then self, then right branch
        if (left is not null) left.Traverse(predicate);
        predicate(_value);
        if (right is not null) right.Traverse(predicate);
    }

    public void Insert(T value)
    {
        if (value.CompareTo(_value) > 0)
        {
            if (right is not null)
            {
                right.Insert(value);
            }
            else
            {
                right = new Node<T>(value);
            }
        }
        else 
        {
            if (left is not null)
            {
                left.Insert(value);
            }
            else
            {
                left = new Node<T>(value);
            }
        }
    }

    public bool Search(T value)
    {
        if (value.Equals(_value)) return true;
        if (value.CompareTo(_value) > 0 && right is not null) return right.Search(value);
        if (value.CompareTo(_value) < 0 && left is not null) return left.Search(value);
        return false;
    }

    public List<T> GetNodeValues()
    {
        List<T> nodeValues = new List<T>();

        if (left is not null) nodeValues.AddRange(left.GetNodeValues());
        nodeValues.Add(_value);
        if (right is not null) nodeValues.AddRange(right.GetNodeValues());

        return nodeValues;
    }
}

