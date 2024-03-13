internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program that checks if the user is old enough to drive

        Console.WriteLine("What's your age?");
        int userAge = int.Parse(Console.ReadLine());

        if (userAge < 16)
        {
            Console.WriteLine($"You are {userAge}, you can't drive yet!");
        }
        else
        {
            Console.WriteLine($"You are {userAge}, you're allowed to drive!");
        }
    }
}