using RTSEngine.GameObjects.Components.Constructables;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.GameObjects.Characters.NPC
{
    public abstract class NPC:Character
    {
        public NPC(string name, Faction faction):base(name, faction)
        {
            
        }

        public virtual void Turn()
        {

        }
    }
}
