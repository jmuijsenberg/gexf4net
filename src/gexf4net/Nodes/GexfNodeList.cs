using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
{
    class GexfNodeList
    {
        private List<GexfNode> _nodes = new List<GexfNode>();

        public GexfNodeList()
        {

        }

        public void Write(XmlWriter writer, IProgress<GexfProgress> progress)
        {
            foreach (GexfNode node in _nodes)
            {
                node.Write(writer, progress);
            }
        }
    }
}
