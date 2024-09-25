namespace WordCount;

public static class StringExtensions
{
    public static int WordCount(this string input)
    {
        return input.Split(new char[] { ' ', '.', ',', '?' },
            StringSplitOptions.RemoveEmptyEntries).Length;
    }
}