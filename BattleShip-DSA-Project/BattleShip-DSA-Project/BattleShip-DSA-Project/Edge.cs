using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Edge
    {
        private Vertex start;
        private Vertex end;

        public Edge(Vertex start, Vertex end)
        {
            this.start = start;
            this.end = end;
        }

        public Vertex getStart()
        {
            return start;
        }

        public Vertex getEnd()
        {
            return end;
        }
    }
}
