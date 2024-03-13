internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What's your name?");
        string userName = Console.ReadLine();

        Console.WriteLine($"Hello, {userName}");
        Console.WriteLine($"Nice to meet you, {userName}");
    }
}