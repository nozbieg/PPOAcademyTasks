
namespace LukasGredaProgramowanie.Exc9;

class Exercise9 : IExc
{
    public void RunExercise()
    {

        Console.WriteLine();
        Console.WriteLine("Program pokazujący następne 20 lat przestępnych od roku bieżącego");

        var actualYear = DateTime.Now.Year;

        var isActualYearLeap = DateTime.IsLeapYear(actualYear);
        if (isActualYearLeap)
        {
            var nextLeapYears = CountNextLeapYears(actualYear);
            Console.WriteLine($"Następne lata przestępne to: {PrintTable(nextLeapYears)} ");
        }
        else
        {
            var nearestLeapYear = FindNearestLeapYear(actualYear);
            var nextLeapYears = CountNextLeapYears(nearestLeapYear);
            Console.WriteLine($"Następne lata przestępne to: {PrintTable(nextLeapYears)} ");
        }

    }
    string PrintTable(int[] nextLeapYears)
    {
        var line = string.Empty;
        for (int i = 0; i < nextLeapYears.Length; i++)
        {
            line += $"{nextLeapYears[i]} | ";
        }
        return line;
    }
    int FindNearestLeapYear(int actualYear)
    {
        for (int i = 1; i < 4; i++)
        {
            if (DateTime.IsLeapYear(actualYear + i))
            {
                return actualYear + i;
            }
        }
        return 0;
    }
    int[] CountNextLeapYears(int year)
    {
        var leapYearTab = new int[20];
        leapYearTab[0] = year;
        for (int i = 1; i < leapYearTab.Length; i++)
        {
            leapYearTab[i] = leapYearTab[i - 1] + 4;
        }
        return leapYearTab;
    }
}

