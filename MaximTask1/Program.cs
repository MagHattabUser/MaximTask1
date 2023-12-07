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


}

static string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}
class SymbolException : Exception
{
    public SymbolException(string message) : base(message) { }
}