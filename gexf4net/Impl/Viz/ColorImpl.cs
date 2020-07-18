using gexf4net.viz;
using System.Diagnostics.Contracts;

namespace gexf4net.Impl.Viz
{
    /**
     * ColorImpl class is an implmentation of the Color interface.
     *
     */
    public class ColorImpl : Color
    {
        private int r = 0;
        private int g = 0;
        private int b = 0;

        /**
         * Constructs a ColorImpl object
         */
        public ColorImpl() { }

        public ColorImpl(int r, int g, int b)
        {
            setR(r);
            setG(g);
            setB(b);
        }


        public int getR()
        {
            return r;
        }


        public Color setR(int r)
        {
            Contract.Requires(r >= 0, "Color value cannot be less than 0.");
            Contract.Requires(r <= 255, "Color value cannot be greater than 255.");
            this.r = r;
            return this;
        }


        public int getG()
        {
            return g;
        }


        public Color setG(int g)
        {
            Contract.Requires(g >= 0, "Color value cannot be less than 0.");
            Contract.Requires(g <= 255, "Color value cannot be greater than 255.");
            this.g = g;
            return this;
        }


        public int getB()
        {
            return b;
        }


        public Color setB(int b)
        {
            Contract.Requires(b >= 0, "Color value cannot be less than 0.");
            Contract.Requires(b <= 255, "Color value cannot be greater than 255.");
            this.b = b;
            return this;
        }
    }
}