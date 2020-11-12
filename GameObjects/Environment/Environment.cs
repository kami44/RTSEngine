using RTSEngine.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.GameObjects.Environment
{
    public abstract class Environment:GameObject
    {
        public Position Position { get; set; }

        public Environment()
        {
          
        }
    }
}
