
namespace LukasGredaProgramowanie.Exc8;

public class Exercise8 : IExc
{
    public void RunExercise()
    {
        Console.WriteLine();
        Console.WriteLine("Program Gry w zgadywanie");

        var r = new Random();
        var secretNumber = r.NextInt64(100);

        var gameEngine = new GameEngine(secretNumber);
        var succes = gameEngine.TakeGuess();
        while (succes == false)
        {
            gameEngine.LessOrMore();
            succes = gameEngine.TakeGuess();
        }
        if (succes)
        {
            gameEngine.PrintWinning();
            return;
        }

    }

}

