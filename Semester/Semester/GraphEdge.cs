using System;
using System.Collections.Generic;
using System.Text;

namespace Semester
{
    class GraphEdge
    {
        public GraphVertex FirstVertex { get; }
        public GraphVertex SecondVertex { get; }
        public int Weight { get; set; }
        public GraphEdge(GraphVertex firstVertex, GraphVertex secondVertex)
        {
            FirstVertex = firstVertex;
            SecondVertex = secondVertex;
        }
        public override string ToString() => FirstVertex.ToString() + " - " + SecondVertex.ToString();
    }
}
