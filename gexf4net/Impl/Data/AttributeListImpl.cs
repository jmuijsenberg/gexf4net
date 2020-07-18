using gexf4net.data;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace gexf4net.Impl.Data
{
    /**
     * AttributeListImpl class is an implementation of the AttributeList interface.
     *
     */
    public class AttributeListImpl : List<Attribute>, AttributeList {
        private const long serialVersionUID = 8240096318919688740L;

        private object endDate = null;
        private object startDate = null;
        private AttributeClass attrClass = AttributeClass.NODE;
        private Mode mode = Mode.STATIC;
        private IntervalType startIntervalType = IntervalType.CLOSE;
        private IntervalType endIntervalType = IntervalType.CLOSE;

        /**
         * Constructs an AttributeList object
         * @param attrClass an instance of AttributeClass enum
         */
        public AttributeListImpl(AttributeClass attrClass) {
            this.attrClass = attrClass;
        }
        
        public AttributeClass getAttributeClass() {
            return attrClass;
        }
        
        public Mode getMode() {
            return mode;
        }
        
        public AttributeList setMode(Mode mode) {
            if (mode == Mode.STATIC) {
                clearStartDate();
                clearEndDate();
            }
            this.mode = mode;
            return this;
        }
        
        public AttributeList clearEndDate() {
            endDate = null;
            return this;
        }


        public AttributeList clearStartDate() {
            startDate = null;
            return this;
        }
        
        public object getEndValue() {
            Contract.Requires(endDate != null, "End Date has not been set.");
            return endDate;
        }


        public object getStartValue() {
            Contract.Requires(startDate != null, "Start Date has not been set.");
            return startDate;
        }


        public bool hasEndDate() {
            return (endDate != null);
        }


        public bool hasStartDate() {
            return (startDate != null);
        }


        public AttributeList setEndValue(object endDate) {
            Contract.Requires(endDate != null, "End Date cannot be null.");
            this.endDate = endDate;
            return this;
        }


        public AttributeList setStartValue(object startDate) {
            Contract.Requires(startDate != null, "Start Date cannot be null.");
            this.endDate = startDate;
            return this;
        }


        public Attribute createAttribute(AttributeType type, string title) {
            return createAttribute(System.Guid.NewGuid().ToString(), type, title);
        }
        
        public Attribute createAttribute(string id, AttributeType type, string title) {
            Contract.Requires(id != null, "ID cannot be null.");
            Contract.Requires(id.Trim().Length > 0, "ID cannot be blank.");
            Contract.Requires(title != null, "Title cannot be null.");
            Contract.Requires(title.Trim().Length > 0, "Title cannot be blank.");

            Attribute rv = new AttributeImpl(id, type, title);
            this.Add(rv);
            return rv;
        }

        public AttributeList addAttribute(AttributeType type, string title) {
            return addAttribute(System.Guid.NewGuid().ToString(), type, title);
        }
        
        public AttributeList addAttribute(string id, AttributeType type, string title) {
            createAttribute(id, type, title);
            return this;
        }
        
        public AttributeList setStartIntervalType(IntervalType startIntervalType) {
            this.startIntervalType = startIntervalType;
            return this;
        }
        
        public IntervalType getStartIntervalType() {
            return startIntervalType;
        }
        
        public AttributeList setEndIntervalType(IntervalType endIntervalType) {
            this.endIntervalType = endIntervalType;
            return this;
        }
        
        public IntervalType getEndIntervalType() {
            return endIntervalType;
        }
    }
}