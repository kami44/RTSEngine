using RTSEngine.GameObjects.Environment.Entities.Controlable.WorldspaceStructure;
using RTSEngine.GameObjects.Environment.Entities.Controlable.WorldspaceUnits;
using RTSEngine.Lists;
using RTSEngine.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.GameObjects.Characters
{
    public abstract class Character:GameObject
    {
        public bool MyTurn { get; set; }
        public string Name { get; set; }
        public Faction Faction { get; set; }
        public IDictionary<Resource, int> Resources { get; set; }
        public List<WorldspaceUnit> ActiveUnits { get; set; }
        public List<WorldspaceStructure> ActiveStructures { get; set; }

        public Character(string name, Faction faction)
        {
            Name = name;
            Faction = faction;
            MyTurn = false;
            Resources = new Dictionary<Resource, int>();
            ActiveStructures = new List<WorldspaceStructure>();
            ActiveUnits = new List<WorldspaceUnit>();
        }

        public void EndTurn() 
        {
            Game.ChangeTurn();
        }
    }
}
