using RTSEngine.GameObjects.Characters.Player;
using RTSEngine.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;

namespace RTSEngine.GameObjects.Components.Constructables
{
    public abstract class Unit:Constructable
    {
        public int UnitCount { get; set; }
        public Unit(string name, int damage):base(name, damage)
        {
            
        }
        
    }
}
