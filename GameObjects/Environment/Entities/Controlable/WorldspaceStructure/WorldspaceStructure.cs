using RTSEngine.GameObjects.Components.Constructables;
using RTSEngine.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RTSEngine.GameObjects.Environment.Entities.Controlable.WorldspaceStructure
{
    public abstract class WorldspaceStructure:Controlable
    {
        public List<Building> Buildings { get; set; }

        public WorldspaceStructure() : base()
        {
            Buildings = new List<Building>();
            
        }

        public void BuyBuilding(Building building)
        { 
            foreach (var item in building.ResourceCost)
            {
                var linq = Owner.Resources.Where(x => x.Key.GetType() == item.Key.GetType()).FirstOrDefault();
                int cost = linq.Value - item.Value;
                Resource resource = linq.Key;
                Owner.Resources.Remove(linq);
                Owner.Resources.Add(resource, cost);
            }
        }

    }
}
