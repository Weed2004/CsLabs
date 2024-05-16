using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class Node
{
    public List<(int,Node)> connections = new List<(int,Node)>();

    public Point Position { get; set; }
    public string Name { get; set; }

    public void AddConnection(int weight, Node node)
    {
        if (!ChechConnection(node))
        {
            connections.Add((weight, node));
        }
        else
        {
            Logger.Print($"Связь с узлом {node.Name} уже существует");
        }
    }

    public bool ChechConnection(Node node)
    {
        foreach (var connection in connections)
        {
            if(connection.Item2 == node)
            {
                return true;
            }
        }
        return false;
    }

    public void SetConnection(int weight, Node node)
    {
        if(ChechConnection(node))
        {
            connections[GetIndex(node)] = (weight, node);
        }
        else
        {
            Logger.Print($"Узлы {this.Name} и {node.Name} не связаны");
        }
    }

    public void RemoveConnection(Node node)
    {
        if (ChechConnection(node))
        {
            connections.RemoveAt(GetIndex(node));
        }
        else
        {
            Logger.Print($"Узлы {this.Name} и {node.Name} не связаны");
        }
    }

    public int GetConnetionWeight(Node node)
    {
        if (ChechConnection(node))
        {
            return connections[GetIndex(node)].Item1;
        }
        else
        {
            Logger.Print($"Узлы {this.Name} и {node.Name} не связаны");
            return -1;
        }
    }

    public int GetIndex(Node node)
    {
        foreach(var connection in connections)
        {
            if(connection.Item2 == node)
            {
                return connections.IndexOf(connection);
            }
        }
        return -1;
    }

    public Node(string name)
    {
        Name = name;
        Position = new Point(0,0);
    }

    public IEnumerable<(int,Node)> Connections()
    {
        foreach(var connection in connections)
        {
            yield return connection;
        }
    }
}
