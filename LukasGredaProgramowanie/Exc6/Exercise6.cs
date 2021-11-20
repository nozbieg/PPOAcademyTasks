
namespace LukasGredaProgramowanie.Exc6;

class Exercise6 : IExc
{
    public void RunExercise()
    {
        Console.WriteLine();
        Console.WriteLine("Program który drukuje tabliczke mnożenia dla liczb do 12");
        Console.WriteLine();
        var multiplyArray = PrepareMultiplyTab();
        PrintArray(multiplyArray);
    }
    int[,] PrepareMultiplyTab()
    {
        var multiplyarray = new int[12, 12];
        for (int i = 1; i < 13; i++)
        {
            for (int j = 1; j < 13; j++)
            {
                multiplyarray[i - 1, j - 1] = i * j;
            }
        }
        return multiplyarray;
    }
    void PrintArray(int[,] multiplyArray)
    {
        string line = string.Empty;
        for (int i = 0; i < multiplyArray.GetLength(0); i++)
        {
            for (int j = 0; j < multiplyArray.GetLength(1); j++)
            {
                if (multiplyArray[i, j] >= 100)
                {
                    line = $"{line} | {multiplyArray[i, j]}";
                    continue;

                }

                if (multiplyArray[i, j] >= 10)
                {
                    line = $"{line} | {multiplyArray[i, j]} ";
                    continue;
                }

                if (multiplyArray[i, j] >= 0)
                {
                    line = $"{line} | {multiplyArray[i, j]}  ";
                    continue;
                }
            }
            Console.WriteLine(line);
            line = string.Empty;
        }
    }
}
