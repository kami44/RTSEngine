using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.Tools
{
    public class ResourseCost
    {
        public int Cost { get; set; }
        public Resource Resource;

        public ResourseCost(int cost, Resource resource)
        {
            Cost = cost;
            Resource = resource;

        }

    }
}
