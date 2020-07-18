using gexf4net.dynamic;
using System.Diagnostics.Contracts;
using System.Xml;

namespace gexf4net.Impl.Writer
{
    // TODO: Purpose of Dynamic<?>>
    public abstract class DynamicEntityWriter<T> : AbstractEntityWriter<T>, Dynamic<T>
    {
        protected const string ATTRIB_START = "start";
        protected const string ATTRIB_START_OPEN = "startopen";
        protected const string ATTRIB_END = "end";
        protected const string ATTRIB_END_OPEN = "endopen";
        private IntervalType startIntervalType = IntervalType.CLOSE;
        private IntervalType endIntervalType = IntervalType.CLOSE;

        public DynamicEntityWriter(XmlWriter writer, T entity) : base(writer, entity)
        {
        }


        protected override void writeAttributes()
        {

            ///** Set open or close tags */

            //startIntervalType = entity.getStartIntervalType();
            //endIntervalType = entity.getEndIntervalType();
            //string attribStart = ATTRIB_START;
            //string attribEnd = ATTRIB_END;

            //if(startIntervalType.Equals(IntervalType.OPEN)) {
            //	attribStart = ATTRIB_START_OPEN;
            //}

            //if(endIntervalType.Equals(IntervalType.OPEN)) {
            //	attribEnd = ATTRIB_END_OPEN;
            //}


            ///** Write Attributes */

            ///** double timeformat */
            //if(AbstractEntityWriter.writerTimeType.equals(TimeFormat.DOUBLE)) {
            //	if (entity.hasStartDate()) {
            //		String startValue = AbstractEntityWriter.toDouble(entity.getStartValue());
            //		Contract.Requires(startValue != null,
            //				entity.getClass().getName() + ": " +
            //				"For timeformat \"double\" please enter a Double object.");
            //		writer.writeAttribute(attribStart, startValue);
            //	}

            //	if (entity.hasEndDate()) {
            //		string endValue = AbstractEntityWriter.toDouble(entity.getEndValue());
            //		Contract.Requires(endValue != null,
            //				entity.getClass().getName() + ": " +
            //				"For timeformat \"double\" please enter a Double object.");
            //		writer.writeAttribute(attribEnd, endValue);
            //	}
            //} else
            ///** integer timeformat */
            //if(Writer.AbstractEntityWriter.writerTimeType.equals(TimeFormat.INTEGER)) {
            //	if (entity.hasStartDate()) {
            //		string startValue = toInteger(entity.getStartValue());
            //		Contract.Requires(startValue != null,
            //				entity.getClass().getName() + ": " +
            //				"For timeformat \"integer\" please enter a Integer object.");
            //		writer.writeAttribute(attribStart, startValue);
            //	}

            //	if (entity.hasEndDate()) {
            //		string endValue = toInteger(entity.getEndValue());
            //		Contract.Requires(endValue != null,
            //				entity.getClass().getName() + ": " +
            //				"For timeformat \"integer\" please enter a Integer object.");
            //		writer.writeAttribute(attribEnd, endValue);
            //	}
            //} else
            ///** date timeformat */
            //if(AbstractEntityWriter.writerTimeType.equals(TimeFormat.DATE)) {
            //	if (entity.hasStartDate()) {
            //		string startValue = toDateString(entity.getStartValue());
            //		Contract.Requires(startValue != null,
            //				entity.getClass().getName() + ": " +
            //				"For timeformat \"date\" please enter a Date object.");
            //		writer.writeAttribute(attribStart, startValue);
            //	}

            //	if (entity.hasEndDate()) {
            //		string endValue = toDateString(entity.getEndValue());
            //		Contract.Requires(endValue != null,
            //				entity.getClass().getName() + ": " +
            //				"For timeformat \"date\" please enter a Date object.");
            //		writer.writeAttribute(attribEnd, endValue);
            //	}
            //} else
            ///** dateTime timeformat */
            //if(AbstractEntityWriter.writerTimeType.equals(TimeFormat.XSDDATETIME)) {
            //	if (entity.hasStartDate()) {
            //		string startValue = toDateTimeString(entity.getStartValue());
            //		Contract.Requires(startValue != null,
            //				entity.getClass().getName() + ": " +
            //				"For timeformat \"date\" please enter a Date object.");
            //		writer.writeAttribute(attribStart, startValue);
            //	}

            //	if (entity.hasEndDate()) {
            //		string endValue = toDateTimeString(entity.getEndValue());
            //		Contract.Requires(endValue != null,
            //				entity.getClass().getName() + ": " +
            //				"For timeformat \"date\" please enter a Date object.");
            //		writer.writeAttribute(attribEnd, endValue);
            //	}
            //}
        }


        protected override void writeElements()
        {
            // do nothing
        }
    }
}