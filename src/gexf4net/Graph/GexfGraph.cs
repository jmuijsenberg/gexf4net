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
    //  <graph defaultedgetype="directed">
    //    <nodes>
    //      <node id = "0" label="Hello" />
    //      <node id = "1" label="Word" />
    //      ...
    //    </nodes>
    //   <edges>
    //     <edge id = "0" source="0" target="1" weight="3.167" />
    //     ...
    //   </edges>
    //  </graph>
    internal class GexfGraph : IGexfGraph, IGexfElement
    {
        private const string XmlElementName = "graph";
        private const string XmlAttibuteNameDefaultEdgeType = "defaultedgetype";
        private const string XmlAttibuteNameIdType = "idtype";
        private const string XmlAttibuteNameMode = "mode";

        private GexfNodeList _nodeList = new GexfNodeList();
        private GexfEdgeList _edgeList = new GexfEdgeList();

        public GexfGraph()
        {
            DefaultEdgeType = GexfEdgeType.Undirected;
            IdType = GexfIdType.String;
            Mode = GexfMode.Static;
        }

        public GexfEdgeType DefaultEdgeType { get; set; }
        public GexfIdType IdType { get; set; }
        public GexfMode Mode { get; set; }
        public IList<IGexfNode> Nodes { get; }
        public IList<IGexfEdge> Edges { get; }
        public GexfTimeFormat TimeFormat { get; set; }
        public GexfSpell Lifetime { get; set; }

        public IGexfNode AddNode(string id, string label)
        {
            GexfNode node = new GexfNode();
            node.Id = id;
            node.Label = label;
            _nodeList.Add(node);
            return node;
        }

        public IGexfEdge AddEdge(string id, IGexfNode source, IGexfNode target, GexfEdgeType edgeType, double weight, string label)
        {
            GexfEdge edge = new GexfEdge(DefaultEdgeType);
            edge.Id = id;
            edge.Source = source.Id;
            edge.Target = target.Id;
            edge.Weight = weight;
            edge.EdgeType = edgeType;
            edge.Label = label;
            _edgeList.Add(edge);
            return edge;
        }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            writer.WriteStartElement(XmlElementName);
            writer.WriteAttributeString(XmlAttibuteNameDefaultEdgeType, DefaultEdgeType.ToString());
            writer.WriteAttributeString(XmlAttibuteNameIdType, IdType.ToString());
            writer.WriteAttributeString(XmlAttibuteNameMode, Mode.ToString());

            _nodeList.Write(writer, progress);
            _edgeList.Write(writer, progress);

            writer.WriteEndElement();
        }
    }
}
