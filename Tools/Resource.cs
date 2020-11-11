using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.Tools
{
    public abstract class Resource
    {
        public string Name { get; set; }

        public Resource(string name)
        {
            Name = name;
        }
    }
}
