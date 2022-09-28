using DungeonsAndDragons.MagazineOfLists;
using DungeonsAndDragons.StuffToGame;

namespace DungeonsAndDragons.CharacterCreator
{
    internal class Creator
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

            int idRace = ChoiceRace.Choice();

            Console.WriteLine($"\nTwój wybór {idRace}");

            var player = ChoiceRace.PlayerWithRace(idRace);

            Console.ReadKey();
        }
    }
}
