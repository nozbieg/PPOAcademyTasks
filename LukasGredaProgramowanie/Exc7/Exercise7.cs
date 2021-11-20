
namespace LukasGredaProgramowanie.Exc7;

class Exercise7 : IExc
{
    public void RunExercise()
    {
        Console.WriteLine();
        Console.WriteLine("Program który wypisuje wsyzstkie liczby pierwsze od 1...n");
        Console.WriteLine();
        Console.WriteLine("Podaj liczbe n");
        var n = Console.ReadLine();
        if (n is null)
        {
            Console.WriteLine("Wprowadzono błędną wartość. Zadanie zostanie zresetowane");
            Console.Clear();
            RunExercise();
            return;
        }
        int number = 0;
        try
        {
            number = Convert.ToInt32(n);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wprowadzono błędną wartość. Zadanie zostanie zresetowane");
            Console.WriteLine(ex.ToString());

            Console.Clear();
            RunExercise();
            return;
        }

        PrintPrimeNumbersUpToN(number);

    }
    void PrintPrimeNumbersUpToN(int number)
    {
        var line = string.Empty;
        if (number >= 2)
        {
            line = "2";
            for (int i = 3; i <= number; i++)
            {
                if (IsPrime(i))
                {
                    line = $"{line}, {i}";
                }
            }
        }
        else
        {
            line = "Nie ma liczb pierwszych w podanym zakresie";
        }
        Console.WriteLine($"Liczby pierwsze w zakresie 1..{number}");
        Console.WriteLine(line);
    }
    public static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        if (number == 2)
        {
            return true;
        }

        if (number % 2 == 0)
        {
            return false;
        }

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}

