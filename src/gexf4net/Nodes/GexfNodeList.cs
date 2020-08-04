using System;
using System.Collections.Generic;
using System.Xml;

namespace gexf4net.Nodes
{
    // RelaxNG specification
    //
    // nodes-content =
    //     attribute count { xsd:nonNegativeInteger }?
    //   & element node { node-content }*
    //
    internal class GexfNodeList : IGexfElement
    {
        private const string XmlElementName = "nodes";
        private const string XmlAttibuteNameCount = "count";

        private readonly List<GexfNode> _nodes = new List<GexfNode>();

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
