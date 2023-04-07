namespace tower_of_hanoi;

internal class Stack<T> where T : notnull
{
    private List<T> _stack = new List<T>();

    public void Push(T element)
    {
        
    }

    public void PushList(List<T> elements)
    {
        
    }

    public T Pop()
    {
        
    }

    public T Peek()
    {
        
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