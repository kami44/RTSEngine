using RTSEngine.GameObjects.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.Lists
{
    public class Techtree
    {
        List<Skill> Skills { get; set; }

        public Techtree()
        {
            Skills = new List<Skill>();
        }
    }
}
