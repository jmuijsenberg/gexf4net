using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gexf4net.Impl;
using gexf4net.data;
using gexf4net.Impl.Data;

namespace gexf4net.test
{
    [TestClass]
    public class GexfImplFileUtf8Test
    {

        //private ResourceBundle bundle = ResourceBundle.getBundle("strings");
        private GexfImpl gexf;

        public GexfImplFileUtf8Test()
        {


            gexf = new GexfImpl();
            DateTime date = new DateTime(2012, 4, 02);
            gexf.getMetadata()
                    .setLastModified(date)
                    .setCreator("Gephi.org")
                    .setDescription("LONG utf string ĄČĘĖĮŠŲŪ() ąčęėįšųū90");

            Graph graph = gexf.getGraph();
            graph.setDefaultEdgeType(EdgeType.UNDIRECTED).setMode(Mode.STATIC);

            AttributeList attrList = new AttributeListImpl(AttributeClass.NODE);
            graph.getAttributeLists().Add(attrList);

            data.Attribute attrSome = attrList.createAttribute("0", AttributeType.STRING, "someThing");


            //Node gephi = graph.createNode("0");
            //gephi
            //        .setLabel(bundle.getString("name"))
            //        .getAttributeValues()
            //        .addValue(attrSome, "Some string");

            //Node webatlas = graph.createNode("1");
            //webatlas
            //        .setLabel(bundle.getString("string"))
            //        .getAttributeValues()
            //        .addValue(attrSome, bundle.getString("string.two"));


            //gephi.connectTo("0", webatlas);
            //webatlas.connectTo("1", gephi);

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

        /**
         * Test of getGraph method, of class GexfImpl.
         */
        [TestMethod]
        public void testStaticGexfGraph()
        {
            //        Console.WriteLine("getGraph");
            //        StaxGraphWriter graphWriter = new StaxGraphWriter();
            //        StringWriter stringWriter = new StringWriter();

            //        graphWriter.writeToStream(gexf, new FileWriter("target/testStaticUtf.gexf"), "UTF-8");
            //        graphWriter.writeToStream(gexf, stringWriter, "UTF-8");
            //        String found = IOUtils.toString(new FileReader("target/testStaticUtf.gexf"));
            //        String start = stringWriter.toString();


            //        Diff myDiff = new Diff(found, start);

            ////        myDiff.overrideElementQualifier(new ElementNameAndTextQualifier());
            //        assertTrue("XML similar " + myDiff.toString(),
            //                myDiff.similar());
        }

        [TestMethod]
        public void testStaticGexfGraphStreams()
        {
            //        Console.WriteLine("testStaticGexfGraphStreams");

            //        StaxGraphWriter graphWriter = new StaxGraphWriter();
            //        StringWriter stringWriter = new StringWriter();

            //        graphWriter.writeToStream(gexf, new FileOutputStream("target/testStaticUtf2.gexf"), "UTF-8");
            //        graphWriter.writeToStream(gexf, stringWriter, "UTF-8");
            //        String found = IOUtils.toString(new InputStreamReader(new FileInputStream("target/testStaticUtf2.gexf"), "UTF-8"));
            //        String start = stringWriter.toString();


            //        InputStream inputStream = GexfImplFileUtf8Test.class.getResourceAsStream("/testStaticUtf.gexf");
            //        String control = IOUtils.toString(inputStream, "UTF-8");

            //        Console.WriteLine(start);
            //        Diff myDiff = new Diff(found, start);

            ////        myDiff.overrideElementQualifier(new ElementNameAndTextQualifier());
            //        assertTrue("XML similar " + myDiff.toString(),
            //                myDiff.similar());



            //        Diff secondDiff = new Diff(found, control);

            ////        myDiff.overrideElementQualifier(new ElementNameAndTextQualifier());
            //        assertTrue("XML similar " + secondDiff.toString(),
            //                secondDiff.similar());
        }

        [TestMethod]
        public void testStaticGexfGraphAgaintControl()
        {
            //        Console.WriteLine("testStaticGexfGraphAgaintControl");

            //        StaxGraphWriter graphWriter = new StaxGraphWriter();
            //        StringWriter stringWriter = new StringWriter();

            //        graphWriter.writeToStream(gexf, stringWriter, "UTF-8");
            //        String start = stringWriter.toString();

            //        assertTrue(start.contains("LONG utf string ĄČĘĖĮŠŲŪ() ąčęėįšųū90"));

            //        InputStream inputStream = GexfImplFileUtf8Test.class.getResourceAsStream("/testStaticUtf.gexf");
            //        String control = IOUtils.toString(inputStream, "UTF-8");

            //        BufferedWriter out = new BufferedWriter(
            //                new OutputStreamWriter(
            //                new FileOutputStream("target/testStaticGexfGraphAgaintControl.gexf"), "UTF-8"));
            //        out.write(control);
            //        out.close();

            //        Console.WriteLine(start);
            //        Console.WriteLine(control);
            //        Diff myDiff = new Diff(control, start);

            ////        myDiff.overrideElementQualifier(new ElementNameAndTextQualifier());
            //        assertTrue("XML similar " + myDiff.toString(),
            //                myDiff.similar());
        }
    }
}
