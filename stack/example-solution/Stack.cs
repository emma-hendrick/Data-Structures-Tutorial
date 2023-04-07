namespace tower_of_hanoi;

internal class Stack<T> where T : notnull
{
    private List<T> _stack = new List<T>();

    public void Push(T element)
    {
        _stack.Add(element);
    }

    public void PushList(List<T> elements)
    {
        foreach (T element in elements)
        {
            _stack.Add(element);
        }
    }

    public T Pop()
    {
        int top = _stack.Count() - 1;
        T element = _stack[top];
        _stack.RemoveAt(top);
        return element;
    }

    public T Peek()
    {
        int top = _stack.Count() - 1;
        return _stack[top];
    }

    public T Nth(int n)
    {
        return _stack[n];
    }

    public bool Search(T element1)
    {
        foreach (T element2 in _stack){
            if (element1.Equals(element2)) {
                return true;
            }
        }

        return false;
    }

    public bool IsEmpty()
    {
        return _stack.Count() == 0;
    }

    public int Count()
    {
        return _stack.Count();
    }
}