using RTSEngine.GameObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.Lists
{
    public class FactionList
    {
        public IDictionary<string,Faction> Factions { get; private set; }

        public FactionList()
        {
            Factions = new Dictionary<string, Faction>();
            
        }

        public void AddFaction(string name, Techtree techtree)
        {
            Factions.Add(name, new Faction(name, techtree));
        }
      

    }
}
