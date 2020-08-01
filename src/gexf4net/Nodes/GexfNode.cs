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
    //  <node id = "0" label="Hello" />
    //
    internal class GexfNode : IGexfNode , IGexfElement
    {
        private const string XmlElementName = "node";
        private const string XmlAttibuteNameId = "id";
        private const string XmlAttibuteNameLabel = "label";

        private GexfNodeList _nodes = new GexfNodeList();

        public GexfNode()
        {
            Children = new List<IGexfNode>();
        }

        public string Id { get; set; }
        public string Label { get; set; }
        public IList<IGexfNode> Children { get; }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            writer.WriteStartElement(XmlElementName);
            writer.WriteAttributeString(XmlAttibuteNameId, Id);
            writer.WriteAttributeString(XmlAttibuteNameLabel, Label);

            if (_nodes.Count > 0)
            {
                _nodes.Write(writer, progress);
            }

            writer.WriteEndElement();
        }
    }
}
