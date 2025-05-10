// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Compress a string (e.g., `\"aaabbbcc\"` → `\"a3b3c2\"`)");
Console.WriteLine("Write a C# method that takes a lowercase alphabetic string as input and returns a compressed version using character counts. Consecutive repeating characters should be replaced by the character followed by the number of occurrences. For example, `\"aaabbbcc\"` should return `\"a3b3c2\"`, and `\"abcd\"` should return `\"a1b1c1d1\"`. The function must preserve the original order of characters and count only consecutive duplicates. Requirements: do not use LINQ or regular expressions, only loops and conditionals; handle edge cases like empty strings or single-character strings. Function signature: `string CompressString(string input)`");

const string inputOne = "aaabbbcc";
const string inputTwo = "aaabbbccd";
const string inputThree = "abcd";
const string inputFour = "";

const string expectedResultOne = "a3b3c2";
const string expectedResultTwo = "a3b3c2d1";
const string expectedResultThree = "a1b1c1d1";
const string expectedResultFour = "";

Console.WriteLine(inputOne + "CompressString: " + CompressString(inputOne) + 
                    "Validation: " + (expectedResultOne.Equals(CompressString(inputOne))).ToString());

Console.WriteLine(inputTwo + "CompressString: " + CompressString(inputTwo) +
                    "Validation: " + (expectedResultTwo.Equals(CompressString(inputTwo))).ToString());

Console.WriteLine(inputThree + "CompressString: " + CompressString(inputThree) +
                    "Validation: " + (expectedResultThree.Equals(CompressString(inputThree))).ToString());

Console.WriteLine(inputFour + "CompressString: " + CompressString(inputFour) +
                    "Validation: " + (expectedResultFour.Equals(CompressString(inputFour))).ToString());

static string CompressString(string input)
{
    var stringCompress = "";

    if (string.IsNullOrEmpty(input)) 
    {  
        return stringCompress; 
    }

    var dictionaty = new Dictionary<char, int>();

    //Initialize whit the first element of the string

    dictionaty.Add(input[0], 0);

    for (int i = 0; i < input.Length; i++)
    {
        //verify the existence of the element as key
        var element = input[i];
        if (dictionaty.ContainsKey(element))
        {
            //add ocurrency
            var ocurrency = dictionaty[element];
            ocurrency += 1;
            dictionaty[element] = ocurrency;
        }
        else
        {
            dictionaty.Add(element, 1);
        }
    }

    StringBuilder stringBuilder = new StringBuilder();

    foreach (var item in dictionaty)
    {
        stringBuilder.Append(item.Key.ToString() + item.Value.ToString());
    }

    stringCompress = stringBuilder.ToString();

    return stringCompress;
}