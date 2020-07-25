using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gexf4net.Impl;
using gexf4net.data;
using System.IO;
using System.Linq;
using gexf4net.Impl.Data;
using gexf4net.dynamic;

namespace gexf4net.test
{
    [TestClass]
    public class GexfImplDefaultTest
    {

        //@BeforeClass
        public static void setUpClass()
        {
        }

        //@AfterClass
        public static void tearDownClass()
        {
        }

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

        //@After
        public void tearDown()
        {
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

            string referenceFile = "/staticGraphRef.gexf";
            string outputFile = "/staticGraphOut.gexf";

            FileInfo fileInfo = new FileInfo(outputFile);
            using (FileStream stream = fileInfo.OpenWrite())
            {
                StaxGraphWriter graphWriter = new StaxGraphWriter();
                graphWriter.writeToStream(gexf, stream, "UTF-8");
            }

            Assert.IsTrue(File.ReadAllBytes(referenceFile).SequenceEqual(File.ReadAllBytes(outputFile)));
        }

        [TestMethod]
        public void testDynamicGexfGraph()
        {
            Gexf gexf = new GexfImpl();
            DateTime date = new DateTime(2012, 4, 03);
            gexf.getMetadata()
                    .setLastModified(date)
                    .setCreator("Gephi.org")
                    .setDescription("A Web network");


            Graph graph = gexf.getGraph();
            graph.
                    setDefaultEdgeType(EdgeType.UNDIRECTED)
                    .setMode(Mode.DYNAMIC)
                    .setTimeType(TimeFormat.XSDDATETIME);

            AttributeList attrList = new AttributeListImpl(AttributeClass.NODE);
            graph.getAttributeLists().Add(attrList);

            data.Attribute attUrl = attrList.createAttribute("0", AttributeType.STRING, "url");
            data.Attribute attIndegree = attrList.createAttribute("1", AttributeType.FLOAT, "indegree");
            data.Attribute attFrog = attrList.createAttribute("2", AttributeType.BOOLEAN, "frog")
                .setDefaultValue("true");


            /**
             * Node Gephi
             */
            Node gephi = graph.createNode("0");
            gephi
                    .setLabel("Gephi")
                    .getAttributeValues()
                    .addValue(attUrl, "http://gephi.org")
                    .addValue(attIndegree, "1");

            Spell spellGephi = new SpellImpl();
            date = new DateTime(2012, 3, 28, 16, 10, 0);
            spellGephi.setStartValue(date);
            gephi.getSpells().Add(spellGephi);


            /**
             * Node Webatlas
             */
            Node webatlas = graph.createNode("1");
            webatlas
                    .setLabel("Webatlas")
                    .getAttributeValues()
                    .addValue(attUrl, "http://webatlas.fr")
                    .addValue(attIndegree, "2");

            Spell spellWebatlas1 = new SpellImpl();
            date = new DateTime(2012, 3, 28, 16, 15, 0);
            spellWebatlas1.setStartValue(date);
            date = new DateTime(2012, 3, 28, 18, 57, 2);
            spellWebatlas1.setEndValue(date);
            webatlas.getSpells().Add(spellWebatlas1);

            Spell spellWebatlas2 = new SpellImpl();
            date = new DateTime(2012, 3, 28, 20, 31, 10);
            spellWebatlas2.setStartValue(date).setStartIntervalType(IntervalType.OPEN);
            date = new DateTime(2012, 3, 28, 20, 45, 21);
            spellWebatlas2.setEndValue(date);
            webatlas.getSpells().Add(spellWebatlas2);

            Spell spellWebatlas3 = new SpellImpl();
            date = new DateTime(2012, 3, 28, 21, 0, 0);
            spellWebatlas3.setStartValue(date);
            date = new DateTime(2012, 4, 11, 10, 49, 27);
            spellWebatlas3.setEndValue(date).setEndIntervalType(IntervalType.OPEN);
            webatlas.getSpells().Add(spellWebatlas3);


            /**
             * Node RTGI
             */
            Node rtgi = graph.createNode("2");
            rtgi
                    .setLabel("RTGI")
                    .getAttributeValues()
                    .addValue(attUrl, "http://rtgi.fr")
                    .addValue(attIndegree, "1");

            Spell spellRtgi = new SpellImpl();
            date = new DateTime(2012, 3, 27, 6, 0, 0);
            spellRtgi.setStartValue(date);
            date = new DateTime(2012, 4, 19);
            spellRtgi.setEndValue(date);
            rtgi.getSpells().Add(spellRtgi);


            /**
             * Node BarabasiLab
             */
            Node blab = graph.createNode("3");
            blab
                    .setLabel("BarabasiLab")
                    .getAttributeValues()
                    .addValue(attUrl, "http://barabasilab.com")
                    .addValue(attIndegree, "3")
                    .addValue(attFrog, "false");


            /**
             * Node foobar
             */
            Node foobar = graph.createNode("4");
            foobar
                    .setLabel("FooBar")
                    .getAttributeValues()
                    .addValue(attUrl, "http://foo.bar")
                    .addValue(attIndegree, "1")
                    .addValue(attFrog, "false");


            /**
             * Edge 0 [gephi, webatlas]
             */
            Edge edge0 = gephi.connectTo("0", webatlas);

            Spell spellEdge0 = new SpellImpl();
            date = new DateTime(2012, 3, 28, 16, 15, 36);
            spellEdge0.setStartValue(date);
            date = new DateTime(2012, 3, 28, 17, 41, 5);
            spellEdge0.setEndValue(date);
            edge0.getSpells().Add(spellEdge0);


            /**
             * Edge 1 [gephi, rtgi]
             */
            Edge edge1 = gephi.connectTo("1", rtgi);

            Spell spellEdge1 = new SpellImpl();
            date = new DateTime(2012, 3, 30, 11, 16, 6);
            spellEdge1.setStartValue(date);
            date = new DateTime(2012, 4, 3, 11, 52, 6);
            spellEdge1.setEndValue(date);
            edge1.getSpells().Add(spellEdge1);


            /**
             * Edge 2 [rtgi, webatlas]
             */
            Edge edge2 = rtgi.connectTo("2", webatlas);
            Spell spellEdge2 = new SpellImpl();
            date = new DateTime(2012, 4, 1, 11, 0, 0);
            spellEdge2.setStartValue(date).setStartIntervalType(IntervalType.OPEN);
            date = new DateTime(2012, 4, 5, 11, 9, 44);
            spellEdge2.setEndValue(date);
            edge2.getSpells().Add(spellEdge2);


            /**
             * Edge 3 [gephi, blab]
             */
            Edge edge3 = gephi.connectTo("3", blab);
            Spell spellEdge3 = new SpellImpl();
            date = new DateTime(2012, 3, 30, 12, 13, 22);
            spellEdge3.setStartValue(date);
            date = new DateTime(2012, 3, 30, 12, 58, 24);
            spellEdge3.setEndValue(date);
            edge3.getSpells().Add(spellEdge3);


            /**
             * Edge 4 [webatlas, blab]
             */
            Edge edge4 = webatlas.connectTo("4", blab);
            Spell spellEdge4 = new SpellImpl();
            date = new DateTime(2012, 3, 30, 21, 2, 37);
            spellEdge4.setStartValue(date);
            date = new DateTime(2012, 3, 30, 21, 13, 37);
            spellEdge4.setEndValue(date);
            edge4.getSpells().Add(spellEdge4);


            /**
             * Edge 5 [foobar, blab]
             */
            foobar.connectTo("5", blab);

            string referenceFile = "/dynamicGraphRef.gexf";
            string outputFile = "/dynamicGraphOut.gexf";

            FileInfo fileInfo = new FileInfo(outputFile);
            StaxGraphWriter graphWriter = new StaxGraphWriter();
            using (FileStream stream = fileInfo.OpenWrite())
            {
                graphWriter.writeToStream(gexf, stream, "UTF-8");
            }

            Assert.IsTrue(File.ReadAllBytes(referenceFile).SequenceEqual(File.ReadAllBytes(outputFile)));
        }
    }
}
