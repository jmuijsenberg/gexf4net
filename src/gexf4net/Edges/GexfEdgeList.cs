using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
{
    // Example XML output:
    //
    // <edges count="4>
    //   <edge id = "0" source="0" target="1" weight="3.167" />
    //   ...
    // </edges>
    class GexfEdgeList
    {
        private const string XmlElementName = "edges";
        private const string XmlAttibuteNameCount = "count";

        private List<GexfEdge> _edges = new List<GexfEdge>();

        public GexfEdgeList()
        {

        }

        public IEnumerable<IGexfEdge> Edges=> _edges;

        public int Count => _edges.Count;

        public void Add(GexfEdge edge)
        {
            _edges.Add(edge);
        }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            writer.WriteStartElement(XmlElementName);
            writer.WriteAttributeString(XmlAttibuteNameCount, _edges.Count.ToString());

            foreach (GexfEdge edge in _edges)
            {
                edge.Write(writer, progress);
            }

            writer.WriteEndElement();
        }
    }
}
