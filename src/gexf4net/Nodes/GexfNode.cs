using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
{
    // RelaxNG specification
    // 
    // node-content =
    //     attribute id { id-type }
    //   & attribute label { xsd:token }?
    //
    // # extension point dynamics
    // node-content &= (
    //       ( attribute start { time-type }?
    //       | attribute startopen { time-type }?)
    //       & 
    //       ( attribute end { time-type }?
    //       & attribute endopen { time-type }?)
    //   )
    //   & element spells { spells-content }?
    // 
    // # extension point attributes
    // node-content &=
    //     element attvalues { attvalues-content }?
    // 
    // # extension point hierarchy
    // node-content &=
    //     attribute pid { id-type }?
    //   & element nodes { nodes-content }?
    //   & element edges { edges-content }?
    // 
    // Note: dynamic weight can be obtained by using the reserved title "weight" in attributes
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
