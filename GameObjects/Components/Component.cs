using RTSEngine.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.GameObjects.Components
{
    public abstract class Component : GameObject
    {
        public string Name { get; set; }
        public IDictionary<Resource, int> ResourceCost {get;set;}

        public Component(string name)
        {
            Name = name;
            ResourceCost = new Dictionary<Resource, int>();
     
        }

        public void AddResourceCost(int cost, Resource resource)
        {
            ResourceCost.Add(resource, cost);
        }
    }
}
