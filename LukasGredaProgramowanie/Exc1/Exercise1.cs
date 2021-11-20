
namespace LukasGredaProgramowanie.Exc1;

class Exercise1 : IExc
{
    public void RunExercise()
    {
        Console.WriteLine();
        Console.WriteLine("Program który pyta użytkownika o imie i pozdrawia go Tym imieniem");
        Console.WriteLine();
        Console.WriteLine("Wprowadź swoje imie:");
        var imie = Console.ReadLine();

        Console.WriteLine($"Witaj {imie}");
    }

}

