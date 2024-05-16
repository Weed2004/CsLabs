using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal static class DijkstraАlgorithm
    {
        public static Graph PathFind(Graph graph, Node start, Node end)
        {
            Graph result = new Graph();
            List<Node> nodes = new List<Node>();
            List<Node> parents = new List<Node>();
            List<int> weights = new List<int>();
            List<bool> passed = new List<bool>();

            foreach(var node in graph.Nodes())
            {
                nodes.Add(node);
                parents.Add(null);
                weights.Add(int.MaxValue);
                passed.Add(false);
            }

            int currentIndex = nodes.IndexOf(start);
            weights[currentIndex] = 0;
            while (currentIndex!=-1)
            {
                int currentWeight = weights[currentIndex];
                Node currentNode = nodes[currentIndex];

                foreach(var connection in currentNode.Connections())
                {
                    int connectionIndex = nodes.IndexOf(connection.Item2);

                    if (connection.Item1 + currentWeight < weights[connectionIndex])
                    {
                        weights[connectionIndex] = connection.Item1 + currentWeight;
                        parents[connectionIndex] = currentNode;
                    }
                }
                passed[currentIndex] = true;

                currentIndex = -1;
                currentWeight = int.MaxValue;
                for(int i= 0;i<passed.Count;i++)
                {
                    if (passed[i] == false && weights[i] < currentWeight)
                    {
                        currentIndex = i;
                    }
                }
            }

            currentIndex = nodes.IndexOf(end);
            Node node1 = nodes[currentIndex];
            Node parent = parents[currentIndex];
            Logger.Print($"Минимальный вес пути: {weights[currentIndex]}");
            while(parent != null)
            {
                Node resultNode = result.CreateNode(node1.Name);

                if(resultNode == null)
                {
                    resultNode = result.GetNode(node1.Name);
                }

                Node resultParent = result.CreateNode(parent.Name);

                result.Connect(resultParent,resultNode,parent.GetConnetionWeight(node1));

                currentIndex = nodes.IndexOf(parent);
                node1 = nodes[currentIndex];
                parent = parents[currentIndex];
            }

            return result;
        }
    }
}
