using System.IO;

namespace gexf4net.Impl
{
    /**
     * StaxGraphWriter class is an implementation of the GexfWriter interface.
     *
     */
    public class StaxGraphWriter : GexfWriter
    {
        public void writeToStream(Gexf gexf, Stream outputStream, string encoding)
        {
            // TODO: Uncomment
            //try {
            //    XMLOutputFactory xmlOutputFactory = WstxOutputFactory.newInstance();
            //    XmlWriter streamWriter = xmlOutputFactory.createXmlWriter(out);

            //    PrettyPrintHandler handler = new PrettyPrintHandler(streamWriter);
            //    streamWriter = (XmlWriter) Proxy.newProxyInstance(
            //    		XmlWriter.class.getClassLoader(),
            //    		new Class[]{XmlWriter.class},
            //    		handler );

            //    streamWriter.writeStartDocument(encoding, "1.0");

            //    new GexfEntityWriter(streamWriter, gexf);

            //    streamWriter.writeEndDocument();

            //    streamWriter.flush();
            //    streamWriter.close();

            //} catch (XMLStreamException e) {
            //    throw new Exception("XML Exception: " + e.getMessage(), e);
            //}
        }
    }
}