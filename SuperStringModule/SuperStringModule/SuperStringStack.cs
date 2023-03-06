using SuperStringModule.Abstractions;

namespace SuperStringModule;

public class SuperStringStack
{
    public SuperStringStack()
    {
        Stack = new Stack<IStackObject>();
    }

    private Stack<IStackObject> Stack { get; set; }
    
    public void Init(int capacity)
    {
        Stack = new Stack<IStackObject>(capacity);
    }

    public void Push(IStackObject stackObject)
    {
        Stack.Push(stackObject);
    }

    public IStackObject Peek()
    {
        return Stack.Peek();
    }

    public void Remove(IStackObject stackObject)
    {
        var items = Stack.ToList();
        items.Remove(stackObject);
        Stack = new Stack<IStackObject>(items);
    }

    public string?[] GetStrings()
    {
        return Stack.Select(x => x.GetString()).ToArray();
    }
}