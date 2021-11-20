
namespace LukasGredaProgramowanie.Exc5;

class Exercise5 : IExc
{
    public void RunExercise()
    {
        Console.WriteLine();
        Console.WriteLine("Program który prosi uzytkownika o luczbe b u daje możliwośc wyboru między sumowaniem lub iloczynem 1...n i ją wyświetla");
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

        Console.WriteLine("Suma (S) czy Iloczyn (I)");
        var choice = Console.ReadKey(true);

        if (choice.Key == ConsoleKey.S)
        {
            Console.WriteLine($"Suma od 1 do {number} wynosi: {Sum(number)}");

        }
        else if (choice.Key == ConsoleKey.I)
        {
            Console.WriteLine($"Iloczyn od 1 do {number} wynosi: {Multiply(number)}");
        }
        else
        {
            Console.WriteLine("Wrong key pressed. Select again");
            ContinueInput();
        }
    }

    int Sum(int number)
    {
        int suma = 0;
        for (int i = 0; i <= number; i++)
        {
            suma += i;
        }
        return suma;
    }
    int Multiply(int number)
    {
        int suma = 1;
        for (int i = 1; i <= number; i++)
        {
            suma *= i;
        }
        return suma;
    }
    public bool ContinueInput()
    {
        var key = Console.ReadKey(true);
        if (key.Key == ConsoleKey.S)
        {
            return true;
        }
        else if (key.Key == ConsoleKey.I)
        {
            return false;
        }
        else
        {
            Console.WriteLine("Wrong key pressed. Select again");
            ContinueInput();
            return false;
        }
    }
}

