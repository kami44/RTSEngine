using RTSEngine.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.GameObjects.Components.Constructables
{
    public abstract class Constructable:Component
    {
        public int Damage { get; set; }
        public Constructable(string name, int damage):base(name)
        {
            Damage = damage;
        }
    }
}
