using RTSEngine.GameObjects.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.Lists
{
    public class CharacterList
    {
        public List<Character> Characters { get; set; }

        public CharacterList()
        {
            Characters = new List<Character>();
        }
    }
}
