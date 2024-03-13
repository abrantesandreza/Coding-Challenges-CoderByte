internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program to calculate how much money is spent on holiday

        Console.WriteLine("What was the starting budget of the holiday? ");
        decimal inicialBudget = decimal.Parse(Console.ReadLine());

        Console.WriteLine("How much was spent on food? ");
        decimal spentOnFood = decimal.Parse(Console.ReadLine());

        Console.WriteLine("How much was spent on trips? ");
        decimal spentOnTrips = decimal.Parse(Console.ReadLine());

        Console.WriteLine("How much was spent on presents? ");
        decimal spentOnPresents = decimal.Parse(Console.ReadLine());

        decimal moneySpent = spentOnFood + spentOnTrips + spentOnPresents;
        decimal moneyLeft = inicialBudget - moneySpent;

        Console.WriteLine($"You spent {moneySpent} dollars on this holiday, " +
            $"but you still have {moneyLeft} dollars.");
    }
}