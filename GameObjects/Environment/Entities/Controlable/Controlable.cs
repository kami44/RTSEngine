using RTSEngine.GameObjects.Characters;
using RTSEngine.GameObjects.Components.Constructables;
using RTSEngine.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.GameObjects.Environment.Entities.Controlable
{
    public abstract class Controlable:Entity
    {
        public Character Owner { get; set; }
        public List<Unit> Units { get; set; }

        public Controlable():base()
        {
            Units = new List<Unit>();
        }
    }
}
