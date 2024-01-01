using MineSweaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Graph
    {
        private List<Vertex> vertices;
        public Graph() 
        {
        vertices = new List<Vertex>();
        }
        public void addVertex (Tile tile)
        {
            vertices.Add(new Vertex(tile));
        }

        public void removeVertex (Vertex vertex)
        {
            vertices.Remove(vertex);
        }

        public void addEdge(Vertex vertexStart, Vertex vertexEnd)
        {
            vertexStart.addEdge(vertexEnd);
        }

        public void removeEdge(Vertex vertexStart, Vertex vertexEnd)
        {
            vertexStart.removeEdge(vertexEnd);
        }

        public Vertex getVertex(Tile tile)
        {
            for(int i = 0; i < vertices.Count; i++)
            {
                if (vertices[i].getTile() == tile)
                return vertices[i];
            }
            return null;
        }

        public void addFieldVerticies(MineFieldManager fieldManager)
        {
            for(int i = 0; i < Constant.MapRow; i++)
            {
                for(int j = 0; j <Constant.MapColume; j++)
                addVertex(fieldManager.getTile(i, j));
            }
        }

        public void addFieldEdge(MineFieldManager fieldManager)
        {
            for(int i = 0; i < Constant.MapRow-1; i++)
            {
                for (int j = 0; j < Constant.MapColume; j++)
                    getVertex(fieldManager.getTile(i, j)).addEdge(getVertex(fieldManager.getTile(i + 1, j)));
            }

            for (int i = 0; i < Constant.MapRow; i++)
            {
                for (int j = 0; j < Constant.MapColume - 1; j++)
                    getVertex(fieldManager.getTile(i, j)).addEdge(getVertex(fieldManager.getTile(i, j + 1)));
            }
        }

        public void BFS(Vertex vertex)
        {

        }
    }
}
