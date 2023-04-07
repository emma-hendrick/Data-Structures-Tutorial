namespace cards;

internal class Queue<T> where T : notnull
{
    private List<T> _queue = new List<T>();

    public void Enqueue(T element)
    {
        
    }

    public T Dequeue()
    {
        
    }

    public T Peek()
    {
        
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