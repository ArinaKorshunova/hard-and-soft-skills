using System.Collections.Immutable;

using SuperStringModule.Abstractions;

namespace SuperStringModule;

public class SuperCharString : SuperString<char>
{
    public SuperCharString(string customString) : base(customString) { }
    
    public SuperCharString(char customString) : base(customString) { }
    
    protected override ImmutableArray<char> GetValueFromString(string customString)
    {
        return string.IsNullOrEmpty(customString)
            ? new ImmutableArray<char>()
            : customString.ToCharArray().ToImmutableArray();
    }

    protected override ImmutableArray<char> GetValueFromChar(char customChar)
    {
        return new[] {customChar}.ToImmutableArray();
    }

    protected override char[] ToCharArray()
    {
        return Value.ToArray();
    }

    protected override string ToSuperString()
    {
        return new string(Value.ToArray());
    }
}