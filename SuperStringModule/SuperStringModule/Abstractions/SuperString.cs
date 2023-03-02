﻿using System.Collections.Immutable;

namespace SuperStringModule.Abstractions;

public abstract class SuperString<TObject> where TObject : struct
{
    protected SuperString()
    {
        Value = new ImmutableArray<TObject>();
    }

    protected SuperString(string customString)
    {
        Value = GetValueFromString(customString);
    }

    protected SuperString(char customChar)
    {
        Value = GetValueFromChar(customChar);
    }

    protected ImmutableArray<TObject> Value { get; set; }

    private int Length => Value.Length;

    public int GetLength()
    {
        return Length;
    }

    public void Clear()
    {
        Value = new ImmutableArray<TObject>();
    }

    protected abstract ImmutableArray<TObject> GetValueFromString(string customString);

    protected abstract ImmutableArray<TObject> GetValueFromChar(char customChar);

    public abstract char[] ToCharArray();

    public abstract string ToSuperString();
}