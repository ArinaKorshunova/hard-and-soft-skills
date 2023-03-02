using SuperStringModule.Abstractions;

namespace SuperStringModule;

public class StringManager<TObject> where TObject : struct
{
    public char[] GetCharArray(SuperString<TObject> superString)
    {
        return superString.ToCharArray();
    }

    public string GetString(SuperString<TObject> superString)
    {
        return superString.ToSuperString();
    }

    public string GetFromStart(SuperString<TObject> superString, int subStringLength)
    {
        return new string(superString.ToSuperString().Take(subStringLength).ToArray());
    }

    public string GetFromEnd(SuperString<TObject> superString, int subStringLength)
    {
        return new string(superString.ToSuperString().TakeLast(subStringLength).ToArray());
    }
}