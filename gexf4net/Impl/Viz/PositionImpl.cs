using gexf4net.viz;

namespace gexf4net.Impl.Viz
{
    /**
     * PositionImpl class is an implementation of the Position interface.
     *
     */
    public class PositionImpl : Position
    {
        private float x = 0.0f;
        private float y = 0.0f;
        private float z = 0.0f;

        /**
         * Constructs a PositionImpl object
         */
        public PositionImpl() { }

        public PositionImpl(float x, float y, float z)
        {
            setX(x);
            setY(y);
            setZ(z);
        }

        public float getX()
        {
            return x;
        }

        public Position setX(float x)
        {
            this.x = x;
            return this;
        }

        public float getY()
        {
            return y;
        }

        public Position setY(float y)
        {
            this.y = y;
            return this;
        }

        public float getZ()
        {
            return z;
        }

        public Position setZ(float z)
        {
            this.z = z;
            return this;
        }
    }
}