using MineSweaper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Graph
    {
        private List<Vertex> vertices;
        private MineFieldManager fieldManager;
        public Graph(MineFieldManager fieldManager) 
        {
            this.fieldManager = fieldManager;
            vertices = new List<Vertex>();
        }
        public void addVertex (Tile tile)
        {
            vertices.Add(new Vertex(tile));
        }

        public void removeVertex(Vertex vertex)
        {
            if (vertex.getEdgeList().Count > 0)
            {
                for (int i = 0; i < vertex.getEdgeList().Count; i++)
                {
                    Edge e = vertex.getEdge(i);
                    Vertex neighbor = e.getEnd();
                    neighbor.removeEdge(vertex);
                }
            }
            vertex.getEdgeList().Clear();
            vertices.Remove(vertex);
        }

        public void addEdge(Vertex vertexStart, Vertex vertexEnd)
        {
   
            vertexStart.addEdge(vertexEnd);
        }

        public void removeEdge(Vertex vertexStart, Vertex vertexEnd)
        {
            vertexStart.removeEdge(vertexEnd);
            vertexEnd.removeEdge(vertexStart);
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

        public Vertex getRandVertex()
        {
            Random random = new Random();
            return vertices[random.Next(vertices.Count)];
        }

        public Vertex getVertex(Button button)
        {
            for (int i = 0; i < vertices.Count; i++)
            {
                if (vertices[i].getTile().getButton() == button)
                    return vertices[i];
            }
            return null;
        }

        public void addFieldVerticies()
        {
            for(int i = 0; i < Constant.MapRow; i++)
            {
                for(int j = 0; j <Constant.MapColume; j++)
                addVertex(fieldManager.getTile(i, j));
            }
        }

        public void addFieldEdge()
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

            for (int i = Constant.MapRow - 1; i > 0 ; i--)
            {
                for (int j = Constant.MapColume - 1; j >= 0; j--)
                    getVertex(fieldManager.getTile(i, j)).addEdge(getVertex(fieldManager.getTile(i - 1, j)));
            }

            for (int i = Constant.MapRow -1 ; i >= 0 ; i--)
            {
                for (int j = Constant.MapColume - 1; j > 0 ; j--)
                    getVertex(fieldManager.getTile(i, j)).addEdge(getVertex(fieldManager.getTile(i, j - 1)));
            }
        }

        public void BFS(Vertex start, List<Vertex> visitedVertices)
        {
            int count = 0;
            Queue<Vertex> visitedQueue = new Queue<Vertex>();
            visitedQueue.Enqueue(start);
            while(visitedQueue.Count != 0)
            {
                Vertex current = visitedQueue.Dequeue();
                //current.getTile().getButton().BackColor = System.Drawing.Color.Green;
                fieldManager.getAI().getTileToAttack().Remove(current);
                fieldManager.getAI().getTileToAttack().Add(current);
                for(int i = 0; i < current.getEdgeList().Count; i++)
                {
                    Edge e = current.getEdge(i);
                    Vertex neighbor = e.getEnd();
                    if (!visitedVertices.Contains(neighbor))
                    {
                        if (subLimit(start, neighbor) && count < 24)
                        {
                            visitedVertices.Add(neighbor);
                            visitedQueue.Enqueue(neighbor);
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }

        public Boolean subLimit(Vertex start, Vertex neighbor)
        {
            if (Math.Abs(start.getTile().getPosRow() - neighbor.getTile().getPosRow()) > 4)
                return false;
            else if (Math.Abs(start.getTile().getPosColume() - neighbor.getTile().getPosColume()) > 4)
                return false;
            return true;
        }
    }
}
