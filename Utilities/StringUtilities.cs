namespace Utilities;

public static class StringUtilities
{
    public static int ToWords(string input) => input.Split(" ").Length;

    public static string ToSentence(string input)
    {
        input = input.ToLower();

        return input[0].ToString().ToUpper() + input[1..];
    }

    public static string ToCamelCase(string input)
    {
        var split = input.ToLower().Split(' ');

        var result = "";

        foreach (var element in split)
            result += ToSentence(element);

        return result[0].ToString().ToLower() + result[1..];
    }
}
