using System.Collections.Immutable;

using SuperStringModule.Abstractions;

namespace SuperStringModule;

public class SuperCharString : SuperString<char>
{
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

    public override char[] ToCharArray()
    {
        return Value.ToArray();
    }

    public override string ToSuperString()
    {
        return new string(Value.ToArray());
    }
}