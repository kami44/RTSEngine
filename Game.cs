using RTSEngine.GameObjects.Characters;
using RTSEngine.GameObjects.Characters.NPC;
using RTSEngine.GameObjects.Components.Constructables;
using RTSEngine.GameObjects.Environment.Entities.Controlable;
using RTSEngine.GameObjects.Environment.Entities.Controlable.WorldspaceStructure;
using RTSEngine.GameObjects.Environment.Entities.Controlable.WorldspaceUnits;
using RTSEngine.GameObjects.Environment.Entities.Noncontrolable;
using RTSEngine.Lists;
using RTSEngine.Tools;
using RTSEngine.Tools.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine
{
    public class Game
    {
        public static int Turn = 0;
        public static int WhosTurn = 0;
        public string Name { get; set; }
        public Worldspace Worldspace { get; set; }
        public FactionList FactionList { get; set; }
        public static CharacterList CharacterList { get; set; }
        
        public Game(string name)
        {
            Name = name;
            Worldspace = Worldspace.Instance;
            FactionList = new FactionList();
            CharacterList = new CharacterList();
        }

        
        public static CombatOutcome Combat(WorldspaceUnit attacker, Controlable defender, Worldspace worldspace)
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
                worldspace.Space[defender.Position.X, defender.Position.Y].TopLayer = new EmptySpace();
                if (defender.GetType() == typeof(WorldspaceUnit))defender.Owner.ActiveUnits.Remove((WorldspaceUnit)defender) ;
                else defender.Owner.ActiveStructures.Remove((WorldspaceStructure)defender);
                Casulties(defenderDmg / attackerDmg, attacker);
                return CombatOutcome.Victory;
            }
            else if (attackerDmg < defenderDmg)
            {
                worldspace.Space[attacker.Position.X, attacker.Position.Y].TopLayer = new EmptySpace();
                attacker.Owner.ActiveUnits.Remove(attacker);
                Casulties(attackerDmg / defenderDmg, defender);
                return CombatOutcome.Defeat;
            }
            else 
            {
                worldspace.Space[defender.Position.X, defender.Position.Y].TopLayer = new EmptySpace();
                worldspace.Space[attacker.Position.X, attacker.Position.Y].TopLayer = new EmptySpace();
                if (defender.GetType() == typeof(WorldspaceUnit)) defender.Owner.ActiveUnits.Remove((WorldspaceUnit)defender);
                else defender.Owner.ActiveStructures.Remove((WorldspaceStructure)defender);
                attacker.Owner.ActiveUnits.Remove(attacker);
                return CombatOutcome.Draw; 
            }
        }

        private static void Casulties(float victoryScore, Controlable target)
        {
            foreach (Unit unit in target.Units)
            {
                float UnitCount = unit.UnitCount;
                UnitCount -= UnitCount*victoryScore;
                unit.UnitCount = Convert.ToInt32(Math.Floor(UnitCount));
            }
            
        }

        public static void ChangeTurn()
        {
            CharacterList.Characters[WhosTurn].MyTurn = false;
            Turn++;
            WhosTurn = Turn % CharacterList.Characters.Count;
            CharacterList.Characters[WhosTurn].MyTurn = true;
            if (CharacterList.Characters[WhosTurn].GetType().BaseType == typeof(NPC)) ((NPC)CharacterList.Characters[WhosTurn]).Turn();
        }

    }
}
