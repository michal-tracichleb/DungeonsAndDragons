namespace DungeonsAndDragons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Witaj poszukiwaczu przygód w D&D.\nPrzeżyjesz tutaj swoją przygodę w świecie RPG.\nŻyczę miłej zabawy!\n");
                Console.WriteLine("Poniżej proste menu, wciśnij na klawiaturze odpowiedni klawisz, aby wybrać polecenie.");
                Console.WriteLine(@"1. Nowa gra
2. Wczytaj grę
3. Stwórz histrorię paragrafową
4. Stwórz postać
ESC. Zakończ");
                ConsoleKey choice = Console.ReadKey().Key;

                switch (choice)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        Console.Clear();                        
                        Console.WriteLine("Tutaj kiedyś będzie można rozpoczynać się nowa gra!");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Tutaj kiedyś będzie można wczytywać się grę!");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("Tutaj kiedyś będzie można stworzyć nową historię paragrafową!");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("Tutaj kiedyś będzie można stworzyć swoją unikatową postać!");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.Escape:
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Czy na pewno chcesz zakończyć działanie konsoli?");
                            Console.ResetColor();
                            Console.WriteLine("Naciśnij 'T' - Tak lub 'N' - Nie.");
                            choice = Console.ReadKey().Key;
                            if (choice == ConsoleKey.T) break;
                            if (choice == ConsoleKey.N) break;
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Niepoprawny klawisz, dokonaj wyboru jeszcze raz.");
                                Console.ResetColor();
                                choice = Console.ReadKey().Key;
                                if (choice == ConsoleKey.T) break;
                                if (choice == ConsoleKey.N) break;
                            } while (true);
                            if (choice == ConsoleKey.T) break;
                            if (choice == ConsoleKey.N) break;
                        } while (true);
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nieznana operacja, naciśnij cokolwiek aby wrócić do menu.");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                }
                if (choice == ConsoleKey.T) break;
            } while (true);
        }
    }
}