using BuildingNode;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace GraphCatan
{
    public class Node<T>
    {
        private T name;
        private bool hasSettlement;

        /*public NodeList<T> myNeighbors { get; }  // neighbouring nodes*/
        public NodeList<T> neighbors { get; }
       
        /*public Node(int initialSize)
        {
            // Add the specified number of items
            for (int i = 0; i < initialSize; i++)
                base.Items.Add(default(Node<T>));
        }*/

        //public Settlement ownSettlement{ get; set; } // the building

        public Node(T name)
        {
            this.name = name;
        }

        public T myName
        {
            get { return name; }
            set { name = value; }
        } // name composed of the three adjacent hexagons, with a * separator, such as "*1*3*-9*"
        
        public bool myHasSettlement
        {
            get { return hasSettlement; }
            set { hasSettlement = value; }
        } 

    }

    public class NodeList<T> : Collection<Node<T>>
    {
        public NodeList() : base() { }

        public NodeList(int initialSize)
        {
            // Add the specified number of items
            for (int i = 0; i < initialSize; i++)
                base.Items.Add(default(Node<T>));
        }
    }

    public class Graph<T> : IEnumerable<T>
    {
        public NodeList<T> Nodes { get; }
        public Graph() : this(null) { }
        public Graph(NodeList<T> nodeSet)
        {
            if (nodeSet == null)
                this.Nodes = new NodeList<T>();
            else
                this.Nodes = nodeSet;
        }

    public int Count
        {
            get { return Nodes.Count; }
        }

        public void AddNode(Node<T> node)
        {
            // adds a node to the graph
            Nodes.Add(node);
        }

        public void AddNode(T value)
        {
            // adds a node to the graph
            Nodes.Add(new Node<T>(value));
        }

        public void AddUndirectedEdge(Node<T> from, Node<T> to)
        {
            from.neighbors.Add(to);

            to.neighbors.Add(from);
        }
        /*public void AddDirectedEdge(Node<T> from, String to)
        {
            from.Neighbors.Add(to);
        }*/

       /* public void AddUndirectedEdge(Node<T> from, Node<T> to)
        {
            from.Neighbors.Add(to);

            to.Neighbors.Add(from);
        }*/

        /*public bool Contains(T value)
        {
            //return Nodes.FindByValue(value) != null;
        }*/

        /*public bool Remove(T value)
        {
            // first remove the node from the nodeset
            Node<T> nodeToRemove = (Node<T>)Nodes.FindByValue(value);
            if (nodeToRemove == null)
                // node wasn't found
                return false;

            // otherwise, the node was found
            Nodes.Remove(nodeToRemove);

            // enumerate through each node in the nodeSet, removing edges to this node
            foreach (Node<T> gnode in Nodes)
            {
                int index = gnode.Neighbors.IndexOf(nodeToRemove);
                if (index != -1)
                {
                    // remove the reference to the node and associated cost
                    gnode.Neighbors.RemoveAt(index);
                }
            }

            return true;
        }*/

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


    }
}
