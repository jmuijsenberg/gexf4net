using gexf4net.dynamic;
using System.Diagnostics.Contracts;

namespace gexf4net.Impl.Dynamic
{
    public abstract class DynamicBase<T> : Dynamic<T>
    {
        private object endDate = null;
        private object startDate = null;
        private IntervalType startIntervalType = IntervalType.CLOSE;
        private IntervalType endIntervalType = IntervalType.CLOSE;

        protected abstract T getSelf();

        public DynamicBase() { }


        public T clearEndDate()
        {
            endDate = null;
            return getSelf();
        }


        public T clearStartDate()
        {
            startDate = null;
            return getSelf();
        }


        public object getEndValue()
        {
            Contract.Requires(hasEndDate(), "End Date has not been set.");
            return endDate;
        }


        public object getStartValue()
        {
            Contract.Requires(hasStartDate(), "Start Date has not been set.");
            return startDate;
        }


        public IntervalType getStartIntervalType()
        {
            return startIntervalType;
        }


        public IntervalType getEndIntervalType()
        {
            return endIntervalType;
        }


        public bool hasEndDate()
        {
            return (endDate != null);
        }


        public bool hasStartDate()
        {
            return (startDate != null);
        }


        public T setEndValue(object endDate)
        {
            Contract.Requires(endDate != null, "End Date cannot be null.");
            this.endDate = endDate;
            return getSelf();
        }


        public T setStartValue(object startDate)
        {
            Contract.Requires(startDate != null, "Start Date cannot be null.");
            this.startDate = startDate;
            return getSelf();
        }


        public T setStartIntervalType(IntervalType startIntervalType)
        {
            this.startIntervalType = startIntervalType;
            return getSelf();
        }


        public T setEndIntervalType(IntervalType endIntervalType)
        {
            this.endIntervalType = endIntervalType;
            return getSelf();
        }
    }
}