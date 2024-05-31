// See https://aka.ms/new-console-template for more information
namespace exercise_2_2;

public class Program
{

    public static void Main(String[] args)
    {
        const int baseCost = 200;
        const int hourlyRate = 150;
        const int mileRate = 2;

        Console.WriteLine("how many hours will the move take?");
        var hours = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("how many miles is the move");
        var miles = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Total: {0:C}", hours*hourlyRate + mileRate * miles + baseCost);
    }
}