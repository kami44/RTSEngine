using RTSEngine.GameObjects.Characters.Player;
using RTSEngine.GameObjects.Components.Constructables;
using RTSEngine.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RTSEngine.GameObjects.Environment.Entities.Controlable.WorldspaceUnits
{
    public class WorldspaceUnit:Controlable
    {
        public int actionPoints { get; set; }
        public Route? Route { get; set; }
        
       
        public WorldspaceUnit(Position position):base(position)
        {
            Route = null;
            
        }
        
        //Action
        public void Attack(Controlable target)
        {
            //tjekker om positionen er 1 tile væk
            if ((Position.X == target.Position.X+1||Position.X == target.Position.X-1 || Position.X == target.Position.X)&&(Position.Y == target.Position.Y+1 || Position.Y == target.Position.Y-1 || Position.Y == target.Position.Y))
            {
                // tjek hvis den ikke er diagonal og ikke sig selv
                if (target.Position.X != Position.X ^ target.Position.Y != Position.Y)
                {
                    Game.Combat(this, target);
                }
            }
        }

        public void Move()
        {
            Worldspace.Movement(this);
            for (int i=0; 1 < Route.Path.Count; i++)
            {
                this.Position = Route.Next();
            }
            Route = null;
        }


        public void SetRoute(Position destination)
        {
            Route = PathFind(destination);
        }


        //Misc
        public Route PathFind(Position destination)
        {
            List<Position> returnRoute = new List<Position>();
            int X = destination.X - this.Position.X;
            int Y = destination.Y - this.Position.Y;

            //mangler else, Y if
            if (X > 0)
            {
                for (int i = this.Position.X + 1; i <= destination.X; i++)
                {
                    returnRoute.Add(new Position(X, Y));
                }
            }
            

            return new Route(returnRoute);
        }

    }
}
