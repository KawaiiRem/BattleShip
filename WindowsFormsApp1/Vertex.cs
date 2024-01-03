using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Vertex
    {
        private Tile tile;
        private List<Edge> edges;

        public Vertex(Tile tile)
        {
            this.tile = tile;
            edges = new List<Edge>();
        }

        public void addEdge(Vertex endVertex)
        {
            edges.Add(new Edge(this, endVertex));
        }

        public void removeEdge(Vertex endVertex)
        {
            Edge edge = new Edge(this, endVertex);
            edges.Remove(edge);
        }
        public Tile getTile()
        {
            return tile;
        }
    }
}
