using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
{
    interface IGexfElement
    {
        void Write(XmlWriter writer, IProgress<GexfProgress> progress);
    }
}
