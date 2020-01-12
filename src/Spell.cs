using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Circa.Shared.Domain
{
    public class Spell : BasicInformation
    {
        public int Cycle { get; set; }
        public int CastingTimeInAction { get; set; }
        public int CastingRangeInFeet { get; set; }
        public List<SpellComponent> Components { get; set; }
        public string SpellType { get; set; }
        public List<string> Targets { get; set; }
        public int Duration { get; set; }
        public bool IsConcentrationSpell { get; set; }
        public bool IsRoundSpell { get; set; }
        public List<string> SavingsThrows { get; set; }
        public bool SpellResistance { get; set; }
    }
}