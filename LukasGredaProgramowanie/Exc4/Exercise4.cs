
namespace LukasGredaProgramowanie.Exc4;

class Exercise4 : IExc
{
    public void RunExercise()
    {
        Console.WriteLine();
        Console.WriteLine("Program który pyta uzytkownika o liczbe n i wypisuje sume liczb od 1 do n uwzględniając w sumie tylko wielokrotności liczb 3 i 5");
        Console.WriteLine();
        Console.WriteLine("Podaj liczbe n");
        var n = Console.ReadLine();

        if (n is not null)
        {
            try
            {
                var number = Convert.ToInt32(n);
                Console.WriteLine($"Suma od 1 do {number} za pomocą pętli for wynosi: {SumWithFor(number)}");
                Console.WriteLine($"Suma od 1 do {number} za pomocą pętli while wynosi:  {SumWithWhile(number)}");
                Console.WriteLine($"Suma od 1 do {number} za pomocą pętli DoWhile wynosi: {SumWithDoWhile(number)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wprowadzono błędną wartość. Zadanie zostanie zresetowane");
                Console.WriteLine(ex.ToString());

                Console.Clear();
                RunExercise();
            }
        }

    }
    int SumWithWhile(int number)
    {
        int i = 0;
        int suma = 0;
        while (i <= number)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                suma += i;
            }
            i++;
        }
        return suma;
    }
    int SumWithFor(int number)
    {
        int suma = 0;
        for (int i = 0; i <= number; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                suma += i;
            }
        }
        return suma;
    }
    int SumWithDoWhile(int number)
    {
        int i = 0;
        int suma = 0;
        do
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                suma += i;
            }
            i++;
        } while (i <= number);
        return suma;
    }
}


