
namespace LukasGredaProgramowanie.Exc10;

class Exercise10 : IExc
{
    public void RunExercise()
    {
        Console.WriteLine();
        Console.WriteLine("Program który oblicza sume ciągu pomnożoną przez 4");
        Console.WriteLine();
        Console.WriteLine("Podaj ilość elementów k");
        var k = Console.ReadLine();

        if (k is null)
        {
            Console.WriteLine("Wprowadzono błędną wartość. Zadanie zostanie zresetowane");
            Console.Clear();
            RunExercise();
            return;
        }
        int number = 0;
        try
        {
            number = Convert.ToInt32(k);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wprowadzono błędną wartość. Zadanie zostanie zresetowane");
            Console.WriteLine(ex.ToString());

            Console.Clear();
            RunExercise();
            return;
        }


        var stringExpression = PrepareStringExpression(number);
        var sum = CalculateExpression(number);

        Console.WriteLine($"Sume ciągu {stringExpression} wynosi {sum}");
    }
    string PrepareStringExpression(int number)
    {
        string ciagValue = "1";
        for (int i = 2; i <= number; i++)
        {
            ciagValue += $"{(Math.Pow(-1, i + 1))}/{(2 * (i - 1))} ";
        }
        return $"4 * ({ciagValue})";
    }

    double CalculateExpression(int number)
    {
        double ciagValue = 1;
        for (int i = 2; i <= number; i++)
        {

            ciagValue += (Math.Pow(-1, i + 1)) / (2 * (i - 1));
        }
        return 4 * ciagValue;
    }
}

