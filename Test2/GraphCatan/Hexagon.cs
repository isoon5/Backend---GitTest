using System;
using System.Collections.Generic;
using System.Text;

namespace GraphCatan
{
    public enum Resources
    {
        Wheat,
        Sheep,
        Clay,
        Stone,
        Wood,
        Desert
    }

    public class Hexagon
    {
        //private int name;
        private Resources resource;
        public void SetResource(Resources val)
        {
            resource = val;
        }
        public Resources GetResource()
        {
            return resource;
        }

        public int index { get; set; }
        public bool hasThief { get; private set; }
        public int diceNumber { get; set; }
        public List<int> hasRoadWith; //list of hex indices that this hex has a road with
        public List<int> hasSettlementWith;

        public Hexagon(int index)
        {
            this.index = index;
        }
    }
}
