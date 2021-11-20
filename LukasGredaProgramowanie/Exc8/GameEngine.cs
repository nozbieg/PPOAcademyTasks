
namespace LukasGredaProgramowanie.Exc8;
public class GameEngine
{

    public long SecretRandom { get; set; }
    public int TryCount { get; set; }
    public int? LastTryNumber { get; set; }
    public GameEngine(long secretRandom)
    {
        SecretRandom = secretRandom;
    }

    public bool TakeGuess()
    {
        Console.WriteLine("Jak myslisz jaka to liczba? Wprowadź liczbę w przedziale 0-100");
        var n = Console.ReadLine();

        try
        {
            var number = Convert.ToInt32(n);
            if (LastTryNumber is not null && LastTryNumber == number)
            {
                return CheckIfCorrect(number) is true ? true : false;
            }
            LastTryNumber = number;
            TryCount++;
            return CheckIfCorrect(number) is true ? true : false;

        }
        catch (Exception ex)
        {
            Console.WriteLine("Wprowadzono błędną wartość. Wprowadź ponownie");
            Console.WriteLine(ex.ToString());

            Console.Clear();
            return TakeGuess();
        }


    }
    bool CheckIfCorrect(int number)
    {
        if (number == SecretRandom)
        {
            return true;
        }

        return false;
    }
    public void PrintWinning()
    {
        Console.WriteLine($"Gratulacje udało ci się odgadnąć sekretną liczbę {SecretRandom}");
        Console.WriteLine($"Żeby wygrać potrzebowałeś {TryCount} prób");
        Console.WriteLine();
    }
    public void LessOrMore()
    {
        var lessOrMore = LastTryNumber < SecretRandom ? "mniejsza" : "większa";
        Console.WriteLine($"Liczba {LastTryNumber} jest {lessOrMore} od naszej sekretnej liczby. Podaj kolejną liczbę");
        Console.WriteLine();
    }

}

