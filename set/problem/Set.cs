namespace mailing_list;
using System;
using System.Collections.Generic;

internal class Set<T> where T: notnull
{
    private Dictionary<int, T> _elements = new Dictionary<int, T>();
    
    // You can get the hash code for an element using element.getHashCode()
    public void Add(T element)
    {
    }

    public void Remove(T element)
    {
    }

    public bool Member(T element)
    {
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