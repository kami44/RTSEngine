using RTSEngine.GameObjects.Components.Constructables;
using RTSEngine.GameObjects.Environment.Entities.Controlable.WorldspaceStructure;
using RTSEngine.GameObjects.Environment.Entities.Controlable.WorldspaceUnits;
using RTSEngine.Lists;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.GameObjects
{
    public class Faction
    {
        public string Name { get; set; }
        public List<WorldspaceUnit> WorldspaceUnits { get; private set; }
        public List<WorldspaceStructure> WorldspaceStructures { get; set; }
        public List<Unit> Units { get; set; }
        public List<Building> Buildings { get; set; }
        public Techtree Techtree { get; set; }


        public Faction(string name, Techtree techtree)
        {
            Name = name;
            Techtree = techtree;
            WorldspaceUnits = new List<WorldspaceUnit>();
            WorldspaceStructures = new List<WorldspaceStructure>();
            Units = new List<Unit>();
            Buildings = new List<Building>();
        }

        public void AddWorldSpaceUnit()
        {
           // WorldspaceUnits.Add(new WorldspaceUnit());
        }
    }
}
