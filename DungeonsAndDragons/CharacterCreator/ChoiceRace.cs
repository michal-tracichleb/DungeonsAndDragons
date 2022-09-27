using DungeonsAndDragons;
using DungeonsAndDragons.ListOfRaces;
using Newtonsoft.Json;
using System;

namespace DungeonsAndDragons
{
    public class ChoiceRace
    {
        public static void Race()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var racesSerializedPath = Path.Combine(currentDirectory, "data", "racesPL.json");
            string racesSerialized = File.ReadAllText(racesSerializedPath);

            Races races = JsonConvert.DeserializeObject<Races>(racesSerialized);

            int idRace = -1;
            foreach (var race in races.ListOfRaces)
            {
                idRace += 1;
                Console.Write($"{idRace}. ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(race.Name);
                Console.ResetColor();
                Console.WriteLine(race.Description);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(race.AbilityScoreDescription);
                Console.ResetColor();
                Console.WriteLine(race.SpeedDescription);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Biegłość:");
                Console.ResetColor();
                Console.WriteLine($"{race.Traits}\n");



                if (race.Subraces.Count != 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;                    
                    Console.WriteLine("\nWystępują podrasy: ");
                    Console.ResetColor();

                    foreach (var subRace in race.Subraces)
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
            }

        }
    }
}