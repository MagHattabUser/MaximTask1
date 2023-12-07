string inputString;

inputString = Console.ReadLine();

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

static string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}