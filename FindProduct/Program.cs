internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program to read in two numbers 
        // and print their product

        Console.WriteLine("Enter a number:");
        int numberOne = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter another number:");
        int numberTwo = int.Parse(Console.ReadLine());

        int product = numberOne * numberTwo;

        Console.WriteLine($"Product: {product}");

    }
}