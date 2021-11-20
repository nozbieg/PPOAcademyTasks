
namespace LukasGredaProgramowanie.Exc2;

class Exercise2 : IExc
{
    public void RunExercise()
    {
        Console.WriteLine();
        Console.WriteLine("Program który pyta uzytkownika o imie i pozdrawia go Tym imieniem Jeśli jest to Anna lub Jan");
        Console.WriteLine();
        Console.WriteLine("Wprowadź swoje imie:");
        var imie = Console.ReadLine();

        if (imie is not null && (imie.ToUpper() == "ANNA" || imie.ToUpper() == "JAN"))
        {
            Console.WriteLine($"Witaj {imie}");
        }
        else
        {

            Console.WriteLine($"Witaj uzytkowniku");
        }

    }
}

