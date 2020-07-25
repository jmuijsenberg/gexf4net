using gexf4net;
using gexf4net.data;
using gexf4net.Impl;
using gexf4net.Impl.Data;
using gexf4net.viz;
using System;
using System.IO;
using System.Xml;

public class StaticGexfGraph
{

    public static void main(string[] args)
    {
        Gexf gexf = new GexfImpl();
        DateTime date = DateTime.Now;

        gexf.getMetadata()
            .setLastModified(date)
            .setCreator("Gephi.org")
            .setDescription("A Web network");
        gexf.setVisualization(true);

        Graph graph = gexf.getGraph();
        graph.setDefaultEdgeType(EdgeType.UNDIRECTED).setMode(Mode.STATIC);

        AttributeList attrList = new AttributeListImpl(AttributeClass.NODE);
        graph.getAttributeLists().Add(attrList);

        gexf4net.data.Attribute attUrl = attrList.createAttribute("0", AttributeType.STRING, "url");
        gexf4net.data.Attribute attIndegree = attrList.createAttribute("1", AttributeType.FLOAT, "indegree");
        gexf4net.data.Attribute attFrog = attrList.createAttribute("2", AttributeType.BOOLEAN, "frog")
            .setDefaultValue("true");


        Node gephi = graph.createNode("0");
        gephi
            .setLabel("Gephi")
            .setSize(20)
            .getAttributeValues()
                .addValue(attUrl, "http://gephi.org")
                .addValue(attIndegree, "1");
        gephi.getShapeEntity().setNodeShape(NodeShape.DIAMOND).setUri("GephiURI");

        Node webatlas = graph.createNode("1");
        webatlas
            .setLabel("Webatlas")
            .getAttributeValues()
                .addValue(attUrl, "http://webatlas.fr")
                .addValue(attIndegree, "2");

        Node rtgi = graph.createNode("2");
        rtgi
            .setLabel("RTGI")
            .getAttributeValues()
                .addValue(attUrl, "http://rtgi.fr")
                .addValue(attIndegree, "1");

        Node blab = graph.createNode("3");
        blab
            .setLabel("BarabasiLab")
            .getAttributeValues()
                .addValue(attUrl, "http://barabasilab.com")
                .addValue(attIndegree, "1")
                .addValue(attFrog, "false");

        gephi.connectTo("0", webatlas);
        gephi.connectTo("1", rtgi);
        webatlas.connectTo("2", gephi);
        rtgi.connectTo("3", webatlas);
        gephi.connectTo("4", blab);

        StaxGraphWriter graphWriter = new StaxGraphWriter();
        using (FileStream stream = new FileStream("static_graph_sample.gexf", FileMode.Open, FileAccess.ReadWrite))
        {
            graphWriter.writeToStream(gexf, stream, "UTF-8");
        }
    }
}
