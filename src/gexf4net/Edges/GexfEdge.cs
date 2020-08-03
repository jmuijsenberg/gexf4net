﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
{
    // RelaxNG specification
    //
    // edge-content =
    //     attribute id { id-type }
    //   & attribute type { edgetype-type }?
    //   & attribute label { xsd:token }?
    //   & attribute source { id-type }
    //   & attribute target { id-type }
    //   & attribute weight { weight-type }?
    // 
    // # extension point dynamics
    // edge-content &= (
    //       ( attribute start { time-type }?
    //       | attribute startopen { time-type }?)
    //       & 
    //       ( attribute end { time-type }?
    //       & attribute endopen { time-type }?)
    //   )
    //   & element spells { spells-content }?
    // 
    // # extension point attributes
    // edge-content &=
    //     element attvalues { attvalues-content }?
    // 
    // # extension point visualization
    // edge-content &=
    //     element color { color-content }?
    //   & element thickness { thickness-content }?
    //   & element shape { edge-shape-content }?
    // 
    // id-type = 
    //     xsd:string | xsd:integer
    // 
    // idtype-type = [ a:defaultValue = "string" ] 
    //     string "integer" |
    //     string "string"
    // 
    // edgetype-type = [ a:defaultValue = "undirected" ] 
    //     string "directed" | 
    //     string "undirected" | 
    //     string "mutual"
    // 
    // weight-type = [ a:defaultValue = "1.0" ] 
    //     xsd:float
    //
    internal class GexfEdge : IGexfEdge , IGexfElement
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
            if (!string.IsNullOrEmpty(Label))
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
