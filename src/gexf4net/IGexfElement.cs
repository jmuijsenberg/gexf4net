using System;
using System.Xml;

namespace gexf4net
{
    interface IGexfElement
    {
        void Write(XmlWriter writer, IProgress<GexfProgress> progress);
    }
}
