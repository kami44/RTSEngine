using RTSEngine.Lists;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.GameObjects.Characters
{
    public class Character:GameObject
    {
        public string Name { get; set; }
        public Faction Faction { get; set; }
        public void EndTurn() { }
    }
}
