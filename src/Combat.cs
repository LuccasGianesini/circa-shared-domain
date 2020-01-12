using System.Collections.Generic;

namespace Circa.Shared.Domain
{
    public class Combat
    {
        //TODO list of monsters.
        public bool Ended { get; set; }
        
        public Queue<InitiativeOrder> InitiativeOrder { get; set; }
        
        public List<PlayerCombatStats> PlayerStats { get; set; }
    }
}