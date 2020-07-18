using System.IO;

namespace gexf4net
{
    /**
     * Interface for the GexfWriter tool.
     *
     */
    public interface GexfWriter {

        /**
         * Method to physically write the GEXF object in a file
         *
         * @param gexf the current object of the GEXF file
         * @param outputStream the OutputStream of the output file
         * @param encoding the encoding of the output file, e.g. UTF-8
         * @throws IOException
         */
        void writeToStream(Gexf gexf, Stream outputStream, string encoding);
    }
}