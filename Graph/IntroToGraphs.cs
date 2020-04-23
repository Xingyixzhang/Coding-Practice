using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToGraphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph myGraph = new Graph();
            myGraph.AddVertex("Lacey");
        }
    }

    class Pair
    {
        public Vertex vertex { get; set; }
        public int Weight { get; set; }
    }
    
    class Vertex
    {
        public string Name { get; set; }
    }

    class Graph
    {
        List<Vertex> vertices;
        List<List<Pair>> edges;

        public Graph()
        {
            vertices = new List<Vertex>();
            edges = new List<List<Pair>>();
        }

        public void AddVertex(string newName)
        {
            vertices.Add(new Vertex() { Name = newName });
        }

        public void AddEdge(string from, string to, int weight)
        {
            int positionFrom = FindEdgeIndex(from);
            // int positionTo = FindEdgeIndex(to);
            if (edges[positionFrom] == null) edges[positionFrom] = new List<Pair>();
            edges[positionFrom].Add(new Pair() { vertex = new Vertex() { Name = to }, Weight = weight });
        }

        public int FindEdgeIndex(string name)
        {
            for (int i = 0; i < vertices.Count; i++)
            {
                if (vertices[i].Name == name)
                {
                    return i;
                }
            }
            return -1;
        }

        public void RemoveVertex(string newName)
        {
            // Remove Edges before removing the vertex.

            for (int i = 0; i < vertices.Count; i++)
            {
                if (vertices[i].Name == newName)
                {
                    vertices.RemoveAt(i);
                    return;
                }
            }
        }

        public void RemoveEdge(string from, string to)
        {
            int positionFrom = FindEdgeIndex(from);

            for (int i = 0; i < edges[positionFrom].Count; i++)
            {
                if (edges[positionFrom][i].vertex.Name == to)
                { 
                    edges[positionFrom].RemoveAt(i); 
                    return; 
                }
            }
        }
    }
}
