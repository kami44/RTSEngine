using RTSEngine.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.GameObjects.Components.Constructables
{
    public class Constructable:Component
    {
        public int Damage { get; set; }
        public Constructable(string name, ResourseCost resourseCost, int damage):base(name, resourseCost)
        {
            Damage = damage;
        }
    }
}
