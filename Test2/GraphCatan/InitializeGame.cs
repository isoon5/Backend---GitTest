using BuildingNode;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using static GraphCatan.Node<T>;
using static GraphCatan.NodeList<T>;
using static GraphCatan.Graph<T>;

namespace GraphCatan
{
    class InitializeGame
    {
        private int winningPoints { get; set; }
        private String gameType { get; set; }

        public int myWinningPoints
        {
            get { return winningPoints; }
            set { winningPoints = value; }
        }
        public String mygameType
        {
            get { return gameType; }
            set { gameType = value; }
        }

        public InitializeGame(int winningPoints, String gameType)
        {
            this.winningPoints = winningPoints;
            this.gameType = gameType;
            Init(winningPoints, gameType);
        }

        public void Init(int winningPoints, String gameType)
        {
            Graph<string> graph = new Graph<string>();

            var nodesPath = Path.Combine(Directory.GetCurrentDirectory(), "BaseNodes.txt"); // initialize the path with the basegame
            if (gameType == "Base Game")
            {
                nodesPath = Path.Combine(Directory.GetCurrentDirectory(), "BaseNodes.txt"); //insert all the nodes' names

            }
            else
            {
                nodesPath = Path.Combine(Directory.GetCurrentDirectory(), "BaseNodes.txt");
            }

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(nodesPath);
            while ((line = file.ReadLine()) != null)
            {
                graph.AddNode(line);
                Console.WriteLine(graph.Nodes[graph.Nodes.Count - 1].myName);
            }

            graph.AddUndirectedEdge(graph.Nodes[0], graph.Nodes[1]);  // People -> Privacy

        }
    }
}
