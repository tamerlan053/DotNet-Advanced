namespace WordCount;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please provide a sentence:");
        string sentence = Console.ReadLine();
        int wordCount = sentence.WordCount();

        Console.WriteLine($"Word count: {wordCount}");

        Console.WriteLine("Press any key to close...");
        Console.ReadKey(true);
    }
}