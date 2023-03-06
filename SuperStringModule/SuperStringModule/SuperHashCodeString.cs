using System.Collections.Immutable;
using System.Text;

using SuperStringModule.Abstractions;

namespace SuperStringModule;

public class SuperHashCodeString : SuperString<byte>
{
    public SuperHashCodeString(string customString) : base(customString) { }
    
    public SuperHashCodeString(char customString) : base(customString) { }
    
    public Encoding Encoding { get; set; } = Encoding.Unicode;

    protected override ImmutableArray<byte> GetValueFromString(string customString)
    {
        return string.IsNullOrEmpty(customString)
            ? new ImmutableArray<byte>()
            : Encoding.GetBytes(customString.ToCharArray()).ToImmutableArray();
    }

    protected override ImmutableArray<byte> GetValueFromChar(char customChar)
    {
        return Encoding.GetBytes(new[] {customChar}).ToImmutableArray();
    }

    protected override char[] ToCharArray()
    {
        return Encoding.GetChars(Value.ToArray());
    }

    protected override string ToSuperString()
    {
        return new string(Encoding.GetChars(Value.ToArray()));
    }
}