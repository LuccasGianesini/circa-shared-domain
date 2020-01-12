using System.Collections;
using System.Collections.Generic;

namespace Circa.Shared.Domain
{
    public class PlayerCombatStats
    {
        public string CharId { get; set; }
        public string CombatId { get; set; }
        public Stack<int> DamageTaken { get; set; }
        public Stack<int> DamageInferred { get; set; }
        public int CurrentHp { get; set; }
        public int TotalHp { get; set; }
        public Dictionary<int, int> UsedSpellSlots { get; set; }
    }
}