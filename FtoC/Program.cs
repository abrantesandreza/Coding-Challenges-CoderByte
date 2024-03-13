internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program to input a Fahrenheit and output 
        // the equivalent temperature in Centigrade

        Console.WriteLine("Enter the temperature in Fahrenheit");
        float fahrenheit = float.Parse(Console.ReadLine());

        float centigrade = 5 * (fahrenheit - 32) / 9;

        Console.WriteLine($"Fahrenheit: {fahrenheit}\n" +
            $"Centigrade: {centigrade:.##}");
    }
}