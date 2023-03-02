namespace SuperStringModule.Abstractions;

public class SuperStringStack<TSuperString> where TSuperString : class
{
    //todo: think better
    private Stack<TSuperString> Stack { get; set; }
    
    public void Init(int capacity)
    {
        Stack = new Stack<TSuperString>(capacity);
    }

    public void Push(TSuperString superString)
    {
        Stack.Push(superString);
    }

    public TSuperString Peek()
    {
        return Stack.Peek();
    }

    public void Remove(TSuperString superString)
    {
        var items = Stack.ToList();
        items.Remove(superString);
        Stack = new Stack<TSuperString>(items);
    }

    public string?[] GetStrings()
    {
        //Todo: implement
        return Stack.Select(x => x.ToString()).ToArray();
    }
}