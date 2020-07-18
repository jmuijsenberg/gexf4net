using gexf4net.dynamic;
using System.Diagnostics.Contracts;

namespace gexf4net.Impl
{
    /**
     * SpellImpl class is an implementation of the Spell interface.
     *
     */
    public class SpellImpl : Spell
    {
        private object startDate = null;
        private object endDate = null;
        private IntervalType startIntervalType = IntervalType.CLOSE;
        private IntervalType endIntervalType = IntervalType.CLOSE;

        /**
         * Constructs a Spell element
         */
        public SpellImpl() { }

        public bool hasStartDate()
        {
            return (startDate != null);
        }

        public Spell clearStartDate()
        {
            startDate = null;
            return this;
        }

        public object getStartValue()
        {
            Contract.Requires(hasStartDate(), "Start Data has not been set.");
            return startDate;
        }


        public Spell setStartValue(object startDate)
        {
            Contract.Requires(startDate != null, "Start Date cannot be set to null.");
            this.startDate = startDate;
            return this;
        }

        public bool hasEndDate()
        {
            return (endDate != null);
        }

        public Spell clearEndDate()
        {
            endDate = null;
            return this;
        }

        public object getEndValue()
        {
            Contract.Requires(hasEndDate(), "End Data has not been set.");
            return endDate;
        }

        public Spell setEndValue(object endDate)
        {
            Contract.Requires(endDate != null, "End Date cannot be set to null.");
            this.endDate = endDate;
            return this;
        }

        public Spell setStartIntervalType(IntervalType startIntervalType)
        {
            this.startIntervalType = startIntervalType;
            return this;
        }

        public IntervalType getStartIntervalType()
        {
            return startIntervalType;
        }

        public Spell setEndIntervalType(IntervalType endIntervalType)
        {
            this.endIntervalType = endIntervalType;
            return this;
        }

        public IntervalType getEndIntervalType()
        {
            return endIntervalType;
        }
    }
}