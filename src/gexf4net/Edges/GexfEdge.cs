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
    // <edge id = "0" source="0" target="1" weight="3.167" />
    //
    class GexfEdge : IGexfEdge
    {
        private const string XmlElementName = "edge";
        private const string XmlAttibuteNameId = "id";
        private const string XmlAttibuteNameLabel = "label";
        private const string XmlAttibuteNameSource = "source";
        private const string XmlAttibuteNameTarget = "target";
        private const string XmlAttibuteNameWeight = "weight";
        private const string XmlAttibuteNameEdgeType = "edgetype";
        private GexfEdgeType _defaultEdgeType;

        //private GexfSpellList _spells;

        public GexfEdge(GexfEdgeType defaultEdgeType)
        {
            EdgeType = _defaultEdgeType = defaultEdgeType;
            Weight = 1.0;
            //AttributeValues = new Dictionary<string, string>();
        }

        public string Id { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
        public double Weight { get; set; }
        public string Label { get; set; }
        public GexfEdgeType EdgeType { get; set; }

        //public IDictionary<string, string> AttributeValues { get; }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            writer.WriteStartElement(XmlElementName);
            writer.WriteAttributeString(XmlAttibuteNameId, Id);
            writer.WriteAttributeString(XmlAttibuteNameSource, Source);
            writer.WriteAttributeString(XmlAttibuteNameTarget, Target);
            if (Weight != 1.0)
            {
                writer.WriteAttributeString(XmlAttibuteNameWeight, Weight.ToString());
            }
            if (Label.Length > 0)
            {
                writer.WriteAttributeString(XmlAttibuteNameLabel, Label);
            }
            if (EdgeType != _defaultEdgeType)
            {
                writer.WriteAttributeString(XmlAttibuteNameEdgeType, EdgeType.ToString());
            }
            writer.WriteEndElement();
        }

        //public void Add(DateTime additionTime)
        //{
        //    if (_spells ==null)
        //    {
        //        _spells = new GexfSpellList();
        //    }

        //    _spells.AddStart(additionTime, true);
        //}

        //public void Remove(DateTime removalTime)
        //{
        //    if (_spells == null)
        //    {
        //        _spells = new GexfSpellList();
        //    }
        //    _spells.AddEnd(removalTime, true);
        //}

        //public bool IsValid(DateTime? dateTime)
        //{
        //    if ((_spells != null) && dateTime.HasValue)
        //    {
        //        return _spells.InRange(dateTime.Value);
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
    }
}
