using RTSEngine.GameObjects.Components.Constructables;
using RTSEngine.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.GameObjects.Environment.Entities.Controlable.WorldspaceStructure
{
    public class WorldspaceStructure:Entity
    {
        public List<Building> Buildings { get; set; }

        public WorldspaceStructure(Position position) : base(position)
        {
            Buildings = new List<Building>();
            
        }

    }
}
