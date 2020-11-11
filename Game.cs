using RTSEngine.GameObjects.Components.Constructables;
using RTSEngine.GameObjects.Environment.Entities.Controlable;
using RTSEngine.GameObjects.Environment.Entities.Controlable.WorldspaceUnits;
using RTSEngine.Lists;
using RTSEngine.Tools.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine
{
    public class Game
    {
        public string Name { get; set; }
        public FactionList FactionList { get; set; }
        

        public Game(string name)
        {
            Name = name;
        }

        
        public static CombatOutcome Combat(WorldspaceUnit attacker, Controlable defender)
        {
            
            int attackerDmg = 0;
            int defenderDmg = 0;
            for (int i = 0; i < attacker.Units.Count; i++)
            {
                attackerDmg += attacker.Units[i].Damage;
            }

            for (int i = 0; i < defender.Units.Count; i++)
            {
                defenderDmg += defender.Units[i].Damage;
            }

            if (attackerDmg > defenderDmg)
            {
                return CombatOutcome.Victory;
            }
            else if (attackerDmg < defenderDmg)
            {
                return CombatOutcome.Defeat;
            }
            else 
            { 
                return CombatOutcome.Draw; 
            }
        }

        private static void Casulties()
        {
            // Rund ned med floor så unit overlever 1v1
            // Skal finde en måde at differancere et unit fra et andet unit, f.eks ved type
        }
    }
}
