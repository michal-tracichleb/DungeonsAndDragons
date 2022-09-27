
namespace DungeonsAndDragons
{
    internal class CharacterCreator
    {
        public static void NewCharacter()
        {
            Console.Clear();
            Console.WriteLine("Znajdujesz się w kreatorze bohatera.");
            Console.WriteLine("Postępuj zgodnie z poleceniami, aby stworzyć swoją postać :)");
            Console.WriteLine("Zacznijmy od czegoś prostego, wybierz swoją rasę.");
            Console.WriteLine("Gotowy? Wciśnij cokolwiek na klawiarze lub ESC by wyjść do menu.");

            ConsoleKey choice = Console.ReadKey().Key;

            if (choice == ConsoleKey.Escape) return;

            int idRace = ChoiceRace.Race();

            Console.WriteLine($"Wybrałeś {idRace}");

            Console.ReadKey();
        }
    }
}
