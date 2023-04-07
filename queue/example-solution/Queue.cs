namespace cards;

internal class Queue<T> where T : notnull
{
    private List<T> _queue = new List<T>();

    public void Enqueue(T element)
    {
        _queue.Add(element);
    }

    public T Dequeue()
    {
        T element = _queue[0];
        _queue.RemoveAt(0);
        return element;
    }

    public T Peek()
    {
        return _queue[0];
    }

    public bool IsEmpty()
    {
        return _queue.Count() == 0;
    }

    public int Count()
    {
        return _queue.Count();
    }
}