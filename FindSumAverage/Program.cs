internal class Program
{
    private static void Main(string[] args)
    {   
        // Write a program to read in two numbers and print
        // their sum and average
        Console.WriteLine("Enter a number:");
        int numberOne = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter another number:");
        int numberTwo = int.Parse(Console.ReadLine());

        int sum = numberOne + numberTwo;
        double average = (double)sum / 2;

        Console.WriteLine($"Sum: {sum}\n" +
            $"Average: {average}");
    }
}