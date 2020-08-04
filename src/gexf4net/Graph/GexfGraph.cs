using System;
using System.Collections.Generic;
using System.Xml;
using gexf4net.Edges;
using gexf4net.Nodes;
using gexf4net.Time;

namespace gexf4net.Graph
{
    // RelaxNG specification
    //
    // graph-content =
    //     attribute defaultedgetype { defaultedgetype-type }?
    //   & attribute idtype { idtype-type }?
    //   & attribute mode { mode-type }?
    //   & (element nodes { nodes-content }
    //   ,  element edges { edges-content })
    //
    // # extension point dynamics
    // graph-content &=
    //     attribute timeformat { timeformat-type }?
    //   & (
    //       ( attribute start { time-type }?
    //       | attribute startopen { time-type }?)
    //       & 
    //       ( attribute end { time-type }?
    //       & attribute endopen { time-type }?)
    //   )
    //
    // # extension point attributes
    // graph-content &=
    //     element attributes { attributes-content }*
    // 
    // defaultedgetype-type = [ a:defaultValue = "undirected" ] 
    //     string "directed" | 
    //     string "undirected" | 
    //     string "mutual"
    // 
    // id-type = 
    //     xsd:string | xsd:integer
    // 
    // idtype-type = [ a:defaultValue = "string" ] 
    //     string "integer" |
    //     string "string"
    //
    // mode-type = [ a:defaultValue = "static" ] 
    //     string "static" | 
    //     string "dynamic" 
    //
    internal class GexfGraph : IGexfGraph, IGexfElement
    {
        private const string XmlElementName = "graph";
        private const string XmlAttibuteNameDefaultEdgeType = "defaultedgetype";
        private const string XmlAttibuteNameIdType = "idtype";
        private const string XmlAttibuteNameMode = "mode";

        private readonly GexfNodeList _nodeList = new GexfNodeList();
        private readonly GexfEdgeList _edgeList = new GexfEdgeList();

        public GexfGraph()
        {
            DefaultEdgeType = GexfEdgeType.Undirected;
            IdType = GexfIdType.String;
            Mode = GexfMode.Static;
        }

        public GexfEdgeType DefaultEdgeType { get; set; }
        public GexfIdType IdType { get; set; }
        public GexfMode Mode { get; set; }
        public IEnumerable<IGexfNode> Nodes => _nodeList.Nodes;
        public IEnumerable<IGexfEdge> Edges => _edgeList.Edges;
        public GexfTimeFormat TimeFormat { get; set; }
        public GexfTimePeriod Lifetime { get; set; }

        public IGexfNode AddNode(string id, string label)
        {
            GexfNode node = new GexfNode
            {
                Id = id,
                Label = label
            };
            _nodeList.Add(node);
            return node;
        }

        public IGexfEdge AddEdge(string id, IGexfNode source, IGexfNode target, GexfEdgeType edgeType, double weight, string label)
        {
            GexfEdge edge = new GexfEdge(DefaultEdgeType)
            {
                Id = id,
                Source = source.Id,
                Target = target.Id,
                Weight = weight,
                EdgeType = edgeType,
                Label = label
            };
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
