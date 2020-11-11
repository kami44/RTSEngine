using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine.Tools
{
    public class Route
    {

        public List<Position> Path { get; set; }
        public Position position;

        public Route(List<Position> route)
        {
            Path = route;
        }

        public Position Next()
        {
         
                Position returnValue = Path[0];
                Path.RemoveAt(0);
                return returnValue;
           
        }
    }
}
