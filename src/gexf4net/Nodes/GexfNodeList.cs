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
    //  <nodes count="3">
    //    <node id = "0" label="Hello" />
    //    <node id = "1" label="Word" />
    //    ...
    //  </nodes>
    //
    class GexfNodeList
    {
        private const string XmlElementName = "nodes";
        private const string XmlAttibuteNameCount = "count";

        private List<GexfNode> _nodes = new List<GexfNode>();

        public GexfNodeList()
        {

        }

        public IEnumerable<IGexfNode> Nodes => _nodes;

        public void Add(GexfNode node)
        {
            _nodes.Add(node);
        }

        public int Count => _nodes.Count;

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            writer.WriteStartElement(XmlElementName);
            writer.WriteAttributeString(XmlAttibuteNameCount, _nodes.Count.ToString());

            foreach (GexfNode node in _nodes)
            {
                node.Write(writer, progress);
            }

            writer.WriteEndElement();
        }
    }
}
