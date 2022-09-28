using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DungeonsAndDragons.MagazineOfLists
{
    internal class Characters
    {
        public int Count { get { return Character.Count(); } }

        [JsonPropertyName("ListOfRaces")]
        public List<ListOfCharacters> Character { get; set; }
    }

    internal class ListOfCharacters
    {
        public string NameOfRace { get; set; }
        public List<NameAndSurname> NameAndSurname { get; set; }
        public double Size { get; set; }
        public double Age { get; set; }
        public string DesriptionAppearance { get; set; }
        public string Alignment { get; set; }
        public string Description { get; set; }
        public List<Languages> Laguage { get; set; }
        public List<Visions> Vision { get; set; }
        public List<Traits> Trait { get; set; }
        public AbilityScores AbilityScore { get; set; }
        public Skills Skill { get; set; }
    }

    internal class NameAndSurname
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Other { get; set; }
    }

    internal class Languages
    {
        public string Name { get; set; }
        public bool Value { get; set; }
    }

    internal class Visions
    {
        public string TypeOfVision { get; set; }
        public double RangeOfVision { get; set; }
    }

    internal class Traits
    {
        public string NameOfTrait { get; set; }
    }

    internal class AbilityScores
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
    }
    internal class Skills
    {
        public int AcrobaticsDex { get; set; }
        public int AnimalHandingWis { get; set; }
        public int ArcanaInc { get; set; }
        public int AthleticsStr { get; set; }
        public int DeceptionCha { get; set; }
        public int HistoryInt { get; set; }
        public int InsightWis { get; set; }
        public int IntimidationCha { get; set; }
        public int InvestigationInt { get; set; }
        public int MedicineWis { get; set; }
        public int NatureInt { get; set; }
        public int PerceptionWis { get; set; }
        public int PerformanceCha { get; set; }
        public int PersuasionCha { get; set; }
        public int ReligionInt { get; set; }
        public int SleightOfHandDex { get; set; }
        public int StealthDex { get; set; }
        public int SurvivalWis { get; set; }
    }
}
