using RTSEngine.GameObjects.Characters.Player;
using RTSEngine.GameObjects.Components.Constructables;
using RTSEngine.GameObjects.Environment.Entities.Noncontrolable;
using RTSEngine.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RTSEngine.GameObjects.Environment.Entities.Controlable.WorldspaceUnits
{
    public abstract class WorldspaceUnit:Controlable
    {
        public int ActionPoints { get; set; }
        public int MaxActionPoints { get; set; }
        public Route? Route { get; set; }
        public Worldspace Worldspace { get; set; }
       
        public WorldspaceUnit(int actionPoints):base()
        {
            ActionPoints = actionPoints;
            MaxActionPoints = actionPoints;
            Route = null;
            Worldspace = Worldspace.Instance;
            Position = new Position(0,0);
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
                    Game.Combat(this, target, Worldspace);
                }
            }
        }

        public void Move()
        {
            
            for (int i = 0; i < Route.Path.Count; i++)
            {
                if (ActionPoints <= 0) break;
                Position oldPosition = Position;
                Position newPosition = Route.Next();
                Position = newPosition;
                Worldspace.Space[newPosition.X, newPosition.Y].TopLayer = this;
                //Worldspace.Space[oldPosition.X, oldPosition.Y].TopLayer = new EmptySpace(oldPosition);
                Worldspace.Space[oldPosition.X, oldPosition.Y].TopLayer = new EmptySpace();
                ActionPoints--;
            }

            if(ActionPoints > 0) Route = null;

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

            if (X >= 0)
            {
                for (int i = this.Position.X + 1; i < destination.X; i++)
                {
                    returnRoute.Add(new Position(i, Y));
                }
            }
            else
            {
                for (int i = this.Position.X - 1; i >= destination.X; i--)
                {
                    returnRoute.Add(new Position(i, Y));
                }
            }
            if (Y >= 0)
            {
                for (int i = this.Position.Y + 1; i < destination.Y; i++)
                {
                    returnRoute.Add(new Position(X, i));
                }
            }
            else
            {
                for (int i = this.Position.Y - 1; i >= destination.Y; i--)
                {
                    returnRoute.Add(new Position(X, i));
                }
            }


            return new Route(returnRoute);
        }

    }
}
