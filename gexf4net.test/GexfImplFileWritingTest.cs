using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gexf4net.Impl;
using gexf4net.data;
using System.IO;
using gexf4net.Impl.Data;
using System.Linq;

namespace gexf4net.test
{
    [TestClass]
    public class GexfImplFileWritingTest
    {

        //@Before
        public void setUp()
        {
            //XMLUnit.setIgnoreComments(true);
            //XMLUnit.setIgnoreWhitespace(true);

            /*
             * Timezone issues for testing
             */
            //System.setProperty("user.timezone", "Etc/GMT-2");
        }

        /**
         * Test of getGraph method, of class GexfImpl.
         */
        [TestMethod]
        public void testStaticGexfGraph()
        {
            Console.WriteLine("getGraph");
            Gexf gexf = new GexfImpl();
            DateTime date = new DateTime(2012, 4, 02);
            gexf.getMetadata()
                    .setLastModified(date)
                    .setCreator("Gephi.org")
                    .setDescription("A Web network");

            Graph graph = gexf.getGraph();
            graph.setDefaultEdgeType(EdgeType.UNDIRECTED).setMode(Mode.STATIC);

            AttributeList attrList = new AttributeListImpl(AttributeClass.NODE);
            graph.getAttributeLists().Add(attrList);

            data.Attribute attUrl = attrList.createAttribute("0", AttributeType.STRING, "url");
            data.Attribute attIndegree = attrList.createAttribute("1", AttributeType.FLOAT, "indegree");
            data.Attribute attFrog = attrList.createAttribute("2", AttributeType.BOOLEAN, "frog")
                    .setDefaultValue("true");


            Node gephi = graph.createNode("0");
            gephi
                    .setLabel("Gephi")
                    .getAttributeValues()
                    .addValue(attUrl, "http://gephi.org")
                    .addValue(attIndegree, "1");

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

            string referenceFile = "/testStaticRef.gexf";
            string outputFile = "/testStatichOut.gexf";

            FileInfo fileInfo = new FileInfo(outputFile);
            using (FileStream stream = fileInfo.OpenWrite())
            {
                StaxGraphWriter graphWriter = new StaxGraphWriter();
                graphWriter.writeToStream(gexf, stream, "UTF-8");
            }

            Assert.IsTrue(File.ReadAllBytes(referenceFile).SequenceEqual(File.ReadAllBytes(outputFile)));
        }
    }
}
