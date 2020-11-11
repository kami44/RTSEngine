using RTSEngine.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.GameObjects.Environment
{
    public class Environment:GameObject
    {
        public Position Position { get; set; }

        public Environment(Position position)
        {
            Position = position;
        }
    }
}
