
namespace LukasGredaProgramowanie.Exc11;

class Exercise11 : IExc
{
    public void RunExercise()
    {
        Console.WriteLine("Program obsługujący Konwersje Hex -> Decimal oraz Decimal -> Hex");

        Console.WriteLine("Hex na Decimal (H) czy Decimal na Hex (D)");
        ContinueInput(Console.ReadKey(true));

    }
    public bool ContinueInput(ConsoleKeyInfo key)
    {

        if (key.Key == ConsoleKey.H)
        {
            Console.WriteLine("Wprowadź wartoś hexadecymalną");
            var hexValue = Console.ReadLine();

            try
            {
                var converted = Convert.ToInt64(hexValue, 16);
                Console.WriteLine($"Wartość dziesiętna liczby {hexValue}(16) wynosi {converted}(10)");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return true;
            }
        }
        else if (key.Key == ConsoleKey.D)
        {
            Console.WriteLine("Wprowadź wartoś decymalną");
            var decimalValue = Console.ReadLine();

            try
            {
                var readednumber = Convert.ToInt64(decimalValue);
                var hex = $"{readednumber:x}";
                Console.WriteLine($"Wartość hexadecymalna liczby {decimalValue}(16) wynosi {hex.ToUpper()}(16)");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return true;
            }
        }
        else
        {
            Console.WriteLine("Wrong key pressed. Select again");
            ContinueInput(Console.ReadKey(true));
            return false;
        }
    }
}



