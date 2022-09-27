
namespace DungeonsAndDragons
{
    internal class CharacterCreator
    {
        public static void NewCharacter()
        {
            Console.Clear();
            Console.WriteLine("Znajdujesz się w kreatorze bohatera.");
            Console.WriteLine("Postępuj zgodnie z poleceniami, aby stworzyć swoją postać :)");
            Console.WriteLine("Zacznijmy od czegoś prostego, wybierz swoją rasę wybierając odpowiedni numer:");

            ChoiceRace.Race();

            Console.ReadKey();

        }
    }
}
