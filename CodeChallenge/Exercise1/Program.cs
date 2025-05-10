// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Reverse the words in a sentence (not just the characters): Write a C# method that reverses the order of words in a given sentence. \r\nYou must preserve the words themselves (do not reverse the letters inside each word), but the order of the words must be reversed.");

const string WORDS = "Hello world, reversed.";

Stack<string> stack = new Stack<string>();

StringBuilder sb = new StringBuilder();

for (int i = 0; i < WORDS.Length; i++)
{
    if (i == WORDS.Length - 1)
    {
        sb.Append(WORDS[i]);
        stack.Push(sb.ToString());
        sb.Clear();

    }else if (char.IsWhiteSpace(WORDS[i]) && sb.Length > 0)
    {
        stack.Push(sb.ToString());
        sb.Clear();
    }
    else
    {
        sb.Append(WORDS[i]);
    }
}
var count = stack.Count;
for (int i = 0; i < count; i++)
{
    Console.WriteLine(stack.Pop());
}
