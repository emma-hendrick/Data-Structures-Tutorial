namespace millions;
internal class BST<T> where T: IComparable<T>
{
    private Node<T>? _root = null;

    public void Insert(T value)
    {
        if (_root is not null)
        {
            _root.Insert(value);
        }
        else 
        {
        _root = new Node<T>(value);
        }
    }

    public void Traverse(Action<T> predicate)
    {
        if (_root is not null) _root.Traverse(predicate);
    }

    public bool Search(T value)
    {
        if (_root is not null) return _root.Search(value);
        return false;
    }

    public List<T>? GetNodeValues()
    {
        if (_root is not null) return _root.GetNodeValues();
        return null;
    }

    public BST<T> Balance()
    {
        BST<T> new_bst = new BST<T>();
        List<T>? nodeValues = GetNodeValues();
        if (nodeValues is null) return new_bst;

        List<List<T>> lists = new List<List<T>>(){nodeValues};
        List<T> values = new List<T>();

        while (lists.Count > 0)
        {
            List<T> list = lists[0];
            if (list.Count > 2)
            {
                int middle = (int)Math.Floor((double)list.Count / 2);

                values.Add(list[middle]);

                lists.Add(list.GetRange(0, middle));
                lists.Add(list.GetRange(middle + 1, list.Count - middle - 1));

            }
            else
            {
                values.AddRange(list);
            }

            lists.RemoveAt(0);
        }

        foreach (T value in values)
        {
            new_bst.Insert(value);
        }

        return new_bst;
    }
}