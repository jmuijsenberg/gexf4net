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
        private const string GexfNodeName = "gexf";
        private GexfMetadata _metaData = new GexfMetadata();
        private GexfNodeList _nodes = new GexfNodeList();
        private GexfEdgeList _edges = new GexfEdgeList();

        FileInfo _modelFile;

        public GexfModel(FileInfo modelFile)
        {
            _modelFile = modelFile;
        }

        public string Version
        {
            get
            {
                return "1.2";
            }
        }

        public IGexfGraph GetGraph(DateTime? dateTime)
        {
            return null;
        }

        public bool Write(Stream stream, IProgress<GexfProgress> progress)
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = ("  ")
            };

            using (XmlWriter writer = XmlWriter.Create(stream, settings))
            {
                writer.WriteStartDocument();

                writer.WriteStartElement(GexfNodeName, "urn:dsi-schema");
                {
                    _metaData.Write(writer, progress);
                }
                writer.WriteEndDocument();
            }

            return false;
        }

        public bool Read(Stream stream, IProgress<GexfProgress> progress)
        {
            return false;
        }
    }
}
