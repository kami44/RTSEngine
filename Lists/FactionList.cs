using RTSEngine.GameObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.Lists
{
    public class FactionList
    {
 
        public IDictionary<string,Faction> Factions { get; }
        public int PlayerOwned { get; set; }

        public FactionList()
        {
            Factions = new Dictionary<string, Faction>();
            
        }

        public void AddFaction(string name)
        {
            Factions.Add(name, new Faction(name));
        }
      

    }
}
