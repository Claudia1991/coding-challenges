// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Remove duplicates from an array or string");
Console.WriteLine("Write a C# method that removes duplicate elements from either a string or an integer array while preserving the original order of first occurrences. For example, given the input string \"aabbccdde\" the output should be \"abcde\", and for the input array [1, 2, 2, 3, 4, 4, 5] the output should be [1, 2, 3, 4, 5]. The function should handle empty inputs and inputs with all unique or all duplicate values. You must not use LINQ or built-in methods like Distinct(); use loops, conditionals, and collections such as HashSet. Provide two method signatures: string RemoveDuplicateChars(string input) and int[] RemoveDuplicateInts(int[] input)");

const string duplicateString = "aaabbcccddd";

Console.WriteLine("Result: " + RemoveDuplicates(duplicateString));

string RemoveDuplicates(string duplicateString)
{
    char[] chars = duplicateString.ToCharArray();
    char[] chars2 = new char[chars.Length];
    StringBuilder sb = new StringBuilder();
    var initialPosition = 0;
    for (int i = 0; i < chars.Length; i++)
    {
        if (!chars2.Contains(chars[i]))
        {
            chars2[initialPosition] = chars[i];
            sb.Append(chars[i]);
            initialPosition++;
        }
    }

    return sb.ToString();
}