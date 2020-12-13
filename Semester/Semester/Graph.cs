using System;
using System.Collections.Generic;
using System.Text;

namespace Semester
{
    class Graph
    {
        public List<GraphVertex> Vertexes { get; }
        public Graph()
        {
            Vertexes = new List<GraphVertex>();
        }
        public void AddEdge(GraphVertex firstVertex, GraphVertex secondVertex)
        {
            firstVertex.ConnectedEdges.Add(new GraphEdge(firstVertex, secondVertex));
            secondVertex.ConnectedEdges.Add(new GraphEdge(secondVertex, firstVertex));
        }
        public void AddVertex(string vertexName)
        {
            Vertexes.Add(new GraphVertex(vertexName));
        }
        public void AddVertex(int vertexNum)
        {
            Vertexes.Add(new GraphVertex(vertexNum));
        }
        public void ConclusionGraph()
        {
            foreach (var vertex in Vertexes)
            {
                Console.WriteLine(vertex + " ");
                foreach (var edges in vertex.ConnectedEdges)
                {
                    Console.WriteLine(edges);
                }
            }
        }

        public GraphVertex FindVertex(string vertexName)
        {
            foreach (var vertex in Vertexes) if (vertex.Name == vertexName) return vertex;
            Console.WriteLine("Точка с таким именем не найдена. Был возвращен null");
            return null;
        }
        public GraphVertex FindVertex(int vertexNum)
        {
            foreach (var vertex in Vertexes) if (vertex.Name == vertexNum.ToString()) return vertex;
            Console.WriteLine("Точка с таким именем не найдена. Был возвращен null");
            return null;
        }
    }
}