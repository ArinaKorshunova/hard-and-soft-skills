using SuperStringModule.Abstractions;

namespace SuperStringModule;

public class StringManager<TObject> : IStackObject
    where TObject : struct
{
    private readonly SuperString<TObject> _stringObject;
    
    public StringManager(SuperString<TObject> stringObject)
    {
        _stringObject = stringObject;
    }

    public char[] GetCharArray()
    {
        return _stringObject.GetCharArray();
    }

    public string GetString()
    {
        return _stringObject.GetString();
    }

    public string GetFromStart(int subStringLength)
    {
        return new string(_stringObject.GetString().Take(subStringLength).ToArray());
    }

    public string GetFromEnd(int subStringLength)
    {
        return new string(_stringObject.GetString().TakeLast(subStringLength).ToArray());
    }
}