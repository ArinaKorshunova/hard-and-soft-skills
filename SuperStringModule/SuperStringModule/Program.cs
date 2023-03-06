using SuperStringModule;
using SuperStringModule.Abstractions;

var stack = new SuperStringStack();

var charStringByChar = new SuperCharString('a');
var charStringByString = new SuperCharString("hello there");

var hashCodeStringByChar = new SuperHashCodeString('b');
var hashCodeStringByString = new SuperHashCodeString("what the hell is it?");

Console.WriteLine($"charStringByChar: {charStringByChar.GetString()}");
Console.WriteLine("charStringByChar array");
foreach (var ch in charStringByChar.GetCharArray())
{
    Console.WriteLine(ch);
}
Console.WriteLine($"charStringByChar length: {charStringByChar.GetLength()}");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"charStringByString: {charStringByString.GetString()}");
Console.WriteLine("charStringByString array");
foreach (var ch in charStringByString.GetCharArray())
{
    Console.WriteLine(ch);
}
Console.WriteLine($"charStringByString length: {charStringByString.GetLength()}");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"hashCodeStringByChar: {hashCodeStringByChar.GetString()}");
Console.WriteLine("hashCodeStringByChar array");
foreach (var ch in hashCodeStringByChar.GetCharArray())
{
    Console.WriteLine(ch);
}
Console.WriteLine($"hashCodeStringByChar length: {hashCodeStringByChar.GetLength()}");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"hashCodeStringByString: {hashCodeStringByString.GetString()}");
Console.WriteLine("hashCodeStringByString array");
foreach (var ch in hashCodeStringByString.GetCharArray())
{
    Console.WriteLine(ch);
}
Console.WriteLine($"hashCodeStringByString length: {hashCodeStringByString.GetLength()}");
Console.WriteLine();
Console.WriteLine();

var charStringManager = new StringManager<char>(charStringByString);
Console.WriteLine($"charStringManager.GetString(): {charStringManager.GetString()}");
Console.WriteLine($"charStringManager.GetFromStart(3): {charStringManager.GetFromStart(3)}");
Console.WriteLine($"charStringManager.GetFromEnd(3): {charStringManager.GetFromEnd(3)}");
Console.WriteLine();
Console.WriteLine();

var hashCodeStringManager = new StringManager<byte>(hashCodeStringByString);
Console.WriteLine($"hashCodeStringManager.GetString(): {hashCodeStringManager.GetString()}");
Console.WriteLine($"hashCodeStringManager.GetFromStart(3): {hashCodeStringManager.GetFromStart(3)}");
Console.WriteLine($"hashCodeStringManager.GetFromEnd(3): {hashCodeStringManager.GetFromEnd(3)}");
Console.WriteLine();
Console.WriteLine();

stack.Init(1);
stack.Push(hashCodeStringByString);
stack.Push(charStringByString);
stack.Push(hashCodeStringManager);
stack.Push(charStringManager);

Console.WriteLine($"stack:");
foreach (var str in stack.GetStrings())
{
    Console.WriteLine(str);
}