using System;

namespace maptest 
{
    enum Resources
    {
        Wheat,
        Sheep,
        Clay,
        Stone,
        Wood,
        Desert
    }

    public class Hex
    {
        private Resources resource;
        public void SetResource(Resources val)
        {
            resource = val;
        }
        public Resources GetResource()
        {
            return resource;
        }


        public int index {get;set;}
        public bool hasThief {get; private set;}
        public int diceNumber {get;set;}
        public List<int> hasRoadWith; //list of hex indices that this hex has a road with
        public List<int> hasSettlementWith;

        public Hex(int index)
        {
            this.index = index;
        }
    }

    
    public class GameMap
    {
        public List<Hex> hexes {get; private set;}

        public int noOfHexes {get;set;}

        public void GenerateMap() {}
    }


    public class Road
    {
        public int nborIndex1;
        public int nborIndex2;
        //public Player owner {get;set};

        public Road(int index1, int index2)
        {
            //validari placement corect
            //asigneaza ownerului
        }
    }

    enum SettlementType 
    {
        VILLAGE,
        CITY
    }
    public class Settlement
    {
        private SettlementType settlementType;
        
        public void setSettlementType(SettlementType st)
        {
            settlementType = st;
        }
        public SettlementType getSettlementType()
        {
            return settlementType;
        }

        private int points {get;set;}

        public int nborIndex1;
        public int nborIndex2;
        public int nborIndex3;

        public Settlement(int index1, int index2, int index3)
        {
            //verificari, validari placement corect
            //etc
        }
    }

    public class Port 
    {
        public Resources tradeResource;
        public int resourcesNeeded;
        public int nborIndex1;
        public int nborIndex2;

        public Port(int index1, int index2, Resources resource, int resourceNumber)
        {
            tradeResource = resource;
            nborIndex1 = index1;
            nborIndex2 = index2;
            tradeResource = resource;
        }

    }

}