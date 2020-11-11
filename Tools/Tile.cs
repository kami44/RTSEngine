using RTSEngine.GameObjects.Environment.Entities;
using RTSEngine.GameObjects.Environment.Terrian;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.Tools
{
    public class Tile
    {
        public Terrain BottomLayer { get; set; }
        public Entity TopLayer { get; set; }
        public Tile(Terrain bottomLayer, Entity topLayer)
        {
            BottomLayer = bottomLayer;
            TopLayer = topLayer;
        }

    }
}
