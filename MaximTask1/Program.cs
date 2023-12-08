using System.Text.RegularExpressions;

string inputString;

inputString = Console.ReadLine();
var regex = new Regex("^[a-z]+$");
if (!regex.IsMatch(inputString))
{
    string errorMessage = "";
    foreach (var item in inputString)
    {
        if (!regex.IsMatch(item.ToString()))
        {
            errorMessage += item;
        }
    }
    throw new SymbolException("Некоректные символы - " + errorMessage);
}
else
{
    int length = inputString.Length;
    if (length % 2 == 0)
    {
        string firstHalf = inputString.Substring(0, length / 2);
        string secondHalf = inputString.Substring(length / 2);
        firstHalf = Reverse(firstHalf);
        secondHalf = Reverse(secondHalf);

        inputString = firstHalf + secondHalf;
    }
    else
    {
        inputString = Reverse(inputString) + inputString;
    }

    Console.WriteLine(inputString);

    foreach (var item in inputString.Distinct().ToArray())
    {
        var count = inputString.Count(symbol => symbol == item);
        Console.WriteLine("Количество символов {0} = {1}", item, count);
    }

    Console.WriteLine(FindLargestSubstring(inputString));
}

static string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

static string FindLargestSubstring(string inputString)
{
    string vowelLetters = "aeiouy";
    string largestSubstring = "";
    for (int i = 0; i < inputString.Length; i++)
    {
        for (int j = i; j < inputString.Length; j++)
        {
            if (vowelLetters.Contains(inputString[i]) && vowelLetters.Contains(inputString[j]))
            {
                string substring = inputString.Substring(i, j - i + 1);
                if (substring.Length > largestSubstring.Length)
                {
                    largestSubstring = substring;
                }
            }
        }
    }
    return largestSubstring;
}

class SymbolException : Exception
{
    public SymbolException(string message) : base(message) { }
}