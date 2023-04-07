namespace mailing_list;
using System;
using System.Collections.Generic;

internal class Set<T> where T: notnull
{
    private Dictionary<int, T> _elements = new Dictionary<int, T>();
    
    public void Add(T element)
    {
        if (Member(element)) {
            return;
        }
        
        _elements[element.GetHashCode()] = element;
    }

    public void Remove(T element)
    {
        if (Member(element)) {
            _elements.Remove(element.GetHashCode());
        }
    }

    public bool Member(T element)
    {
        return _elements.ContainsKey(element.GetHashCode());
    }

    public void ForEach(Action<T> predicate)
    {
        T[] values = _elements.Values.ToArray<T>();

        foreach (T element in values)
        {
            predicate(element);
        }
    }

}