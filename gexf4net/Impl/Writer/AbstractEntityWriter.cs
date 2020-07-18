using gexf4net.dynamic;
using System;
using System.Diagnostics.Contracts;
using System.Xml;

namespace gexf4net.Impl.Writer
{

    public abstract class AbstractEntityWriter<T>
    {
        protected static string writerTimeType = TimeFormat.DOUBLE;

        protected static string toDouble(object number)
        {
            string returnValue = null;
            Double? value = number as Double?;
            if (value != null)
            {
                returnValue = value.ToString();
            }
            return returnValue;
        }

        protected static string toInteger(object number)
        {
            string returnValue = null;
            Double? value = number as Int32?;
            if (value != null)
            {
                returnValue = value.ToString();
            }
            return returnValue;
        }

        protected string toDateString(object date)
        {
            string returnValue = null;
            DateTime? value = date as DateTime?;
            if (value != null)
            {
                returnValue = string.Format("yyyy-MM-dd", value);
            }
            return returnValue;
        }

        protected string toDateTimeString(object date)
        {
            string returnValue = null;
            DateTime? value = date as DateTime?;
            if (value != null)
            {
                returnValue = string.Format("yyyy-MM-dd'T'HH:mm:ss.SSSZ", value);
            }
            return returnValue;
        }

        protected XmlWriter writer = null;

        protected T entity; // TODO = null;

        protected abstract string getElementName();

        protected abstract void writeAttributes();

        protected abstract void writeElements();

        public AbstractEntityWriter(XmlWriter writer, T entity)
        {
            Contract.Requires(writer != null, "XML Writer cannot be null.");
            Contract.Requires(entity != null, "Entity cannot be null.");

            this.writer = writer;
            this.entity = entity;
        }

        protected void write()
        {
            try
            {
                writeStartElement();

                writeAttributes();
                writeElements();

                writeEndElement();

            }
            catch (Exception e)
            {
                // TODO e.PrintStackTrace();
            }
        }

        protected void writeStartElement()
        {
            // TODO: writer.writeStartElement(getElementName());
        }

        protected void writeEndElement()
        {
            // TODO: writer.writeStartElement(getElementName());
        }
    }
}