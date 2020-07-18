using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace gexf4net.Impl
{
    /**
     * MetadataImpl class is an implementation of the Metadata interface.
     *
     */
    public class MetadataImpl : Metadata
    {
        private string creator = null;
        private string description = null;
        private List<string> keywords = null;
        private DateTime? lastModified = null;

        /**
         * This constructor is called by GexfImpl() constructor
         */
        public MetadataImpl()
        {
            keywords = new List<string>();
        }

        public List<string> getKeywords()
        {
            return keywords;
        }

        public bool hasCreator()
        {
            return (creator != null);
        }

        public Metadata clearCreator()
        {
            creator = null;
            return this;
        }

        public string getCreator()
        {
            Contract.Requires(hasCreator(), "Creator has not been set.");
            return creator;
        }

        public Metadata setCreator(string creator)
        {
            Contract.Requires(creator != null, "Creator cannot be set to null.");
            this.creator = creator;
            return this;
        }

        public bool hasDescription()
        {
            return (description != null);
        }

        public Metadata clearDescription()
        {
            description = null;
            return this;
        }

        public string getDescription()
        {
            Contract.Requires(hasDescription(), "Description has not been set.");
            return description;
        }

        public Metadata setDescription(String description)
        {
            Contract.Requires(description != null, "Description cannot be set to null.");
            this.description = description;
            return this;
        }

        public bool hasLastModified()
        {
            return (lastModified != null);
        }

        public Metadata clearLastModified()
        {
            lastModified = null;
            return this;
        }

        public DateTime? getLastModified()
        {
            Contract.Requires(hasLastModified(), "Last Modified has not been set.");
            return lastModified;
        }


        public Metadata setLastModified(DateTime? lastModified)
        {
            Contract.Requires(lastModified != null, "Last Modified cannot be set to null.");
            this.lastModified = lastModified;
            return this;
        }


        public Metadata clearMetadata()
        {
            creator = null;
            description = null;
            lastModified = null;
            keywords.Clear();
            return this;
        }


        public bool isEmpty()
        {
            return (getKeywords().Count == 0 &&
                    !hasCreator() &&
                    !hasDescription() &&
                    !hasLastModified());
        }
    }
}