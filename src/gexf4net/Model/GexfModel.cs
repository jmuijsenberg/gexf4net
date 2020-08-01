using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace gexf4net
{
    public class GexfModel
    {
        private const string XmlRootElementName = "gexf";
        private const string XmlNamespace = "http://www.gexf.net/1.2draft";
        private const string XMlVersionAttributeName = "version";

        private GexfMode _mode;
        private GexfMetadata _metadata = new GexfMetadata();
        private GexfGraph _graph = new GexfGraph();

        FileInfo _modelFile;

        public GexfModel(FileInfo modelFile, GexfMode mode, DateTime lastModifiedDate)
        {
            _modelFile = modelFile;
            _mode = mode;
            _metadata.LastModifiedDate = lastModifiedDate;
        }

        public string Version
        {
            get
            {
                return "1.2";
            }
        }

        public string Creator
        {
            get { return _metadata.Creator; }
            set { _metadata.Creator = value; }
        }

        public string Description
        {
            get { return _metadata.Description; }
            set { _metadata.Description = value; }
        }

        public string Keywords
        {
            get { return _metadata.Keywords; }
            set { _metadata.Keywords = value; }
        }

        public DateTime? LastModifiedDate
        {
            get { return _metadata.LastModifiedDate; }
            set { _metadata.LastModifiedDate = value; }
        }

        public IGexfGraph GetGraphAtDateTime(DateTime dateTime)
        {
            return null;
        }

        public bool Write(IProgress<GexfProgress> progress)
        {
            using (FileStream stream = _modelFile.Create())
            {
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true,
                    IndentChars = ("  ")
                };

                using (XmlWriter writer = XmlWriter.Create(stream, settings))
                {
                    writer.WriteStartDocument();

                    writer.WriteStartElement(XmlRootElementName, XmlNamespace);
                    writer.WriteAttributeString(XMlVersionAttributeName, Version);

                    _metadata.Write(writer, progress);
                    _graph.Write(writer, progress);

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }

            return false;
        }

        public bool Read(IProgress<GexfProgress> progress)
        {
            return false;
        }

        public IGexfNode AddNode(string id, string label)
        {
            return _graph.AddNode(id, label);
        }

        public IGexfEdge AddEdge(string id, IGexfNode source, IGexfNode target, GexfEdgeType edgeType, double weight = 1.0, string label = "")
        {
            return _graph.AddEdge(id, source, target, edgeType, weight, label);
        }
    }
}
