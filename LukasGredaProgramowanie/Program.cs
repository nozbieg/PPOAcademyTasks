// See https://aka.ms/new-console-template for more information

while (true)
{
    PrintMenu();
    switch (Console.ReadKey().Key)
    {
        case ConsoleKey.D1:
            Console.Clear();
            var exercise1 = new Exercise1();
            exercise1.RunExercise();
            FinishExercise();
            break;
        case ConsoleKey.D2:
            Console.Clear();
            var exercise2 = new Exercise2();
            exercise2.RunExercise();
            FinishExercise();
            break;
        case ConsoleKey.D3:
            Console.Clear();
            var exercise3 = new Exercise3();
            exercise3.RunExercise();
            FinishExercise();
            break;
        case ConsoleKey.D4:
            Console.Clear();
            var exercise4 = new Exercise4();
            exercise4.RunExercise();
            FinishExercise();
            break;
        case ConsoleKey.D5:
            Console.Clear();
            var exercise5 = new Exercise5();
            exercise5.RunExercise();
            FinishExercise();
            break;
        case ConsoleKey.D6:
            Console.Clear();
            var exercise6 = new Exercise6();
            exercise6.RunExercise();
            FinishExercise();
            break;
        case ConsoleKey.D7:
            Console.Clear();
            var exercise7 = new Exercise7();
            exercise7.RunExercise();
            FinishExercise();
            break;
        case ConsoleKey.D8:
            Console.Clear();
            var exercise8 = new Exercise8();
            exercise8.RunExercise();
            FinishExercise();
            break;
        case ConsoleKey.D9:
            Console.Clear();
            var exercise9 = new Exercise9();
            exercise9.RunExercise();
            FinishExercise();
            break;
        case ConsoleKey.A:
            Console.Clear();
            var exercise10 = new Exercise10();
            exercise10.RunExercise();
            FinishExercise();
            break;
        case ConsoleKey.B:
            Console.Clear();
            var exercise11 = new Exercise11();
            exercise11.RunExercise();
            FinishExercise();
            break;
    }
}


void PrintMenu()
{
    Console.WriteLine("Wybierz zadanie do sprawdzenia:");
    Console.WriteLine("1 - Zad.1 Program ktory zapyta uzytkownika o imie i pozdrowi go nim");
    Console.WriteLine("2 - Zad.2 Program ktory zapyta uzytkownika o imie i pozdrowi go nim jeżeli imie to Anna lub Jan");
    Console.WriteLine("3 - zad.3 Program który pyta uzytkownika o liczbe n i wypisuje sume liczb od 1 do n");
    Console.WriteLine("4 - zad.4 Program który pyta uzytkownika o liczbe n i wypisuje sume liczb od 1 do n uwzględniając w sumie tylko wielokrotności liczb 3 i 5");
    Console.WriteLine("5 - zad.5 Program który prosi uzytkownika o luczbe b u daje możliwośc wyboru między sumowaniem lub iloczynem 1...n i ją wyświetla");
    Console.WriteLine("6 - zad.6 Program który drukuje tabliczke mnożenia dla liczb do 12");
    Console.WriteLine("7 - zad.7 Program który wypisuje wsyzstkie liczby pierwsze od 1...n");
    Console.WriteLine("8 - zad.8 Program \"Gra Zagadka\"");
    Console.WriteLine("9 - zad.9 Program pokazujący następne 20 lat przestępnych od roku bieżącego");
    Console.WriteLine("A - zad.10 Program który oblicza sume ciągu pomnożoną przez 4");
    Console.WriteLine("B - zad.11 Program obsługujący Konwersje Hex -> Decimal oraz Decimal -> Hex");
}

void FinishExercise()
{
    Console.WriteLine("Kliknij enter aby zakonczyc zadanie");
    Console.ReadLine();
    Console.Clear();
}