using DungeonsAndDragons;
using DungeonsAndDragons.ListOfRaces;
using Newtonsoft.Json;
using System;
using System.Diagnostics;

namespace DungeonsAndDragons
{
    public class ChoiceRace
    {
        public static int Race()
        {
            
            var currentDirectory = Directory.GetCurrentDirectory();
            var racesSerializedPath = Path.Combine(currentDirectory, "data", "racesPL.json");
            string racesSerialized = File.ReadAllText(racesSerializedPath);
            Races races = JsonConvert.DeserializeObject<Races>(racesSerialized);

            int idRace = 0;

            do
            {
                bool again = false;
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=======================================================================");
                Console.WriteLine("Jeśli zdecydujesz się na poniższą rasę wciśnij ENTER lub ESC aby wyjść.");
                Console.WriteLine("Następny wybór, wciśnij strzałkę w prawo");
                Console.WriteLine("Poprzedni wybór, wciśnij strzałkę w lewo");
                Console.WriteLine("=======================================================================\n");
                Console.ResetColor();

                Console.Write($"{idRace}. ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(races.ListOfRaces[idRace].Name);
                Console.ResetColor();
                Console.WriteLine(races.ListOfRaces[idRace].Description);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(races.ListOfRaces[idRace].AbilityScoreDescription);
                Console.ResetColor();
                Console.WriteLine(races.ListOfRaces[idRace].SpeedDescription);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Biegłość:");
                Console.ResetColor();
                Console.WriteLine($"{races.ListOfRaces[idRace].Traits}\n");

                if (races.ListOfRaces[idRace].Subraces.Count != 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Występują podrasy: ");
                    Console.ResetColor();

                    foreach (var subRace in races.ListOfRaces[idRace].Subraces)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(subRace.Name);
                        Console.ResetColor();
                        Console.WriteLine(subRace.Description);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(subRace.AbilityScoreDescription);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Biegłość:");
                        Console.ResetColor();
                        Console.WriteLine($"{subRace.Traits}\n");
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=======================================================================");
                Console.WriteLine("Jeśli zdecydujesz się na poniższą rasę wciśnij ENTER lub ESC aby wyjść.");
                Console.WriteLine("Następny wybór, wciśnij strzałkę w prawo");
                Console.WriteLine("Poprzedni wybór, wciśnij strzałkę w lewo");
                Console.WriteLine("=======================================================================\n");
                Console.ResetColor();

                do
                {
                    ConsoleKey choice = Console.ReadKey().Key;

                    switch (choice)
                    {
                        case ConsoleKey.RightArrow:
                            if (idRace != (races.ListOfRaces.Count - 1)) idRace++;
                            else idRace = 0;
                            again = false;
                            break;
                        case ConsoleKey.LeftArrow:
                            if (idRace != 0) idRace--;
                            else idRace = (races.ListOfRaces.Count - 1);
                            again = false;
                            break;
                        case ConsoleKey.Enter:
                            return idRace;
                        case ConsoleKey.Escape:
                            return 999;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nNieznana operacja, wybierz jeszcze raz.");
                            Console.ResetColor();
                            again = true;
                            break;
                    }
                }while (again);
            } while (true);
        }
    }
}