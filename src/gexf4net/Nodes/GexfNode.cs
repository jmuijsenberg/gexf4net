using gexf4net.Attributes;
using gexf4net.Visualization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml;

namespace gexf4net.Nodes
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
    // # extension point visialization
    // node-content &=
    //     element color { color-content }?
    //   & element position { position-content }?
    //   & element size { size-content }?
    //   & element shape { node-shape-content }?
    // 
    // Note: dynamic weight can be obtained by using the reserved title "weight" in attributes
    // 
    internal class GexfNode : IGexfNode , IGexfElement
    {
        private const string XmlElementName = "node";
        private const string XmlAttibuteNameId = "id";
        private const string XmlAttibuteNameLabel = "label";

        private readonly GexfNodeList _nodes = new GexfNodeList();
        private readonly GexfColor _color = new GexfColor();
        private readonly GexfPosition _position = new GexfPosition();
        private readonly GexfSize _size = new GexfSize();
        private readonly GexfShape _shape = new GexfShape();

        public GexfNode()
        {
            Children = new List<IGexfNode>();
            AttributeValues = new List<IGexfNodeAttributeValue>();
        }


        public string Id { get; set; }
        public string Label { get; set; }
        public IList<IGexfNode> Children { get; }

        public Color? Color
        {
            get { return _color.Color; }
            set { _color.Color = value; }
        }

        public float? X
        {
            get { return _position.X; }
            set { _position.X = value; }
        }

        public float? Y
        {
            get { return _position.Y; }
            set { _position.Y = value; }
        }

        public float? Z
        {
            get { return _position.X; }
            set { _position.Z = value; }
        }

        public float? Size
        {
            get { return _size.Size; }
            set { _size.Size = value; }
        }

        public string Shape
        {
            get { return _shape.Shape; }
            set { _shape.Shape = value; }
        }

        public IEnumerable<IGexfNodeAttributeValue> AttributeValues { get; }

        public IGexfNodeAttributeValue GetAttribute(string title)
        {
            return null;
        }

        public IGexfNode AddChildNode(string id, string label)
        {
            GexfNode child = new GexfNode() { Id = id, Label = label };
            _nodes.Add(child);
            return child;
        }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            writer.WriteStartElement(XmlElementName);
            writer.WriteAttributeString(XmlAttibuteNameId, Id);
            writer.WriteAttributeString(XmlAttibuteNameLabel, Label);

            if (_nodes.Count > 0)
            {
                _nodes.Write(writer, progress);
            }

            _color.Write(writer, progress);
            _position.Write(writer, progress);
            _size.Write(writer, progress);
            _shape.Write(writer, progress);

            writer.WriteEndElement();
        }
    }
}
