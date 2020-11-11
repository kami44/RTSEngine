using RTSEngine.GameObjects;
using RTSEngine.GameObjects.Characters;
using RTSEngine.GameObjects.Characters.Player;
using RTSEngine.GameObjects.Environment.Entities.Controlable.WorldspaceUnits;
using RTSEngine.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine
{
    public class Worldspace
    {
        public static Tile[,] Space { get; set; }


        public static void Movement(WorldspaceUnit unit)
        {
            for (int i = 0; i < unit.Route.Path.Count; i++)
            {
                Position oldPosition = unit.Position;
                Position newPosition = unit.Route.Next();
                unit.Position = newPosition;
                Space[newPosition.X, newPosition.Y].TopLayer = unit;
                Space[oldPosition.X, oldPosition.Y].TopLayer = null;
            }
            unit.Route = null;
        }

        public void Interact(WorldspaceUnit target, Player owner)
        {
            if (true)
            {

            }
        }
    }
}
