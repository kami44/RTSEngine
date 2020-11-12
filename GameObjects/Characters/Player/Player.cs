using RTSEngine.GameObjects.Components.Constructables;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.GameObjects.Characters.Player
{
    public abstract class Player:Character
    {
        public Constructable? Selection { get; set; }
        
        public Player(string name, Faction faction):base(name, faction)
        {
            this.MyTurn = true;
        }
    }
}
