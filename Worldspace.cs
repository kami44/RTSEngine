using RTSEngine.GameObjects;
using RTSEngine.GameObjects.Characters;
using RTSEngine.GameObjects.Characters.Player;
using RTSEngine.GameObjects.Environment.Entities.Controlable.WorldspaceUnits;
using RTSEngine.GameObjects.Environment.Entities.Noncontrolable;
using RTSEngine.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTSEngine
{
    public class Worldspace
    {
        private static int _maxX = 100;
        private static int _maxY = 100;


        private static Worldspace _instance;
        public static int MaxX { get { return _maxX; } set { _maxX = value; } }
        public static int MaxY { get { return _maxY; } set { _maxY = value; } }
        public Tile[,] Space { get; set; }
        public static Worldspace Instance
        {
            get
            {
                if (_instance == null) _instance = new Worldspace();
                return _instance;
            } 
        }



        private Worldspace()
        {
            Space = new Tile[_maxX, _maxY];
        }


    }
}
