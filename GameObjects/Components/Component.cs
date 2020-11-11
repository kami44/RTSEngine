using RTSEngine.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.GameObjects.Components
{
    public class Component:GameObject
    {
        public string Name { get; set; }
        public ResourseCost ResourseCost { get; set; }

        public Component(string name, ResourseCost resourseCost )
        {
            Name = name;
            ResourseCost = resourseCost;
     
        }
    }
}
