using System;

namespace Semester
{
    class Program
    {
        static void Main(string[] args)
        {
            var museum = new Graph();
            for (int i = 1; i < 13; i++) museum.AddVertex(i);
            museum.AddEdge(museum.FindVertex(1), museum.FindVertex(2));
            museum.AddEdge(museum.FindVertex(1), museum.FindVertex(3));
            museum.AddEdge(museum.FindVertex(2), museum.FindVertex(3));
            museum.AddEdge(museum.FindVertex(3), museum.FindVertex(5));
            museum.AddEdge(museum.FindVertex(3), museum.FindVertex(4));
            museum.AddEdge(museum.FindVertex(4), museum.FindVertex(8));
            museum.AddEdge(museum.FindVertex(4), museum.FindVertex(5));
            museum.AddEdge(museum.FindVertex(5), museum.FindVertex(6));
            museum.AddEdge(museum.FindVertex(8), museum.FindVertex(7));
            museum.AddEdge(museum.FindVertex(6), museum.FindVertex(7));
            museum.AddEdge(museum.FindVertex(6), museum.FindVertex(9));
            museum.AddEdge(museum.FindVertex(7), museum.FindVertex(9));
            museum.AddEdge(museum.FindVertex(9), museum.FindVertex(10));
            museum.AddEdge(museum.FindVertex(10), museum.FindVertex(11));
            museum.AddEdge(museum.FindVertex(11), museum.FindVertex(12));
            museum.AddEdge(museum.FindVertex(10), museum.FindVertex(12));
            museum.ConclusionGraph();
        }
    }
}
