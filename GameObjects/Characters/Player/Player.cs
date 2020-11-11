using RTSEngine.GameObjects.Components.Constructables;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.GameObjects.Characters.Player
{
    public class Player:Character
    {
        public Constructable? Selection { get; set; }
        
        public Player()
        {

        }
    }
}
