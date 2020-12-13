using System;
using System.Collections.Generic;
using System.Text;

namespace Semester
{
    class GraphVertex
    {
        public string Name { get; }
        public List<GraphEdge> ConnectedEdges { get; }
        public GraphVertex(string vertexName)
        {
            Name = vertexName;
            ConnectedEdges = new List<GraphEdge>();
        }
        public GraphVertex(int vertexNum)
        {
            Name = vertexNum.ToString();
            ConnectedEdges = new List<GraphEdge>();
        }
        public void AddEdge(GraphVertex connectedVertex)
        {
            ConnectedEdges.Add(new GraphEdge(this, connectedVertex));
            connectedVertex.ConnectedEdges.Add(new GraphEdge(connectedVertex, this));
        }
        public override string ToString() => Name;
    }
}
