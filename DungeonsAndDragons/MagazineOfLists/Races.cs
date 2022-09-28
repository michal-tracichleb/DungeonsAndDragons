using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DungeonsAndDragons.MagazineOfLists
{
    internal class Races
    {
        public int Count { get { return ListOfRaces.Count(); } }

        [JsonPropertyName("ListOfRaces")]
        public List<ListOfRaces> ListOfRaces { get; set; }
    }
    internal class ListOfRaces
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string AbilityScoreDescription { get; set; }
        public List<AbilityScore> AbilityScore { get; set; }
        public string AgeDescription { get; set; }
        public string AlignmentDescription { get; set; }
        public string SizeDescription { get; set; }
        public string SpeedDescription { get; set; }
        public decimal SpeedWalk { get; set; }
        public string LanguagesDescription { get; set; }
        public string VisionDescription { get; set; }
        public string Traits { get; set; }
        public string SampleNamesSurnames { get; set; }
        public List<Subraces> Subraces { get; set; }
    }
    internal class AbilityScore
    {
        public string Name { get; set; }
        public int Valure { get; set; }
    }
    internal class Subraces
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string AbilityScoreDescription { get; set; }
        public List<AbilityScore> AbilityScore { get; set; }
        public string Traits { get; set; }
    }
}
