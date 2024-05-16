using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

[Serializable]
public class Graph
{
    public List<Node> nodes = new List<Node>();

    public Node? CreateNode(string name)
    {
        foreach (var node in nodes)
        {
            if (node.Name == name)
            {
                Logger.Print($"Узел с именем {name} уже существует");
                return null;
            }
        }

        Node newNode = new Node(name);
        nodes.Add(newNode);
        return newNode;
    }

    public void Connect(Node node1, Node node2, int weight)
    {
        if (!nodes.Contains(node1))
        {
            Logger.Print($"{node1.Name} не существует");
            return;
        }
        if(!nodes.Contains(node2))
        {
            Logger.Print($"{node2.Name} не существует");
            return;
        }

        node1.AddConnection(weight, node2);
        node2.AddConnection(weight, node1);
    }

    public void RemoveConnection(Node node1, Node node2)
    {
        if (!nodes.Contains(node1))
        {
            Logger.Print($"{node1.Name} не существует");
            return;
        }
        if (!nodes.Contains(node2))
        {
            Logger.Print($"{node2.Name} не существует");
            return;
        }

        node1.RemoveConnection(node2);
        node2.RemoveConnection(node1);
    }

    public void RemoveNode(Node node)
    {
        if (!nodes.Contains(node))
        {
            Logger.Print($"{node.Name} не существует");
            return;
        }

        nodes.Remove(node);
        foreach(var currentNode in nodes)
        {
            if (currentNode.ChechConnection(node))
            {
                currentNode.RemoveConnection(node);
            }
        }
    }

    public void SetConnectionWeight(Node node1, Node node2, int weight)
    {
        if (!nodes.Contains(node1))
        {
            Logger.Print($"{node1.Name} не существует");
            return;
        }
        if (!nodes.Contains(node2))
        {
            Logger.Print($"{node2.Name} не существует");
            return;
        }

        node1.SetConnection(weight, node2);
        node2.SetConnection(weight, node1);
    }

    public IEnumerable<Node> Nodes()
    {
        foreach(var node in nodes)
        {
            yield return node;
        }
    }

    public int NumOfNodes()
    {
        return nodes.Count;
    }

    public Node? GetNode(string name)
    {
        foreach(var node in nodes)
        {
            if(node.Name == name)
            {
                return node;
            }
        }
        Logger.Print($"Узла {name} не существаует");
        return null;
    }
}
